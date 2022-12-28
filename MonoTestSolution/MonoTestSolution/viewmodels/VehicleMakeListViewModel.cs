using MonoTestSolution.Service;
using MonoTestSolution.Service.models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace MonoTestSolution.viewmodels
{
    public class VehicleMakeListViewModel: BaseViewModel
    {

        private VehicleMakeService _ivehicleMakeService;
        public ICommand LoadDataCommand { get; private set; }

        private ObservableCollection<VehicleMake> _vehiclemakes = new ObservableCollection<VehicleMake>();
        public ObservableCollection<VehicleMake> VehicleMakes
        {
            get { return _vehiclemakes; }
            set
            {

                _vehiclemakes = value;
                OnPropertyChanged("VehicleMakes");
            }
        }
        public VehicleMakeListViewModel(VehicleMakeService ivehicleMakeService)
        {
            _ivehicleMakeService = ivehicleMakeService;
            LoadDataCommand = new Command(async () => await LoadData());

        }
        private async Task LoadData()
        {

            var vehicleMakes = await _ivehicleMakeService.GetVicleMakesAsync();
            foreach (var vehiclemake in vehicleMakes)
                _vehiclemakes.Add(vehiclemake);
        }

        private string name;

        public string Name { get => name; set => SetValue(ref name, value); }
    }
}
