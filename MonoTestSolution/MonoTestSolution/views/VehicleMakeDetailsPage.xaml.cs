using Autofac;
using MonoTestSolution.BootStrap;
using MonoTestSolution.interfaces;
using MonoTestSolution.Service.interfaces;
using MonoTestSolution.viewmodels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MonoTestSolution.views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VehicleMakeDetailsPage : ContentPage
    {
        public VehicleMakeDetailsPage(VehicleMakeViewModel vehicleMakeViewModel)
        {
            var vehicleModelService = AppContainer.Container.Resolve<IVehicleModelService>();
            BindingContext = new  VehicleMakeViewModelPage(vehicleMakeViewModel,vehicleModelService);
            ViewModel.LoadDataCommand.Execute(null);
            InitializeComponent();
        }

        public VehicleMakeViewModelPage ViewModel
        {
            get { return BindingContext as VehicleMakeViewModelPage; }
            set { BindingContext = value; }
        }
    }
}