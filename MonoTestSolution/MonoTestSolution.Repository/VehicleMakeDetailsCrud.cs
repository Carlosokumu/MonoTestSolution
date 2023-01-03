using MonoTestSolution.Repository.interfaces;
using MonoTestSolution.Repository.models;
using SQLite;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonoTestSolution.Repository
{
    public class VehicleMakeDetailsCrud : IvehicleMakeDetailsCrud
    {

        private SQLiteAsyncConnection _connection;

        public VehicleMakeDetailsCrud(SQLiteAsyncConnection connection)
        {
            _connection = connection;
        }
      


        public async Task<VehicleMakeDetailsEntity> GetVehicleMakesDetails(string make)
        {
            var vehicleMakeEntity = await _connection.FindWithQueryAsync<VehicleMakeDetailsEntity>("SELECT * FROM VehicleMakeDetailsEntity WHERE Make = ?", make);
            return vehicleMakeEntity;
        }
    }
}
