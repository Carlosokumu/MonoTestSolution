using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace MonoTestSolution.Repository.models
{
    [Table(name: "VehicleMakeEntity")]      
    public class VehicleMakeEntity
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [MaxLength(255)]
        public string Name { get; set; }
        [MaxLength(255)]
        public string Abbr { get; set; }

        public int Page { get; set; }
    }
}

