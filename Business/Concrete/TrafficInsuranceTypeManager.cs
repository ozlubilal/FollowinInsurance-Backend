using Business.Abstract;
using Business.Contans;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class TrafficInsuranceTypeManager:ITrafficInsuranceTypeService
    {
        ITrafficInsuranceTypeDal _trafficInsuranceTypeDal;
        public TrafficInsuranceTypeManager(ITrafficInsuranceTypeDal trafficInsuranceTypeDal)
        {
            _trafficInsuranceTypeDal = trafficInsuranceTypeDal;
        }
        public IResult Add(TrafficInsuranceType trafficInsuranceType)
        {
            _trafficInsuranceTypeDal.Add(trafficInsuranceType);
            return new SuccessResult(Messages.Added);
        }
        public IResult Delete(TrafficInsuranceType trafficInsuranceType)
        {
            _trafficInsuranceTypeDal.Delete(trafficInsuranceType);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<TrafficInsuranceType>> GetAll()
        {
            return new SuccessDataResult<List<TrafficInsuranceType>>(_trafficInsuranceTypeDal.GetList().ToList());
        }

        public IDataResult<TrafficInsuranceType> GetById(int id)
        {
            return new SuccessDataResult<TrafficInsuranceType>(_trafficInsuranceTypeDal.Get(r => r.Id == id));
            ;
        }

        public IResult Update(TrafficInsuranceType trafficInsuranceType)
        {
            _trafficInsuranceTypeDal.Update(trafficInsuranceType);
            return new SuccessResult(Messages.Updated);
        }
    }
}
