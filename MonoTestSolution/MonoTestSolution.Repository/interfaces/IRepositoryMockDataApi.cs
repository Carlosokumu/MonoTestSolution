using MonoTestSolution.Repository.models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MonoTestSolution.Repository.interfaces
{
    public interface IRepositoryMockDataApi
    {
        
        Task<List<VehicleModelDto>> GetVehicleModels(string make);
       


       
    }
}
