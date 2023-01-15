using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ITrafficInsuranceTypeService
    {
        IDataResult<List<TrafficInsuranceType>> GetAll();
        IDataResult<TrafficInsuranceType> GetById(int id);
        IResult Add(TrafficInsuranceType trafficInsuranceType);
        IResult Update(TrafficInsuranceType trafficInsuranceType);
        IResult Delete(TrafficInsuranceType trafficInsuranceType);
    }
}
