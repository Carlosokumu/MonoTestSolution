using MonoTestSolution.Repository.interfaces;
using MonoTestSolution.Repository.models;
using SQLite;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MonoTestSolution.Repository
{
    public class VehicleMakeCrud : IvehicleMakeCrud
    {
        private SQLiteAsyncConnection _connection;



        public VehicleMakeCrud(SQLiteAsyncConnection connection)
        {
            _connection = connection;
        }

        public async Task AddVehicleMake(VehicleMakeEntity vehicleMake)
        {
            await _connection.InsertAsync(vehicleMake);
        }

        public async  Task DeleteVehicleMake(VehicleMakeEntity vehicleMake)
        {
            await _connection.DeleteAsync(vehicleMake);
        }

        public async Task<VehicleMakeEntity> GetVehicleMake(int id)
        {
            return await _connection.FindAsync<VehicleMakeEntity>(id);
        }


       




        public async Task UpdateVehicleMake(VehicleMakeEntity vehicleMake)
        {
            await _connection.UpdateAsync(vehicleMake);
        }

       public async Task<List<VehicleMakeEntity>> GetVicleMakesAsync()
        {
            return await _connection.Table<VehicleMakeEntity>().ToListAsync();
        }

        public async Task<List<VehicleMakeEntity>> GetPaginatedVehicleMakesAsync(int page)
        {
            return await _connection.QueryAsync<VehicleMakeEntity>("SELECT * FROM VehicleMakeEntity WHERE Page = ?", page);
        }

        public async Task<VehicleMakeEntity> GetVehicleMakeByName(string name)
        {
            var vehicleMakeEntity = await _connection.FindWithQueryAsync<VehicleMakeEntity>("SELECT * FROM VehicleMakeEntity WHERE Name = ?", name);
            return vehicleMakeEntity;
        }
    }
}
