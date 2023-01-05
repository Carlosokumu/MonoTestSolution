using MonoTestSolution.interfaces;
using MonoTestSolution.Service.interfaces;
using MonoTestSolution.views;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Extended;

namespace MonoTestSolution.viewmodels
{
    public class VehicleMakeListViewModel: BindableObject
    {

        private IVehicleMakeService _ivehicleMakeService;
        private IpageService _ipageservice;
        public VehicleMakeDetailsViewModel VehicleMakeDetailsViewModel { get; private set; }
        private IvehicleMakeDetailsService _ivehicleMakeDetailsService;
        public ICommand LoadDataCommand { get; private set; }
        public ICommand SelectMakeCommand { get; private set; }

        private bool _isDataLoaded;
        private const int PageSize = 20;
        private const int INITIAL_PAGE_INDEX = 0;

        public static readonly BindableProperty IsWorkingProperty =
            BindableProperty.Create(nameof(IsWorking), typeof(bool), typeof(VehicleMakeListViewModel), default(bool));



        public ObservableCollection<VehicleMakeViewModel> Makes { get; private set; }
         = new ObservableCollection<VehicleMakeViewModel>();

       
        public VehicleMakeListViewModel(IVehicleMakeService ivehicleMakeService,IpageService ipageService,IvehicleMakeDetailsService ivehicleMakeDetailsService)
        {
            _ivehicleMakeService = ivehicleMakeService;
            _ivehicleMakeDetailsService = ivehicleMakeDetailsService;
            _ipageservice = ipageService;
            LoadDataCommand = new Command(async () => await LoadData());
            SelectMakeCommand = new Command<VehicleMakeViewModel>(async c => await SelectMake(c));


            PaginatedMakes = new InfiniteScrollCollection<VehicleMakeViewModel>
            {
                OnLoadMore = async () =>
                { 
                
                    // load the next page
                    var page = PaginatedMakes.Count / PageSize;
                    Debug.WriteLine($" OnloadMore Called with Page:{page}");
                    var items = await _ivehicleMakeService.GetPaginatedVehicleMakesAsync(page + 1);
                    var paginatedMakes = new List<VehicleMakeViewModel>();

                    foreach (var vehiclemake in items)
                        paginatedMakes.Add(new VehicleMakeViewModel(vehiclemake));

                    // return the items that need to be added
                    return  paginatedMakes; 
                }
            };
          

        }
        private async Task LoadData()
        {

            if (_isDataLoaded)
                return;

            _isDataLoaded = true;

            //Fetch Data without Paging
           // var vehicleMakes = await _ivehicleMakeService.GetVehicleMakesAsync();

            //Load Initial Data
            var paginatedMakes = await _ivehicleMakeService.GetPaginatedVehicleMakesAsync(INITIAL_PAGE_INDEX);


            foreach (var vehiclemake in paginatedMakes)
                PaginatedMakes.Add(new VehicleMakeViewModel(vehiclemake));

            //foreach (var vehiclemake in vehicleMakes)
            //     Makes.Add(new VehicleMakeViewModel(vehiclemake));
               
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


        public InfiniteScrollCollection<VehicleMakeViewModel> PaginatedMakes { get; }


        public  async void SearchMake(string make)
        {
            var vehicleMake = await _ivehicleMakeService.GetVehicleMakeByName(make);
            if (vehicleMake == null)
            {
                var vehicleMakes = await _ivehicleMakeService.GetVehicleMakesAsync();
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

        public bool IsWorking
        {
            get { return (bool) GetValue(IsWorkingProperty); }
            set { SetValue(IsWorkingProperty, value); }
        }

    }
}
