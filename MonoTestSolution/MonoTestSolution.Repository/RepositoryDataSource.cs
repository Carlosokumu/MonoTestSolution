using AutoMapper;
using MonoTestSolution.Repository.interfaces;
using MonoTestSolution.Repository.models;
using SQLite;
using System;
using System.Collections.Generic;

namespace MonoTestSolution.Repository
{
    public class RepositoryDataSource
    {

        private SQLiteAsyncConnection _connection;

        public RepositoryDataSource(SQLiteAsyncConnection connection,IRepositoryMockDataApi irepositoryMockDataApi,IMapper imapper)
        {
            _connection = connection;
            //Create a Table  For VehicleMakeEntity and VehicleModelEntity
            _connection.CreateTableAsync<VehicleMakeEntity>();
            _connection.CreateTableAsync<VehicleModelEntity>();

            List<VehicleMakeEntity> vehicleMakes = imapper.Map<List<VehicleMakeDto>, List<VehicleMakeEntity>>(irepositoryMockDataApi.GetVehicleMakes());
            List<VehicleModelEntity> vehicleModels = imapper.Map<List<VehicleModelDto>, List<VehicleModelEntity>>(irepositoryMockDataApi.GetVehicleModels());

            _connection.InsertAllAsync(vehicleMakes);
            _connection.InsertAllAsync(vehicleModels);


        }

      
        
    }
}
