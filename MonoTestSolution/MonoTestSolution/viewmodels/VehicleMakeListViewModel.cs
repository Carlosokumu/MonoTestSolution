using MonoTestSolution.interfaces;
using MonoTestSolution.Service.interfaces;
using MonoTestSolution.Service.models;
using MonoTestSolution.views;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace MonoTestSolution.viewmodels
{
    public class VehicleMakeListViewModel
    {

        private IVehicleMakeService _ivehicleMakeService;
        private IpageService _ipageservice;
        public ICommand LoadDataCommand { get; private set; }
        public ICommand SelectMakeCommand { get; private set; }

        private bool _isDataLoaded;

       
        public ObservableCollection<VehicleMakeViewModel> Makes { get; private set; }
         = new ObservableCollection<VehicleMakeViewModel>();

       
        public VehicleMakeListViewModel(IVehicleMakeService ivehicleMakeService,IpageService ipageService)
        {
            _ivehicleMakeService = ivehicleMakeService;
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

        private async Task SelectMake(VehicleMakeViewModel vehicleMakeViewModel)
        {
            if (vehicleMakeViewModel == null)
                return;
            await _ipageservice.PushAsync(new VehicleMakeDetailsPage(vehicleMakeViewModel));
        }

    }
}
