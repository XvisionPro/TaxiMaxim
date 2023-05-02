using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiMaxim.BL.Model
{
    public class Schedule
    {
        public int Id { get; set; }
        public DateTime TimeStart { get; set; }
        public DateTime TimeEnd { get; set; }
        public bool isWorking { get; set; }
        public int Driver_Id { get; set; }
    }
}
