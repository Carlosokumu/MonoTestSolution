using MonoTestSolution.Repository.models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MonoTestSolution.Repository.interfaces
{
    public interface IRepositoryMockDataApi
    {
        List<VehicleMakeDto> GetVehicleMakes();

        List<VehicleModelDto> GetVehicleModels();
    }
}
