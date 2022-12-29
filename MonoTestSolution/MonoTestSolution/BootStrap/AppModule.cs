using Autofac;
using MonoTestSolution.memory;
using MonoTestSolution.Repository;
using MonoTestSolution.Service;
using MonoTestSolution.Service.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MonoTestSolution.BootStrap
{
     public class AppModule: Module
    {

        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<RepositoryDataSource>().AsSelf();
            builder.RegisterType<VehicleMakeService>().As<IVehicleMakeService>();
            builder.RegisterType<VehicleModelService>().As<IVehicleModelService>();
        }

    }
}
