using Business.Abstract;
using Business.Contans;
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
    public class HomeInsuranceManager : IHomeInsuranceService
    {
        IHomeInsuranceDal _homeInsuranceDal;
        public HomeInsuranceManager(IHomeInsuranceDal homeInsuranceDal)
        {
            _homeInsuranceDal = homeInsuranceDal;
        }
        public IResult Add(HomeInsurance homeInsurance)
        {
            _homeInsuranceDal.Add(homeInsurance);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(HomeInsurance homeInsurance)
        {
            _homeInsuranceDal.Delete(homeInsurance);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<HomeInsurance>> GetAll()
        {
            return new SuccessDataResult<List<HomeInsurance>>(_homeInsuranceDal.GetList().ToList());
        }

        public IDataResult<List<HomeInsuranceListDto>> GetAllHomeInsuranceListDto()
        {
            return new SuccessDataResult<List<HomeInsuranceListDto>>(_homeInsuranceDal.GetAllHomeInsuranceListDto().ToList());
        }

        public IDataResult<HomeInsuranceListDto> GetHomeInsuranceListDtoById(int id)
        {
            return new SuccessDataResult<HomeInsuranceListDto>(_homeInsuranceDal.GetAllHomeInsuranceListDto(r => r.HomeInsuranceId == id)[0]);
        }

        public IDataResult<HomeInsurance> GetById(int id)
        {
            return new SuccessDataResult<HomeInsurance>(_homeInsuranceDal.Get(r => r.Id == id));
        }

        public IResult Update(HomeInsurance homeInsurance)
        {
            _homeInsuranceDal.Update(homeInsurance);
            return new SuccessResult(Messages.Updated);
        }
    }
}
