using Business.Abstract;
using Business.Contans;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class TrafficInsuranceManager : ITrafficInsuranceService
    {
        ITrafficInsuranceDal _trafficInsuranceDal;
        public TrafficInsuranceManager(ITrafficInsuranceDal trafficInsuranceDal)
        {
            _trafficInsuranceDal = trafficInsuranceDal;
        }
        public IResult Add(TrafficInsurance trafficInsurance)
        {
            IResult result = BusinessRules.Run(CheckIfPlateNumberExist(trafficInsurance));
            if (result != null)
            {
                return result;
            }
            _trafficInsuranceDal.Add(trafficInsurance);
            return new SuccessResult(Messages.Added);
        }
        public IResult Delete(TrafficInsurance trafficInsurance)
        {
            _trafficInsuranceDal.Delete(trafficInsurance);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<TrafficInsurance>> GetAll()
        {
            return new SuccessDataResult<List<TrafficInsurance>>(_trafficInsuranceDal.GetList().ToList());
        }

        public IDataResult<List<TrafficInsuranceListDto>> GetAllTrafficInsuranceListDto()
        {
            return new SuccessDataResult<List<TrafficInsuranceListDto>>(_trafficInsuranceDal.GetAllTrafficInsuranceListDto().ToList());
        }

        public IDataResult<TrafficInsurance> GetById(int id)
        {
            return new SuccessDataResult<TrafficInsurance>(_trafficInsuranceDal.Get(r=>r.Id==id));
        }

        public IDataResult<TrafficInsuranceListDto> GetTrafficInsuranceListDtoById(int id)
        {
            return new SuccessDataResult<TrafficInsuranceListDto>(_trafficInsuranceDal.GetAllTrafficInsuranceListDto(r => r.TrafficInsuranceId == id)[0]);
        }

        public IResult Update(TrafficInsurance trafficInsurance)
        {
            IResult result = BusinessRules.Run(CheckIfPlateNumberExist(trafficInsurance));
            if (result != null)
            {
                return result;
            }
            _trafficInsuranceDal.Update(trafficInsurance);
            return new SuccessResult(Messages.Updated);
        }
        private IResult CheckIfPlateNumberExist(TrafficInsurance trafficInsurance)
        {
            var result = _trafficInsuranceDal.GetList(t => t.PlateNumber == trafficInsurance.PlateNumber &&
              t.TrafficInsuranceTypeId == trafficInsurance.TrafficInsuranceTypeId && t.StateId == 1&&
              t.Id!=trafficInsurance.Id).Any();
            if (result)
            {
                return new ErrorResult(Messages.InsuranceAlreadyExist);
            }
            return new SuccessResult();
        }
    }
}
