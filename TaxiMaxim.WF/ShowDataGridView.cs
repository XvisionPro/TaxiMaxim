using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaxiMaxim.WF
{
    public partial class ShowDataGridView : Form
    {
        public ShowDataGridView(DataTable data)
        {
            InitializeComponent();
            dGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dGV.DataSource = data;

        }

        private void ShowDataGridView_FormClosed(object sender, FormClosedEventArgs e)
        {
            Dispose();
        }
    }
}
