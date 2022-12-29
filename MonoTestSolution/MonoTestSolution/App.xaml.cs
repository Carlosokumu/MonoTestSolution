using Autofac;
using MonoTestSolution.BootStrap;
using MonoTestSolution.memory;
using MonoTestSolution.Repository;
using MonoTestSolution.Service;
using MonoTestSolution.Service.interfaces;
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
            container.Resolve<IVehicleMakeService>();
            var repositoryDatasource = container.Resolve<RepositoryDataSource>(); ;
            var vehicleMakeService = new VehicleMakeService(DependencyService.Get<ISQLiteDb>().GetConnection(), repositoryDatasource);
            AppSetUp.Init(repositoryDatasource, vehicleMakeService);
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
