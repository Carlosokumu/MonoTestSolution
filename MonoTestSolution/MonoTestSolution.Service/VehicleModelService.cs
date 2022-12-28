using MonoTestSolution.Repository;
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
        private SQLiteAsyncConnection _connection;
        private RepositoryDataSource _repositorydatasource;


        public VehicleModelService(SQLiteAsyncConnection connection, RepositoryDataSource repositorydatasource)
        {

            _connection = connection;
            _repositorydatasource = repositorydatasource;
            _connection.CreateTableAsync<VehicleModel>();
        }
        public async Task AddVehicleModel(VehicleModel vehicleModel)
        {
            await _connection.InsertAsync(vehicleModel);
        }

        public async Task DeleteVehicleModel(VehicleModel vehicleMake)
        {
            await _connection.DeleteAsync(vehicleMake);
        }

        public async Task<VehicleModel> GetVehicleModel(int id)
        {
            return await _connection.FindAsync<VehicleModel>(id);
        }

        public async Task<IEnumerable<VehicleModel>> GetVicleMakesAsync()
        {
            return await _connection.Table<VehicleModel>().ToListAsync();
        }

        public async Task InsertStartUpVehicleModels(List<VehicleModel> vehicleModels)
        {
            await _connection.InsertAllAsync(vehicleModels);
        }

        public async Task UpdateVehicleModel(VehicleModel vehicleModel)
        {
            await _connection.UpdateAsync(vehicleModel);       
       }
    }
}
