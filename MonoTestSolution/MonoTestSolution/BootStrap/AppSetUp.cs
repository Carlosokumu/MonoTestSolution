using MonoTestSolution.Repository.models;
using MonoTestSolution.Repository;
using MonoTestSolution.Service.models;
using MonoTestSolution.Service;
using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;

namespace MonoTestSolution.BootStrap
{
    public  class AppSetUp
    {
        public static IMapper mapper;
        public static void Init(RepositoryDataSource repositorydatasource, VehicleMakeService vehicleMakeService)
        {
            /*
                * AutoMapper Configuration;Maps: Service Layer and Repository Layer Models;             
            */
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<VehicleMakeDto, VehicleMake>();
                cfg.CreateMap<VehicleMake, VehicleMakeDto>();
                cfg.CreateMap<VehicleMakeEntity, VehicleMakeDto>();
                cfg.CreateMap<VehicleMakeDto,VehicleMakeEntity>();
            });
             mapper = config.CreateMapper();
            List<VehicleMake> vehicleMakes = mapper.Map<List<VehicleMakeDto>, List<VehicleMake>>(repositorydatasource.GetVehicleMakes());

            /*
               * 
                  * Insert  some Mock Data  For the [VehicleMake] and [VehicleModel]  to Work With on App StartUp;
               * 
            */

            _ = vehicleMakeService.InsertStartUpData(vehicleMakes);


        }
    }
}
