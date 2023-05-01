using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaxiMaxim.BL.Model;

namespace TaxiMaxim.WF.InputForms
{
    public partial class DeleteOne: Form
    {
        public DeleteOne(object obj, DataBase db)
        {
            IList objList = (IList)obj;
            int count = objList.Count; // The LINQ conversions will lose this information
            IEnumerable<Driver> list = objList.Cast<Driver>();
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
