using MonoTestSolution.Repository.interfaces;
using MonoTestSolution.Repository.models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MonoTestSolution.Repository
{

    public class RepositoryMockDataApi : IRepositoryMockDataApi
    {
        /*
           * Provides a mock  List of Vehicle Makes for the UI.
        */
        public List<VehicleMakeDto> GetVehicleMakes()
        {
            var vehiclemakes = new List<VehicleMakeDto>();
            vehiclemakes.Add(new VehicleMakeDto()
            {
                Id = Guid.NewGuid(),
                Name = "Toyota",
                Abbr = "Tyt"

            });
            vehiclemakes.Add(new VehicleMakeDto()
            {
                Id = Guid.NewGuid(),
                Name = "Nissan",
                Abbr = "Nsn"

            });
            vehiclemakes.Add(new VehicleMakeDto()
            {
                Id = Guid.NewGuid(),
                Name = "Bmw",
                Abbr = "Bm"

            });
            vehiclemakes.Add(new VehicleMakeDto()
            {
                Id = Guid.NewGuid(),
                Name = "Mercedes",
                Abbr = "Msd"

            });
            vehiclemakes.Add(new VehicleMakeDto()
            {
                Id = Guid.NewGuid(),
                Name = "Audi",
                Abbr = "Au"

            });
            vehiclemakes.Add(new VehicleMakeDto()
            {
                Id = Guid.NewGuid(),
                Name = "Rolls Royce",
                Abbr = "Rolls"

            });
            vehiclemakes.Add(new VehicleMakeDto()
            {
                Id = Guid.NewGuid(),
                Name = "Subaru",
                Abbr = "Sbr"

            });
            vehiclemakes.Add(new VehicleMakeDto()
            {
                Id = Guid.NewGuid(),
                Name = "Mazda",
                Abbr = "Maz"

            });
            vehiclemakes.Add(new VehicleMakeDto()
            {
                Id = Guid.NewGuid(),
                Name = "Chevrolet",
                Abbr = "Chev"

            });
            vehiclemakes.Add(new VehicleMakeDto()
            {
                Id = Guid.NewGuid(),
                Name = "Bentley",
                Abbr = "Bent"

            });
            vehiclemakes.Add(new VehicleMakeDto()
            {
                Id = Guid.NewGuid(),
                Name = "Jeep",
                Abbr = "Jp"

            });

            return vehiclemakes;
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

