using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaxiMaxim.BL.Model;

namespace TaxiMaxim.WF.InputForms
{
    public partial class Sorting : Form
    {
        DataBase dbCurr;
        string[] data;
        string table;
        public Sorting(DataBase db, string[] data, string table)
        {
            dbCurr = db;
            this.data = data;
            this.table = table;
            InitializeComponent();
            btnApply.Enabled = false;
            comboBoxHow.SelectedIndex = 0;
            foreach (var item in data)
            {
                comboBoxColumn.Items.Add(item);
            }
        }

        private void comboBoxColumn_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnApply.Enabled = true;
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            string type;
            if (comboBoxHow.SelectedIndex == 0)
                type = "ASC";
            else
                type = "DESC";
            dbCurr.openConnection();
            SqlDataAdapter sda = new SqlDataAdapter($"SELECT * FROM {this.table} ORDER BY {comboBoxColumn.SelectedItem} {type}", dbCurr.getConnection());
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dbCurr.closeConnection();

            bool create = false;

            foreach (Form form in Application.OpenForms)
            {
                if (form.Name.ToString() == "ShowDataGridView")
                {
                    //this.Hide();
                    form.Visible = true;
                    create = true;
                    break;
                }
            }
            if (create == false)
            {
                ShowDataGridView createC = new ShowDataGridView(dt);
                //this.Hide();
                createC.Show();

            }
        }

        private void btnDiscard_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
