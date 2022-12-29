using MonoTestSolution.Repository;
using MonoTestSolution.Repository.interfaces;
using MonoTestSolution.Repository.models;
using MonoTestSolution.Service.interfaces;
using MonoTestSolution.Service.models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;
using System.Threading.Tasks;





/*
    * 
      * [CRUD] Operations for the Vehicle Make
    * 
 */

namespace MonoTestSolution.Service
{
    public class VehicleMakeService :IVehicleMakeService
    {
       
        private IvehicleMakeCrud _ivehicleMakeCrud;
        private Imapper _imapper;

    public VehicleMakeService(IvehicleMakeCrud ivehicleMakeCrud,Imapper imapper)
    {
            _ivehicleMakeCrud = ivehicleMakeCrud;
            _imapper = imapper;
    }

    public async Task AddVehicleMake(VehicleMake vehicleMake)
    {
            var vehicleMakeEntity = _imapper.Map<VehicleMake,VehicleMakeEntity>(vehicleMake);
            await _ivehicleMakeCrud.AddVehicleMake(vehicleMakeEntity);
    }

    public async Task DeleteVehicleMake(VehicleMake vehicleMake)
    {
            var vehicleMakeEntity = _imapper.Map<VehicleMake, VehicleMakeEntity>(vehicleMake);
            await _ivehicleMakeCrud.AddVehicleMake(vehicleMakeEntity);
     }

    public async Task<VehicleMake> GetVehicleMake(int id)
    {
            var vehicleMakeEntity = await _ivehicleMakeCrud.GetVehicleMake(id);
            var vehicleMake = _imapper.Map<VehicleMakeEntity, VehicleMake>(vehicleMakeEntity);
            return vehicleMake;
            
     }

    public async Task<IEnumerable<VehicleMake>> GetVicleMakesAsync()
    {
            var vehicleMakeEntity = await _ivehicleMakeCrud.GetVicleMakesAsync();
            var vehicleMakes = _imapper.Map<List<VehicleMakeEntity>, List<VehicleMake>>(vehicleMakeEntity);
            return vehicleMakes;
        }

    public async Task UpdateVehicleMake(VehicleMake vehicleMake)
    {
            var vehicleMakeEntity = _imapper.Map<VehicleMake, VehicleMakeEntity>(vehicleMake);
            await _ivehicleMakeCrud.UpdateVehicleMake(vehicleMakeEntity);
     }


   
}

    
}
