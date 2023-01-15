using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfPersonalInsuranceDal: EfEntityRepositoryBase<PersonalInsurance, Context>, IPersonalInsuranceDal
    {
        public List<PersonalInsuranceListDto> GetAllPersonalInsuranceListDto(Expression<Func<PersonalInsuranceListDto, bool>> filter = null)
        {
            using (Context context=new Context())
            {
                var result=from p in context.PersonalInsurances
                           join c in context.Categories
                            on p.CategoryId equals c.Id
                           join cu in context.Customers
                           on p.CustomerId equals cu.Id
                           join co in context.Companies
                           on p.CompanyId equals co.Id
                           join s in context.InsuranceStates
                           on p.StateId equals s.Id
                           select new PersonalInsuranceListDto
                           {
                               PersonalInsuranceId = p.Id,
                               IdentityNumber = cu.IdentityNumber,
                               CategoryName=c.CategoryName,
                               FirstName = cu.FirstName,
                               LastName = cu.LastName,
                               PolicyNumber = p.PolicyNumber,
                               CompanyName = co.CompanyName,
                               StartDate = p.StartDate,
                               FinishDate = p.FinishDate,
                               Price = p.Price,
                               StateName = s.StateName,
                           };
                return result.ToList();
            }
        }
    }
}
