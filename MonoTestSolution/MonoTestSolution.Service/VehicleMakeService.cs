using MonoTestSolution.Repository;
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
        private SQLiteAsyncConnection _connection;
        private RepositoryDataSource _repositorydatasource;

    public VehicleMakeService(SQLiteAsyncConnection connection, RepositoryDataSource repositorydatasource)
    {
        _repositorydatasource = repositorydatasource;
        _connection =  connection;
        _connection.CreateTableAsync<VehicleMake>();
    }

    public async Task AddVehicleMake(VehicleMake vehicleMake)
    {
        await _connection.InsertAsync(vehicleMake);
    }

    public async Task DeleteVehicleMake(VehicleMake vehicleMake)
    {
        await _connection.DeleteAsync(vehicleMake);
    }

    public async Task<VehicleMake> GetVehicleMake(int id)
    {
        return await _connection.FindAsync<VehicleMake>(id);
    }

    public async Task<IEnumerable<VehicleMake>> GetVicleMakesAsync()
    {
        return await _connection.Table<VehicleMake>().ToListAsync();
    }

    public async Task UpdateVehicleMake(VehicleMake vehicleMake)
    {
        await _connection.UpdateAsync(vehicleMake);
    }


    public async Task InsertStartUpData(List<VehicleMake> vehicleMakes)
        {
        await _connection.InsertAllAsync(vehicleMakes);
    }
}

    
}
