using System.Collections.Generic;

namespace TaxiMaxim.BL.Model
{
    public class Driver
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Pass { get; set; }
        public string Phone { get; set; }

        public virtual ICollection<Vehicle> Vehicles { get; set; }
    }
}
