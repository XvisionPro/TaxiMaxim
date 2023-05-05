using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiMaxim.BL.Model
{
    public class Directory
    {
        public int Id { get; set; }
        public string Phone { get; set; }
        public string Adress { get; set; }
        public int? Order_Id { get; set; }

    }
}
