using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace MonoTestSolution.Service.models
{
    public class VehicleMake
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Abbr { get; set; }
    }
}
