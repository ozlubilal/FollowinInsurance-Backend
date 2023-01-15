using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IInsuranceStateService
    {
        IDataResult<List<InsuranceState>> GetAll();
        IDataResult<InsuranceState> GetById(int id);
        IResult Add(InsuranceState insuranceState);
        IResult Update(InsuranceState insuranceState);
        IResult Delete(InsuranceState insuranceState);
    }
}
