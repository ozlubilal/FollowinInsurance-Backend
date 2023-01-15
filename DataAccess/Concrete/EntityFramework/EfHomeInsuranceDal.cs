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
    public class EfHomeInsuranceDal: EfEntityRepositoryBase<HomeInsurance, Context>, IHomeInsuranceDal
    {
        public List<HomeInsuranceListDto> GetAllHomeInsuranceListDto(Expression<Func<HomeInsuranceListDto, bool>> filter = null)
        {
            using (Context context = new Context())
            {
                var result = from h in context.HomeInsurances
                             join c in context.Categories
                             on h.CategoryId equals c.Id
                             join cu in context.Customers
                             on h.CustomerId equals cu.Id
                             join co in context.Companies
                             on h.CompanyId equals co.Id
                             join s in context.InsuranceStates
                             on h.StateId equals s.Id
                             select new HomeInsuranceListDto
                             {
                                 HomeInsuranceId = h.Id,
                                 CategoryName=c.CategoryName,
                                 IdentityNumber = cu.IdentityNumber,
                                 FirstName = cu.FirstName,
                                 LastName = cu.LastName,
                                 PolicyNumber = h.PolicyNumber,
                                 CompanyName = co.CompanyName,
                                 StartDate = h.StartDate,
                                 FinishDate = h.FinishDate,
                                 Price = h.Price,
                                 StateName = s.StateName,
                             };
                return result.ToList();


            }
        }
   
    }
}
