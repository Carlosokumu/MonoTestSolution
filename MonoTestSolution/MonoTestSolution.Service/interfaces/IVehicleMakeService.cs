﻿using MonoTestSolution.Service.models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;


namespace MonoTestSolution.Service.interfaces
{
    public interface IVehicleMakeService
    {
        Task<IEnumerable<VehicleMake>> GetVicleMakesAsync();
        Task<VehicleMake> GetVehicleMake(int id);
        Task AddVehicleMake(VehicleMake vehicleMake);
        Task UpdateVehicleMake(VehicleMake vehicleMake);
        Task DeleteVehicleMake(VehicleMake vehicleMake);

       
    }
}
