using MonoTestSolution.memory;
using MonoTestSolution.Repository;
using MonoTestSolution.Service;
using MonoTestSolution.viewmodels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MonoTestSolution
{
    public partial class VehicleMakesListPage : ContentPage
    {
        public VehicleMakesListPage()
        {

            InitializeComponent();

            var repositoryDatasource = new RepositoryDataSource();
            var connection = DependencyService.Get<ISQLiteDb>().GetConnection();

            var vehicleMakeService = new VehicleMakeService(connection, repositoryDatasource);
            ViewModel = new VehicleMakeListViewModel(vehicleMakeService);
            ViewModel.LoadDataCommand.Execute(null);
        }


        public VehicleMakeListViewModel ViewModel
        {
            get { return BindingContext as VehicleMakeListViewModel; }
            set { BindingContext = value; }
        }
    }
}
