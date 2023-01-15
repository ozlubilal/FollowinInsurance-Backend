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
    public class EfTrafficInsuranceDal : EfEntityRepositoryBase<TrafficInsurance, Context>, ITrafficInsuranceDal
    {
        public List<TrafficInsuranceListDto> GetAllTrafficInsuranceListDto(Expression<Func<TrafficInsuranceListDto, bool>> filter = null)
        {
            using (Context context = new Context())
            {
                var result = from t in context.TrafficInsurances
                             join c in context.Categories
                             on t.CategoryId equals c.Id
                             join cu in context.Customers
                             on t.CustomerId equals cu.Id
                             join v in context.VehicleTypes
                             on t.VehicleTypeId equals v.Id
                             join co in context.Companies
                             on t.CompanyId equals co.Id
                             join ttype in context.TrafficInsuranceTypes
                             on t.TrafficInsuranceTypeId equals ttype.Id
                             join s in context.InsuranceStates
                             on t.StateId equals s.Id
                             select new TrafficInsuranceListDto
                             {
                                 TrafficInsuranceId = t.Id,
                                 TrafficInsuranceTypeName=ttype.Name,
                                 CategoryName = c.CategoryName,
                                 IdentityNumber=cu.IdentityNumber,
                                 FirstName = cu.FirstName,
                                 LastName = cu.LastName,
                                 PlateNumber = t.PlateNumber,
                                 DocumentNumber = t.DocumentNumber,
                                 VehicleTypeName = v.Name,
                                 PolicyNumber = t.PolicyNumber,
                                 CompanyName = co.CompanyName,
                                 StartDate = t.StartDate,
                                 FinishDate = t.FinishDate,
                                 Price = t.Price,
                                 StateName = s.StateName,
                             };
                return filter == null ? result.ToList() : result.Where(filter).ToList();
            }
        }

     
    }
}
