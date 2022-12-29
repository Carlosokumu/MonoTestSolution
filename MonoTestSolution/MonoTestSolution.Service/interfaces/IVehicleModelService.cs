using MonoTestSolution.Service.models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;


namespace MonoTestSolution.Service.interfaces
{
    public interface IVehicleModelService
    {

        Task<IEnumerable<VehicleModel>> GetVicleMakesAsync();
        Task<VehicleModel> GetVehicleModel(int id);
        Task AddVehicleModel(VehicleModel vehicleModel);
        Task UpdateVehicleModel(VehicleModel vehicleModel);
        Task DeleteVehicleModel(VehicleModel vehicleModel);

        
    }
}
