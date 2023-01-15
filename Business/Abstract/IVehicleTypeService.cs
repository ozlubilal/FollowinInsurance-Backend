using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IVehicleTypeService
    {
        IDataResult<List<VehicleType>> GetAll();
        IDataResult<VehicleType> GetById(int id);
        IResult Add(VehicleType vehicleType);
        IResult Update(VehicleType vehicleType);
        IResult Delete(VehicleType vehicleType);
    }
}
