using Autofac;
using AutoMapper;
using MonoTestSolution.memory;
using MonoTestSolution.Repository;
using MonoTestSolution.Repository.interfaces;
using MonoTestSolution.Repository.models;
using MonoTestSolution.Service;
using MonoTestSolution.Service.interfaces;
using MonoTestSolution.Service.models;
using MonoTestSolution.viewmodels;
using SQLite;
using Xamarin.Forms;

namespace MonoTestSolution.BootStrap
{
    /*
        * 
          * This class is responsible for registering all the dependencies;
        * 
     */
    public class AppModule: Module
    {
       
        protected override void Load(ContainerBuilder builder)
        {
        


            builder.Register(
               c => new MapperConfiguration(cfg =>
               {
                  
                   cfg.CreateMap<VehicleMakeDto, VehicleMake>();
                   cfg.CreateMap<VehicleMake, VehicleMakeDto>();
                   cfg.CreateMap<VehicleMakeEntity, VehicleMakeDto>();
                   cfg.CreateMap<VehicleMakeDto, VehicleMakeEntity>();
               }))
               .AsSelf()
               .SingleInstance();


            builder.Register(
             c => c.Resolve<MapperConfiguration>().CreateMapper(c.Resolve))
             .As<IMapper>()
             .InstancePerLifetimeScope();




            builder.RegisterInstance(AppSetUp.GetApplicationRuntimeSettings()).AsImplementedInterfaces().SingleInstance();
            var sqlLiteConnection = AppSetUp.GetApplicationRuntimeSettings().GetConnection();
            builder.RegisterInstance(sqlLiteConnection).AsSelf().SingleInstance();

      


            builder.RegisterType<RepositoryDataSource>().AsSelf().SingleInstance();
            builder.RegisterType<RepositoryMockDataApi>().As<IRepositoryMockDataApi>();


            builder.RegisterType<VehicleMakeCrud>().As<IvehicleMakeCrud>();
            builder.RegisterType<VehicleModelCrud>().As<IvehicleModelCrud>();
            builder.RegisterType<VehicleMakeService>().As<IVehicleMakeService>();
            builder.RegisterType<VehicleModelService>().As<IVehicleModelService>();
            builder.RegisterType<VehicleMakeListViewModel>().AsSelf();
           
            
        }

    }
}
