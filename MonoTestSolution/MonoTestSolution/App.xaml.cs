using Autofac;
using AutoMapper;
using MonoTestSolution.BootStrap;
using MonoTestSolution.interfaces;
using MonoTestSolution.memory;
using MonoTestSolution.Repository;
using MonoTestSolution.Repository.interfaces;
using MonoTestSolution.Service;
using MonoTestSolution.Service.interfaces;
using MonoTestSolution.viewmodels;
using SQLite;
using System;
using System.Diagnostics;
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
            AppContainer.Container.Resolve<SQLiteAsyncConnection>();
            
            AppContainer.Container.Resolve<RepositoryDataSource>();
            AppContainer.Container.Resolve<VehicleMakeListViewModel>();

           
            AppContainer.Container.Resolve<IVehicleMakeService>();
            AppContainer.Container.Resolve<IVehicleModelService>();
            AppContainer.Container.Resolve<IvehicleMakeCrud>();
            AppContainer.Container.Resolve<IvehicleModelCrud>();
            AppContainer.Container.Resolve<IpageService>();

            MainPage = new NavigationPage(new VehicleMakesListPage());
            NavigationPage.SetHasNavigationBar(this, false);
            
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
