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
    public interface IHomeInsuranceService
    {
        IDataResult<List<HomeInsurance>> GetAll();
        IDataResult<List<HomeInsuranceListDto>> GetAllHomeInsuranceListDto();
        IDataResult<HomeInsurance> GetById(int id);
        IDataResult<HomeInsuranceListDto> GetHomeInsuranceListDtoById(int id);
        IResult Add(HomeInsurance homeInsurance);
        IResult Update(HomeInsurance homeInsurance);
        IResult Delete(HomeInsurance homeInsurance);
    }
}
