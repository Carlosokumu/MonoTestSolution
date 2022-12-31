using MonoTestSolution.Service.models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MonoTestSolution.viewmodels
{
    public class VehicleMakeViewModel: BaseViewModel
    {
       
        public VehicleMakeViewModel(VehicleMake vehicleMake)
        {
            _name = vehicleMake.Name;
            _abbr = vehicleMake.Abbr;
        }

        private string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                SetValue(ref _name, value);
                OnPropertyChanged(nameof(Name));
            }
        }

        private string _abbr;
        public string Abbr
        {
            get { return _abbr; }
            set
            {
                SetValue(ref _abbr, value);
                OnPropertyChanged(nameof(Abbr));
            }
        }

    }
}
