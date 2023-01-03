using MonoTestSolution.Repository.models;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;
using System.Threading.Tasks;

namespace MonoTestSolution.Repository.interfaces
{
    public interface IvehicleMakeCrud
    {
        Task<List<VehicleMakeEntity>> GetVicleMakesAsync();
        Task<VehicleMakeEntity> GetVehicleMake(int id);
        Task AddVehicleMake(VehicleMakeEntity vehicleMake);
        Task UpdateVehicleMake(VehicleMakeEntity vehicleMake);
        Task DeleteVehicleMake(VehicleMakeEntity vehicleMake);
        Task<VehicleMakeEntity> GetVehicleMakeByName(String name);
        


    }
}
