using MonoTestSolution.Repository;
using MonoTestSolution.Repository.interfaces;
using MonoTestSolution.Repository.models;
using MonoTestSolution.Service.interfaces;
using MonoTestSolution.Service.models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;





/*
    * 
      * [CRUD] Operations for the Vehicle Model
    * 
 */
namespace MonoTestSolution.Service
{
    public class VehicleModelService : IVehicleModelService
    {

        private IvehicleModelCrud _ivehicleModelCrud;
        private Imapper _imapper;


        public VehicleModelService(IvehicleModelCrud ivehicleModelCrud,Imapper imapper)
        {
            _ivehicleModelCrud = ivehicleModelCrud;
            imapper = imapper;
          
        }
        public async Task AddVehicleModel(VehicleModel vehicleModel)
        {
            var vehicleModelEntity = _imapper.Map<VehicleModel, VehicleModelEntity>(vehicleModel);
            await _ivehicleModelCrud.GetVehicleModel(vehicleModelEntity);
        }

        public async Task DeleteVehicleModel(VehicleModel vehicleModel)
        {
            var vehicleModelEntity = _imapper.Map<VehicleModel, VehicleModelEntity>(vehicleModel);
            await _ivehicleModelCrud.GetVehicleModel(vehicleModelEntity);
        }

        public async Task<VehicleModel> GetVehicleModel(int id)
        {
            var vehicleModelEntity = await _ivehicleModelCrud.GetVehicleModel(id);
            var vehicleModel = _imapper.Map<VehicleModelEntity, VehicleModel>(vehicleModelEntity);
            return vehicleModel;
        }

        public async Task<IEnumerable<VehicleModel>> GetVicleMakesAsync()
        {
            var vehicleModelsEntity = await _ivehicleModelCrud.GetVicleModelsAsync();
            var vehicleModels = _imapper.Map<List<VehicleMakeEntity>, List<VehicleMake>>(vehicleModelsEntity);
            return  vehicleModels;
        }

        

        public async Task UpdateVehicleModel(VehicleModel vehicleModel)
        {
            var vehicleModelEntity = _imapper.Map<VehicleModel, VehicleMakeEntity>(vehicleModel);
            await _ivehicleModelCrud.UpdateVehicleModel(vehicleModelEntity);
        }
    }
}
