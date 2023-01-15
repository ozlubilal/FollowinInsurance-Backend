using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class TrafficInsurance:IEntity
    {
        public int Id { get; set; }
        public int TrafficInsuranceTypeId { get; set; }
        public int CategoryId { get; set; }
        public int CustomerId { get; set; }
        public string PlateNumber { get; set; }
        public string DocumentNumber { get; set; }
        public int VehicleTypeId { get; set; }
        public string PolicyNumber { get; set; }
        public int CompanyId { get; set; }      
        public DateTime StartDate { get; set; }
        public DateTime FinishDate { get; set; }
        public decimal Price { get; set; }
        public int StateId { get; set; }
    }
}
