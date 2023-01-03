using MonoTestSolution.Service.interfaces;
using MonoTestSolution.Service.models;
using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MonoTestSolution.viewmodels
{


    public class VehicleMakeViewModelPage
    {
        public VehicleMake Make { get; private set; }
        private IVehicleModelService _ivehicleModelService;
        private IvehicleMakeDetailsService _ivehicleMakeDetailsService;
        private bool _isDataLoaded;
        public ObservableCollection<VehicleModelViewModel> Models { get; private set; }
        = new ObservableCollection<VehicleModelViewModel>();
        public VehicleMakeDetailsViewModel vehiclemakeViewModel { get; private set; }
        public VehicleMakeDetails VehicleMakeDetails { get; private set; }

        public ICommand LoadDataCommand { get; private set; }
        public ICommand LoadDataComman { get; private set; }

        public VehicleMakeViewModelPage(VehicleMakeViewModel viewModel,IVehicleModelService  vehicleModelService,IvehicleMakeDetailsService ivehicleMakeDetailsService,VehicleMakeDetailsViewModel vehicleMakeDetailsViewModel)
        {
            _ivehicleModelService = vehicleModelService;
            _ivehicleMakeDetailsService = ivehicleMakeDetailsService;

            if (viewModel == null)
                throw new ArgumentNullException(nameof(viewModel));

            

            Make = new VehicleMake()
            {
                Name = viewModel.Name,
                Abbr = viewModel.Abbr,
            };
            VehicleMakeDetails = new VehicleMakeDetails()
            {
                Headquaters = vehicleMakeDetailsViewModel.Headquaters,
                Founded = vehicleMakeDetailsViewModel.Founded,
                Make = vehicleMakeDetailsViewModel.Make,
                Organization = vehicleMakeDetailsViewModel.Organization
            };
           
        }


        private async Task LoadData(string make)
        {

            if (_isDataLoaded)
                return;
            _isDataLoaded = true;

            var vehicleModels = await _ivehicleModelService.GetVicleModelsAsync();
            foreach (var vehiclemodel in vehicleModels)
                Models.Add(new VehicleModelViewModel(vehiclemodel));
        }

        private async Task LoadMakeInfo(string make)
        {
            var vehicleMakeDetails = await _ivehicleMakeDetailsService.GetVehicleMakeDetails(make);
            vehiclemakeViewModel = new VehicleMakeDetailsViewModel(vehicleMakeDetails);
        }

        private  async void LoadModels(string make)
        {
            if (_isDataLoaded)
                return;
            _isDataLoaded = true;
            var vehicleMakeModels = await _ivehicleMakeDetailsService.GetVehicleMakeModels(make);
            foreach (var vehiclemodel in vehicleMakeModels)
                Models.Add(new VehicleModelViewModel(vehiclemodel));
                
        }

    }
}
