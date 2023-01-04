using MonoTestSolution.interfaces;
using MonoTestSolution.Service.interfaces;
using MonoTestSolution.views;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace MonoTestSolution.viewmodels
{
    public class VehicleMakeListViewModel
    {

        private IVehicleMakeService _ivehicleMakeService;
        private IpageService _ipageservice;
        public VehicleMakeDetailsViewModel VehicleMakeDetailsViewModel { get; private set; }
        private IvehicleMakeDetailsService _ivehicleMakeDetailsService;
        public ICommand LoadDataCommand { get; private set; }
        public ICommand SelectMakeCommand { get; private set; }

        private bool _isDataLoaded;
  


        public ObservableCollection<VehicleMakeViewModel> Makes { get; private set; }
         = new ObservableCollection<VehicleMakeViewModel>();

       
        public VehicleMakeListViewModel(IVehicleMakeService ivehicleMakeService,IpageService ipageService,IvehicleMakeDetailsService ivehicleMakeDetailsService)
        {
            _ivehicleMakeService = ivehicleMakeService;
            _ivehicleMakeDetailsService = ivehicleMakeDetailsService;
            _ipageservice = ipageService;
            LoadDataCommand = new Command(async () => await LoadData());
            SelectMakeCommand = new Command<VehicleMakeViewModel>(async c => await SelectMake(c));

        }
        private async Task LoadData()
        {

            if (_isDataLoaded)
                return;

            _isDataLoaded = true;

            var vehicleMakes = await _ivehicleMakeService.GetVicleMakesAsync();
            foreach (var vehiclemake in vehicleMakes)
                Makes.Add(new VehicleMakeViewModel(vehiclemake));
        }

        private async Task DeleteVehicleMaKe(VehicleMakeViewModel vehicleMakeViewModel)
        {
            if (await _ipageservice.DisplayAlert("Warning", $"Are you sure you want to delete {vehicleMakeViewModel.Name}?", "Yes", "No"))
            {
                Makes.Remove(vehicleMakeViewModel);

                var vehicleMake = await  _ivehicleMakeService.GetVehicleMake(vehicleMakeViewModel.Id);
                await _ivehicleMakeService.DeleteVehicleMake(vehicleMake);
            }
        }

    


        public  async void SearchMake(string make)
        {
            var vehicleMake = await _ivehicleMakeService.GetVehicleMakeByName(make);
            if (vehicleMake == null)
            {
                var vehicleMakes = await _ivehicleMakeService.GetVicleMakesAsync();
                Makes.Clear();
                foreach (var vehiclemake in vehicleMakes)
                        Makes.Add(new VehicleMakeViewModel(vehiclemake));
                return;
            }
            Makes.Clear();
            Makes.Add(new VehicleMakeViewModel(vehicleMake));
        }

        private async Task SelectMake(VehicleMakeViewModel vehicleMakeViewModel)
        {
            if (vehicleMakeViewModel == null)
                return;
             var vehicleMakeDetails = await _ivehicleMakeDetailsService.GetVehicleMakeDetails(vehicleMakeViewModel.Name);
            Debug.WriteLine($"{vehicleMakeViewModel.Name}");
            if(vehicleMakeDetails == null)
            {
                return;
            }

            VehicleMakeDetailsViewModel = new VehicleMakeDetailsViewModel(vehicleMakeDetails);
            await _ipageservice.PushAsync(new VehicleMakeDetailsPage(vehicleMakeViewModel,VehicleMakeDetailsViewModel));
        }

    }
}
