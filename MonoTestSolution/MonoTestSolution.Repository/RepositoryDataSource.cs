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

        public RepositoryDataSource(SQLiteAsyncConnection connection,IRepositoryMockDataApi irepositoryMockDataApi,Imapper imapper)
        {
            _connection = connection;
            //Create a Table  For VehicleMakeEntity and VehicleModelEntity
            _connection.CreateTableAsync<VehicleMakeEntity>();
            _connection.CreateTableAsync<VehicleModelEntity>();

            List<VehicleMakeEntity> vehicleMakes = imapper.Map<List<VehicleMakeDto>, List<VehicleMakeEntity>>(irepositoryMockDataApi.GetVehicleMakes());
            List<VehicleModelEntity> vehicleModels = imapper.Map<List<VehicleModelDto>, List<VehicleMakeEntity>>(irepositoryMockDataApi.GetVehicleModels());

            _connection.InsertAllAsync(vehicleMakes);
            _connection.InsertAllAsync(vehicleModels);


        }

         /*
            * Provides a mock  List of Vehicle Makes for the UI.
         */
        public List<VehicleMakeDto> GetVehicleMakes()
        {
            var list = new List<VehicleMakeDto>();
            list.Add(new VehicleMakeDto()
            {
                Id = Guid.NewGuid(),
                Name = "Toyota",
                Abbr = "Tyt"

            });
            list.Add(new VehicleMakeDto()
            {
                Id = Guid.NewGuid(),
                Name = "Nissan",
                Abbr = "Nsn"

            });
            list.Add(new VehicleMakeDto()
            {
                Id = Guid.NewGuid(),
                Name = "Bmw",
                Abbr = "Bm"

            });
            list.Add(new VehicleMakeDto()
            {
                Id = Guid.NewGuid(),
                Name = "Mercedes",
                Abbr = "Msd"

            });
            list.Add(new VehicleMakeDto()
            {
                Id = Guid.NewGuid(),
                Name = "Audi",
                Abbr = "Au"

            });
            list.Add(new VehicleMakeDto()
            {
                Id = Guid.NewGuid(),
                Name = "Rolls Royce",
                Abbr = "Rolls"

            });
            list.Add(new VehicleMakeDto()
            {
                Id = Guid.NewGuid(),
                Name = "Subaru",
                Abbr = "Sbr"

            });
            list.Add(new VehicleMakeDto()
            {
                Id = Guid.NewGuid(),
                Name = "Mazda",
                Abbr = "Maz"

            });
            list.Add(new VehicleMakeDto()
            {
                Id = Guid.NewGuid(),
                Name = "Chevrolet",
                Abbr = "Chev"

            });
            list.Add(new VehicleMakeDto()
            {
                Id = Guid.NewGuid(),
                Name = "Bentley",
                Abbr = "Bent"

            });
            list.Add(new VehicleMakeDto()
            {
                Id = Guid.NewGuid(),
                Name = "Jeep",
                Abbr = "Jp"

            });

            return list;
        }



        /*
           * Provides a mock  List of Vehicle Models for the UI.
        */

        public List<VehicleModelDto> GetVehicleModels()
        {
            var list = new List<VehicleModelDto>();
            list.Add(new VehicleModelDto()
            {
                Id = Guid.NewGuid(),
                Name = "Iload",
                Abbr = "Il"

            });
            list.Add(new VehicleModelDto()
            {
                Id = Guid.NewGuid(),
                Name = "Ranger",
                Abbr = "Rng"

            });
            list.Add(new VehicleModelDto()
            {
                Id = Guid.NewGuid(),
                Name = "MiniVan",
                Abbr = "Mini"

            });
            list.Add(new VehicleModelDto()
            {
                Id = Guid.NewGuid(),
                Name = "Sedan",
                Abbr = "Sd"

            });
            return list;
        }
        
    }
}
