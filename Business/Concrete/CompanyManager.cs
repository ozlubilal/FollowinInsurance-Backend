using Business.Abstract;
using Business.Contans;
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
    public class CompanyManager : ICompanyService
    {
        ICompanyDal _companyDal;
        public CompanyManager(ICompanyDal companyDal)
        {
            _companyDal = companyDal;
        }
        public IResult Add(Company company)
        {
            IResult result = BusinessRules.Run(CheckIfCompanyNameExists(company.CompanyName));

            if (result != null)
            {
                return result;
            }

            _companyDal.Add(company);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(Company company)
        {
            _companyDal.Delete(company);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<Company>> GetAll()
        {
            return new SuccessDataResult<List<Company>>(_companyDal.GetList().ToList());
        }

        public IDataResult<Company> GetById(int id)
        {
            return new SuccessDataResult<Company>(_companyDal.Get(r => r.Id == id));
        }

        public IResult Update(Company company)
        {
            IResult result = BusinessRules.Run(CheckIfCompanyNameExists(company.CompanyName));

            if (result != null)
            {
                return result;
            }
            _companyDal.Update(company);
            return new SuccessResult(Messages.Updated);
        }
        private IResult CheckIfCompanyNameExists(string companyName)
        {

            var result = _companyDal.GetList(c => c.CompanyName == companyName).Any();
            if (result)
            {
                return new ErrorResult(Messages.CompanyNameAlreadyExists);
            }

            return new SuccessResult();
        }
    }
}
