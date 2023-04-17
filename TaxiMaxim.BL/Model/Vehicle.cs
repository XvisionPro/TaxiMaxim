using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiMaxim.BL.Model
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int? DriverID { get; set; }

        public virtual Driver Driver { get; set; } 

    }
}
