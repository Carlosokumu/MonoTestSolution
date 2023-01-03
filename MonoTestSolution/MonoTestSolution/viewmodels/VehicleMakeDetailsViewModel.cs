using MonoTestSolution.Service.models;

namespace MonoTestSolution.viewmodels
{
    public class VehicleMakeDetailsViewModel: BaseViewModel
    {
        
        public VehicleMakeDetailsViewModel(VehicleMakeDetails vehicleMakeDetails)
        {
            _founded = vehicleMakeDetails.Founded;
            _parentorganization = vehicleMakeDetails.Organization;
            _make = vehicleMakeDetails.Make;
            _headquaters = vehicleMakeDetails.Headquaters;
        }

        private string _founded;
        public string Founded
        {
            get { return _founded; }
            set
            {
                SetValue(ref _founded, value);
                OnPropertyChanged(nameof(Founded));
            }
        }
        private string _parentorganization;
        public string Organization
        {
            get { return _parentorganization; }
            set
            {
                SetValue(ref _parentorganization, value);
                OnPropertyChanged(nameof(Organization));
            }
        }



        private string _headquaters;
        public string Headquaters
        {
            get { return _headquaters; }
            set
            {
                SetValue(ref _headquaters, value);
                OnPropertyChanged(nameof(Headquaters));
            }
        }

        private string _make;
        public string Make
        {
            get { return _make; }
            set
            {
                SetValue(ref _make, value);
                OnPropertyChanged(nameof(Make));
            }
        }
    }
}
