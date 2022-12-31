using MonoTestSolution.interfaces;
using MonoTestSolution.Service;
using MonoTestSolution.Service.interfaces;
using MonoTestSolution.Service.models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace MonoTestSolution.viewmodels
{

    
    public class VehicleMakeViewModelPage
    {
        public VehicleMake Make { get; private set; }
        private IVehicleModelService _ivehicleModelService;
        private bool _isDataLoaded;
        public ObservableCollection<VehicleModelViewModel> Models { get; private set; }
        = new ObservableCollection<VehicleModelViewModel>();

        public ICommand LoadDataCommand { get; private set; }

        public VehicleMakeViewModelPage(VehicleMakeViewModel viewModel,IVehicleModelService  vehicleModelService)
        {
            _ivehicleModelService = vehicleModelService;
            LoadDataCommand = new Command(async () => await LoadData());
            if (viewModel == null)
                throw new ArgumentNullException(nameof(viewModel));

            Make = new VehicleMake()
            {
                Name = viewModel.Name,
                Abbr = viewModel.Abbr,
            };
        }

        private async Task LoadData()
        {

            if (_isDataLoaded)
                return;
            _isDataLoaded = true;

            var vehicleModels = await _ivehicleModelService.GetVicleModelsAsync();
            foreach (var vehiclemodel in vehicleModels)
                Models.Add(new VehicleModelViewModel(vehiclemodel));
        }

    }
}
