using Autofac;
using AutoMapper;
using MonoTestSolution.BootStrap;
using MonoTestSolution.memory;
using MonoTestSolution.Repository;
using MonoTestSolution.Repository.interfaces;
using MonoTestSolution.Service;
using MonoTestSolution.Service.interfaces;
using MonoTestSolution.viewmodels;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MonoTestSolution
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            var containerBuilder = new ContainerBuilder();
            containerBuilder.RegisterModule<AppModule>();


            var container = containerBuilder.Build();
            AppContainer.Container = container;

            AppContainer.Container.Resolve<IRepositoryMockDataApi>();
            AppContainer.Container.Resolve<IMapper>();
            
            AppContainer.Container.Resolve<RepositoryDataSource>();
            AppContainer.Container.Resolve<VehicleMakeListViewModel>();

           
            AppContainer.Container.Resolve<IVehicleMakeService>();
            AppContainer.Container.Resolve<IVehicleModelService>();
            AppContainer.Container.Resolve<IvehicleMakeCrud>();
            AppContainer.Container.Resolve<IvehicleModelCrud>();

            MainPage = new VehicleMakesListPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
