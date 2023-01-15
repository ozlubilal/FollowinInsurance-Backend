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
    public class InsuranceStateManager : IInsuranceStateService
    {
        IInsuranceStateDal _insuranceStateDal;
        public InsuranceStateManager(IInsuranceStateDal insuranceStateDal)
        {
            _insuranceStateDal = insuranceStateDal;
        }
        public IResult Add(InsuranceState insuranceState)
        {
            _insuranceStateDal.Add(insuranceState);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(InsuranceState insuranceState)
        {
            _insuranceStateDal.Delete(insuranceState);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<InsuranceState>> GetAll()
        {
            return new SuccessDataResult<List<InsuranceState>>(_insuranceStateDal.GetList().ToList());
        }

        public IDataResult<InsuranceState> GetById(int id)
        {
            return new SuccessDataResult<InsuranceState>(_insuranceStateDal.Get(r=>r.Id==id));
        }

        public IResult Update(InsuranceState insuranceState)
        {
            _insuranceStateDal.Update(insuranceState);
            return new SuccessResult(Messages.Updated);
        }
    }
}
