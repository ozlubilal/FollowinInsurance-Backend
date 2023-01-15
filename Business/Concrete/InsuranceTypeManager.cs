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
    public class InsuranceTypeManager : IInsuranceTypeService
    {
        IInsuranceTypeDal _insuranceTypeDal;
        public InsuranceTypeManager(IInsuranceTypeDal insuranceTypeDal)
        {
            _insuranceTypeDal = insuranceTypeDal;
        }
        public IResult Add(InsuranceType insuranceType)
        {
            _insuranceTypeDal.Add(insuranceType);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(InsuranceType insuranceType)
        {
            _insuranceTypeDal.Delete(insuranceType);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<InsuranceType>> GetAll()
        {
            return new SuccessDataResult<List<InsuranceType>>(_insuranceTypeDal.GetList().ToList());
        }

        public IDataResult<InsuranceType> GetById(int id)
        {
            return new SuccessDataResult<InsuranceType>(_insuranceTypeDal.Get(r => r.Id == id));
        }

        public IResult Update(InsuranceType insuranceType)
        {
            _insuranceTypeDal.Update(insuranceType);
            return new SuccessResult(Messages.Updated);
        }
    }
}
