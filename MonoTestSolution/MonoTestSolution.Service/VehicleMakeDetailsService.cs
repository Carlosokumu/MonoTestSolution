using AutoMapper;
using MonoTestSolution.Repository;
using MonoTestSolution.Repository.interfaces;
using MonoTestSolution.Repository.models;
using MonoTestSolution.Service.interfaces;
using MonoTestSolution.Service.models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MonoTestSolution.Service
{
    public class VehicleMakeDetailsService : IvehicleMakeDetailsService
    {

        private IvehicleMakeDetailsCrud _ivehicleMakeDetails;
        private IMapper _imapper;
        private IRepositoryMockDataApi _repositoryMockDataApi;


        public VehicleMakeDetailsService(IvehicleMakeDetailsCrud ivehicleMakeDetails, IMapper imapper,IRepositoryMockDataApi repositoryMockDataApi)
        {
            _ivehicleMakeDetails = ivehicleMakeDetails;
            _imapper = imapper;
            _repositoryMockDataApi = repositoryMockDataApi;
        }

      

      

        public async Task<VehicleMakeDetails> GetVehicleMakeDetails(string make)
        {
            var vehicleMakeEntity = await _ivehicleMakeDetails.GetVehicleMakesDetails(make);
            var vehicleMakeDetails = _imapper.Map<VehicleMakeDetailsEntity, VehicleMakeDetails>(vehicleMakeEntity);
            return vehicleMakeDetails;
        }

        public async Task<List<VehicleModel>> GetVehicleMakeModels(string make)
        {
            var repovehicleModels = await _repositoryMockDataApi.GetVehicleModels(make);
            var vehicleModels = _imapper.Map<List<VehicleModelDto>, List<VehicleModel>>(repovehicleModels);
            return vehicleModels;
        }

       
    }
}
