using AutoMapper;
using MonoTestSolution.Repository.interfaces;
using MonoTestSolution.Repository.models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;

namespace MonoTestSolution.Repository
{
    public class RepositoryDataSource
    {

        private SQLiteAsyncConnection _connection;

        public RepositoryDataSource(SQLiteAsyncConnection connection,IRepositoryMockDataApi irepositoryMockDataApi,IMapper imapper)
        {
            _connection = connection;
            string DatabasePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Cars.db");
            Assembly assembly = IntrospectionExtensions.GetTypeInfo(typeof(AppContext)).Assembly;

           Stream embbededDatabaseStream = assembly.GetManifestResourceStream("MonoTestSolution.Cars.db");
          
            if (!File.Exists(DatabasePath))
            {
                
                FileStream fileStream = File.Create(DatabasePath);
                embbededDatabaseStream.Seek(0, SeekOrigin.Begin);
                embbededDatabaseStream.CopyTo(fileStream);
                fileStream.Close();
            }
            List<VehicleMakeEntity> vehicleMakes = imapper.Map<List<VehicleMakeDto>, List<VehicleMakeEntity>>(irepositoryMockDataApi.GetVehicleMakes());
            List<VehicleModelEntity> vehicleModels = imapper.Map<List<VehicleModelDto>, List<VehicleModelEntity>>(irepositoryMockDataApi.GetVehicleModels());

            _connection.InsertAllAsync(vehicleMakes);
            _connection.InsertAllAsync(vehicleModels);

            

            //Create a Table  For VehicleMakeEntity and VehicleModelEntity
            _connection.CreateTableAsync<VehicleMakeEntity>();
            _connection.CreateTableAsync<VehicleModelEntity>();

          
           


        }

      
        
    }
}
