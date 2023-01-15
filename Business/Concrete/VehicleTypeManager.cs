using Business.Abstract;
using Business.Contans;
using Business.Abstract;
using Business.Contans;
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
    public class VehicleTypeManager : IVehicleTypeService
    {
        IVehicleTypeDal _vehicleTypeDal;
        public VehicleTypeManager(IVehicleTypeDal vehicleTypeDal)
        {
            _vehicleTypeDal = vehicleTypeDal;
        }
        public IResult Add(VehicleType vehicleType)
        {
            _vehicleTypeDal.Add(vehicleType);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(VehicleType vehicleType)
        {
            _vehicleTypeDal.Delete(vehicleType);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<VehicleType>> GetAll()
        {
            return new SuccessDataResult<List< VehicleType >> (_vehicleTypeDal.GetList().ToList());
        }

        public IDataResult<VehicleType> GetById(int id)
        {
            return new SuccessDataResult<VehicleType>(_vehicleTypeDal.Get(r => r.Id == id));
        }

        public IResult Update(VehicleType vehicleType)
        {
            _vehicleTypeDal.Update(vehicleType);
            return new SuccessResult(Messages.Updated);
        }
    }
}
