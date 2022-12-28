using MonoTestSolution.Repository.models;
using System;
using System.Collections.Generic;

namespace MonoTestSolution.Repository
{
    public class RepositoryDataSource
    {

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
