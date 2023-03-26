using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaxiMaxim.BL.Model;
using System.Data.SqlClient;

namespace TaxiMaxim.WF
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            try
            {
                DataBase db = new DataBase();
                db.openConnection();
                MessageBox.Show("DB CONNECT");
                SqlDataAdapter adapter = new SqlDataAdapter();
                SqlCommand command = new SqlCommand("SELECT * FROM ORDERS", db.getConnection());
                DataTable table = new DataTable();

                adapter.SelectCommand = command;
                adapter.Fill(table);
                db.closeConnection();

                //DataGridView dgv = new DataGridView();
                //dgv.Height = 200;
                //dgv.Width = 800;
                //this.Controls.Add(dgv);

                dataGridView1.DataSource = table;

            }
            catch (Exception)
            {
                MessageBox.Show("DB NOT CONNECT");
                throw;
            }
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
