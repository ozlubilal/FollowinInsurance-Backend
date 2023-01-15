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
    public class PersonalInsuranceManager : IPersonalInsuranceService
    {
        IPersonalInsuranceDal _personalInsuranceDal;
        public PersonalInsuranceManager(IPersonalInsuranceDal personalInsuranceDal)
        {
            _personalInsuranceDal = personalInsuranceDal;
        }

        public IResult Add(PersonalInsurance personalInsurance)
        {
            _personalInsuranceDal.Add(personalInsurance);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(PersonalInsurance personalInsurance)
        {
            _personalInsuranceDal.Delete(personalInsurance);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<PersonalInsurance>> GetAll()
        {
            return new SuccessDataResult<List<PersonalInsurance>>(_personalInsuranceDal.GetList().ToList());
        }

        public IDataResult<PersonalInsurance> GetById(int id)
        {
            return new SuccessDataResult<PersonalInsurance>(_personalInsuranceDal.Get(r=>r.Id==id));
        }
        public IDataResult<List<PersonalInsuranceListDto>> GetAllPersonalInsuranceListDto()
        {
            return new SuccessDataResult<List<PersonalInsuranceListDto>>(_personalInsuranceDal.GetAllPersonalInsuranceListDto().ToList());
        }
        public IResult Update(PersonalInsurance personalInsurance)
        {
            _personalInsuranceDal.Update(personalInsurance);
            return new SuccessResult(Messages.Updated);
        }

        public IDataResult<PersonalInsuranceListDto> GetPersonalInsuranceListDtoById(int id)
        {
            return new SuccessDataResult<PersonalInsuranceListDto>(_personalInsuranceDal.GetAllPersonalInsuranceListDto(r => r.PersonalInsuranceId == id)[0]);
        }
    }
}
