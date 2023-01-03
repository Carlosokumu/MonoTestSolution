using Autofac;
using MonoTestSolution.BootStrap;
using MonoTestSolution.Service.interfaces;
using MonoTestSolution.viewmodels;
using System.Diagnostics;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MonoTestSolution.views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VehicleMakeDetailsPage : ContentPage
    {
        public VehicleMakeDetailsPage(VehicleMakeViewModel vehicleMakeViewModel,VehicleMakeDetailsViewModel vehicleMakeDetailsViewModel)
        {
            var vehicleModelService = AppContainer.Container.Resolve<IVehicleModelService>();
            var ivehicleMakeDetailsService = AppContainer.Container.Resolve<IvehicleMakeDetailsService>();
            Debug.WriteLine("Making Details Page");
            BindingContext = new  VehicleMakeViewModelPage(vehicleMakeViewModel,vehicleModelService,ivehicleMakeDetailsService,vehicleMakeDetailsViewModel);
            //ViewModel.LoadDataCommand.Execute(null);
            //ViewModel.LoadDataComman.Execute(null);
            InitializeComponent();
        }

        public VehicleMakeViewModelPage ViewModel
        {
            get { return BindingContext as VehicleMakeViewModelPage; }
            set { BindingContext = value; }
        }
    }
}