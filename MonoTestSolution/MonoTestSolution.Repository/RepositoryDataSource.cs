using MonoTestSolution.Repository.models;
using System.Collections.Generic;

namespace MonoTestSolution.Repository
{
    public class RepositoryDataSource
    {

         /*
            * Provides a mock  List of Vehicle Makes
         */
        public List<VehicleMakeDto> GetVehicleMake()
        {
            var list = new List<VehicleMakeDto>();
            list.Add(new VehicleMakeDto()
            {
                Id = 1,
                Name = "Toyota",
                Abbr = "Tyt"

            });
            list.Add(new VehicleMakeDto()
            {
                Id = 1,
                Name = "Nissan",
                Abbr = "Nsn"

            });
            list.Add(new VehicleMakeDto()
            {
                Id = 1,
                Name = "Bmw",
                Abbr = "Bm"

            });
            list.Add(new VehicleMakeDto()
            {
                Id = 1,
                Name = "Mercedes",
                Abbr = "Msd"

            });
            list.Add(new VehicleMakeDto()
            {
                Id = 1,
                Name = "Audi",
                Abbr = "Au"

            });
            list.Add(new VehicleMakeDto()
            {
                Id = 1,
                Name = "Rolls Royce",
                Abbr = "Rolls"

            });
            list.Add(new VehicleMakeDto()
            {
                Id = 1,
                Name = "Subaru",
                Abbr = "Sbr"

            });
            list.Add(new VehicleMakeDto()
            {
                Id = 1,
                Name = "Mazda",
                Abbr = "Maz"

            });
            list.Add(new VehicleMakeDto()
            {
                Id = 1,
                Name = "Chevrolet",
                Abbr = "Chev"

            });
            list.Add(new VehicleMakeDto()
            {
                Id = 1,
                Name = "Bentley",
                Abbr = "Rolls"

            });
            list.Add(new VehicleMakeDto()
            {
                Id = 1,
                Name = "Jeep",
                Abbr = "Jp"

            });

            return list;
        }
    }
}
