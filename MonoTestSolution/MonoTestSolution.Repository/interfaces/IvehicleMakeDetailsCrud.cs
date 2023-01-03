using MonoTestSolution.Repository.models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MonoTestSolution.Repository.interfaces
{
    public interface IvehicleMakeDetailsCrud
    {
        Task<VehicleMakeDetailsEntity> GetVehicleMakesDetails(String make);
    }
}
