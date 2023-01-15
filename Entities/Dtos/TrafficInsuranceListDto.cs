using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dtos
{
    public class TrafficInsuranceListDto:IDto
    {
        public int TrafficInsuranceId { get; set; }
        public string TrafficInsuranceTypeName { get; set; }
        public string CategoryName { get; set; }
        public string IdentityNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PlateNumber { get; set; }
        public string DocumentNumber { get; set; }
        public string VehicleTypeName { get; set; }
        public string PolicyNumber { get; set; }
        public string CompanyName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime FinishDate { get; set; }
        public decimal Price { get; set; }
        public string StateName { get; set; }
    }
}
