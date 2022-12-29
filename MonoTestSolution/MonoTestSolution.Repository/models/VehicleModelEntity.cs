using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace MonoTestSolution.Repository.models
{
    public class VehicleModelEntity
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [MaxLength(255)]
        public string Name { get; set; }
        [MaxLength(255)]
        public string Abbr { get; set; }
    }
}

