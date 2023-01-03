using MonoTestSolution.Service.models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MonoTestSolution.Service.interfaces
{
    public interface IvehicleMakeDetailsService
    {
        Task<VehicleMakeDetails> GetVehicleMakeDetails(string make);

        Task<List<VehicleModel>> GetVehicleMakeModels(string make);
    }
   
}
