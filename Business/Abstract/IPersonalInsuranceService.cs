using Core.Utilities.Results;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IPersonalInsuranceService
    {
        IDataResult<List<PersonalInsurance>> GetAll();
        IDataResult<List<PersonalInsuranceListDto>> GetAllPersonalInsuranceListDto();
        IDataResult<PersonalInsurance> GetById(int id);
        IDataResult<PersonalInsuranceListDto> GetPersonalInsuranceListDtoById(int id);
        IResult Add(PersonalInsurance personalInsurance);
        IResult Update(PersonalInsurance personalInsurance);
        IResult Delete(PersonalInsurance personalInsurance);
    }
}
