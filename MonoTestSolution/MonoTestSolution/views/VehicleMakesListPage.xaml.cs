using Autofac;
using MonoTestSolution.BootStrap;
using MonoTestSolution.interfaces;
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
            var vehicleMakeService = AppContainer.Container.Resolve<IVehicleMakeService>();
            var pageService = AppContainer.Container.Resolve<IpageService>();
            ViewModel = new VehicleMakeListViewModel(vehicleMakeService,pageService);
            ViewModel.LoadDataCommand.Execute(null);
        }


        public VehicleMakeListViewModel ViewModel
        {
            get { return BindingContext as VehicleMakeListViewModel; }
            set { BindingContext = value; }
        }

        void OnMakeSelected(object sender, SelectedItemChangedEventArgs e)
        {
            ViewModel.SelectMakeCommand.Execute(e.SelectedItem);
        }
    }
}
