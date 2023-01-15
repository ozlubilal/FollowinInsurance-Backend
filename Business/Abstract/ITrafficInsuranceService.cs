using Core.Utilities.Results;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ITrafficInsuranceService
    {
        IDataResult<List<TrafficInsurance>> GetAll();
        IDataResult<List<TrafficInsuranceListDto>> GetAllTrafficInsuranceListDto();
        IDataResult<TrafficInsurance> GetById(int id);
        IDataResult<TrafficInsuranceListDto> GetTrafficInsuranceListDtoById(int id);
        IResult Add(TrafficInsurance trafficInsurance);
        IResult Update(TrafficInsurance trafficInsurance);
        IResult Delete(TrafficInsurance trafficInsurance);
    }
}
