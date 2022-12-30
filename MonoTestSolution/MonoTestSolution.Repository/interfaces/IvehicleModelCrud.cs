using MonoTestSolution.Repository.models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MonoTestSolution.Repository.interfaces
{
    public interface IvehicleModelCrud
    {
        Task<List<VehicleModelEntity>> GetVicleModelsAsync();
        Task<VehicleModelEntity> GetVehicleModel(int id);
        Task AddVehicleModel(VehicleModelEntity vehicleModel);
        Task UpdateVehicleModel(VehicleModelEntity vehicleModel);
        Task DeleteVehicleModel(VehicleModelEntity vehicleModel);

       
    }
}
