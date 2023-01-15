using Business.Abstract;
using Business.Contans;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Business;
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
    public class CustomerManager:ICustomerService
    {
        ICustomerDal _customerDal;
        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }
        [ValidationAspect(typeof(CustomerValidator))]
        public IResult Add(Customer customer)
        {
            IResult result = BusinessRules.Run(CheckIfIdentityNumberExists(customer));
            if (result != null)
            {
                return result;
            }
            _customerDal.Add(customer);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(Customer customer)
        {
            _customerDal.Delete(customer);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<Customer>> GetAll()
        {
            return new SuccessDataResult<List<Customer>>(_customerDal.GetList().ToList());
        }
        public IDataResult<List<Customer>> GetByFullName(string firstName, string lastName)
        {
            return new SuccessDataResult<List<Customer>>(_customerDal.GetList(r=>r.FirstName==firstName&&r.LastName==lastName).ToList());
        }

        public IDataResult<Customer> GetById(int id)
        {
            return new SuccessDataResult<Customer>(_customerDal.Get(r => r.Id == id));
        }
        public IDataResult<Customer> GetByIdentityNumber(string identityNumber)
        {
            return new SuccessDataResult<Customer>(_customerDal.Get(r => r.IdentityNumber == identityNumber));
        }

        public IResult Update(Customer customer)
        {
            IResult result = BusinessRules.Run(CheckIfIdentityNumberExists(customer));
            if (result != null)
            {
                return result;
            }
            _customerDal.Update(customer);
            return new SuccessResult(Messages.Updated);
        }

        private IResult CheckIfIdentityNumberExists(Customer customer)
        {

            var result = _customerDal.GetList(c => c.IdentityNumber == customer.IdentityNumber&&c.Id!=customer.Id).Any();
            if (result)
            {
                return new ErrorResult(Messages.CustomerAlreadyExists);
            }

            return new SuccessResult();
        }
    }

}
