using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IInsuranceTypeService
    {
        IDataResult<List<InsuranceType>> GetAll();
        IDataResult<InsuranceType> GetById(int id);
        IResult Add(InsuranceType insuranceType);
        IResult Update(InsuranceType insuranceType);
        IResult Delete(InsuranceType insuranceType);
    }
}
