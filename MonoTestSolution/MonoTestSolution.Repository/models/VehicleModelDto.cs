using System;
using System.Collections.Generic;
using System.Text;

namespace MonoTestSolution.Repository.models
{
    public class VehicleModelDto
    {
        public  Guid  Id { get; set; }
        public string Name { get; set; }
        public string Abbr { get; set; }
        public string Year { get; set; }
    }
}
