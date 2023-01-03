using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace MonoTestSolution.Repository.models
{

    [Table(name: "VehicleMakeDetailsEntity")]
    public class VehicleMakeDetailsEntity
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [MaxLength(255)]
        public string Founded { get; set; }
        [MaxLength(255)]
        public string Make { get; set; }

        [MaxLength(255)]
        public string Headquaters { get; set; }
        [MaxLength(255)]
        public string Organization { get; set; }

    }
}
