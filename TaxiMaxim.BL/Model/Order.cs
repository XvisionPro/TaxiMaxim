using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlTypes;

namespace TaxiMaxim.BL.Model
{
    public class Order
    {
        public int Id { get; set; }
        public string PhoneNumber { get; set; }
        public string AdressStart { get; set; }
        public string AdressFinish { get; set; }
        public decimal Price { get; set; }
        public DateTime Date { get; set; }
        public bool? PhoneType { get; set; }
        public int? Driver_Id { get; set; }

    }
}
