﻿using MonoTestSolution.Service.models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MonoTestSolution.viewmodels
{
    public class VehicleModelViewModel: BaseViewModel
    {
        public VehicleModelViewModel(VehicleModel vehicleModel)
        {
            _name = vehicleModel.Name;
            _abbr = vehicleModel.Abbr;
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
