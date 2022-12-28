using MonoTestSolution.BootStrap;
using MonoTestSolution.memory;
using MonoTestSolution.Repository;
using MonoTestSolution.Service;
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
            var repositoryDatasource = new RepositoryDataSource();
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
