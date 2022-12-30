using Autofac;
using MonoTestSolution.BootStrap;
using MonoTestSolution.memory;
using MonoTestSolution.Service.interfaces;
using MonoTestSolution.viewmodels;
using Xamarin.Forms;

namespace MonoTestSolution
{
    public partial class VehicleMakesListPage : ContentPage
    {
        public VehicleMakesListPage()
        {

            InitializeComponent();

            //var repositoryDatasource = new RepositoryDataSource();
           // var connection = DependencyService.Get<ISQLiteDb>().GetConnection();

            var vehicleMakeService = AppContainer.Container.Resolve<IVehicleMakeService>();

            //var vehicleMakeService = new VehicleMakeService(connection, repositoryDatasource);
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
