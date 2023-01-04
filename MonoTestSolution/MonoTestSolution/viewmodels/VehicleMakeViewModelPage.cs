using MonoTestSolution.Service.interfaces;
using MonoTestSolution.Service.models;
using System;
using System.Collections.ObjectModel;

namespace MonoTestSolution.viewmodels
{


    public class VehicleMakeViewModelPage
    {
        public VehicleMake Make { get; private set; }
        private IvehicleMakeDetailsService _ivehicleMakeDetailsService;
        private bool _isDataLoaded;
        public VisualBoolean visualBoolean { get; private set; }
       


        public ObservableCollection<VehicleModelViewModel> Models { get; private set; }
        = new ObservableCollection<VehicleModelViewModel>();
        public VehicleMakeDetails VehicleMakeDetails { get; private set; }

       

        public VehicleMakeViewModelPage(VehicleMakeViewModel viewModel,IVehicleModelService  vehicleModelService,IvehicleMakeDetailsService ivehicleMakeDetailsService,VehicleMakeDetailsViewModel vehicleMakeDetailsViewModel)
        {
            _ivehicleMakeDetailsService = ivehicleMakeDetailsService;

            if (viewModel == null)
                throw new ArgumentNullException(nameof(viewModel));
            visualBoolean = new VisualBoolean();
            
            visualBoolean.IsLoading= true;

            //Loads Models for a particular car Make
            LoadModels(viewModel.Name);

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



      
        //Loads Models For a particular Vehicle Make From the Api

        private  async void LoadModels(string make)
        {
            if (_isDataLoaded)
                return;
            _isDataLoaded = true;
            var vehicleMakeModels = await _ivehicleMakeDetailsService.GetVehicleMakeModels(make);
            visualBoolean.IsLoading = false;
            if (vehicleMakeModels == null)
                return;
            foreach (var vehiclemodel in vehicleMakeModels)
                if (Models.Contains(new VehicleModelViewModel(vehiclemodel)))
                    return;
                else
                Models.Add(new VehicleModelViewModel(vehiclemodel));
            
        }

    }
}
