using MonoTestSolution.Repository.interfaces;
using MonoTestSolution.Repository.models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MonoTestSolution.Repository
{
    public class VehicleModelCrud : IvehicleModelCrud
    {
        private SQLiteAsyncConnection _connection;


        public VehicleModelCrud(SQLiteAsyncConnection connection)
        {
            _connection = connection;
        }

        public async Task AddVehicleModel(VehicleModelEntity vehicleModel)
        {
            await _connection.InsertAsync(vehicleModel);
        }

        public async Task DeleteVehicleModel(VehicleModelEntity vehicleModel)
        {
            await _connection.DeleteAsync(vehicleModel);
        }

        public async Task<VehicleModelEntity> GetVehicleModel(int id)
        {
            return await _connection.FindAsync<VehicleModelEntity>(id);
        }

        public async Task<IEnumerable<VehicleModelEntity>> GetVicleModelsAsync()
        {
            return await _connection.Table<VehicleModelEntity>().ToListAsync();
        }

        public async Task UpdateVehicleModel(VehicleModelEntity vehicleModel)
        {
            await _connection.UpdateAsync(vehicleModel);
        }
    }
}
