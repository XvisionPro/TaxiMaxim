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
    public partial class Find : Form
    {
        DataBase dbCurr;
        string table;
        public Find(string[] data,DataBase db, string table)
        {
            this.table = table;
            dbCurr = db;
            InitializeComponent();
            foreach (var item in data)
            {
                comboBoxWhere.Items.Add(item);
            }
        }
        private void RemoveError(Label label)
        {
            label.Visible = false;
            label.Text = "NONE";
            btnApply.Enabled = true;
        }

        private void AddError(Label label, string text)
        {
            label.Text = text;
            label.Visible = true;
            btnApply.Enabled = false;
        }
        private void textBoxFind_TextChanged(object sender, EventArgs e)
        {
            RemoveError(labelErrorFind);
            if (textBoxFind.Text.Length == 0)
                AddError(labelErrorFind, "Поле не может быть пустым");
        }

        private void Find_Load(object sender, EventArgs e)
        {
            btnApply.Enabled = false;
        }

        private void comboBoxWhere_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnDiscard_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            dbCurr.openConnection();
            SqlDataAdapter sda = new SqlDataAdapter($"SELECT * FROM {this.table} WHERE {comboBoxWhere.SelectedItem}=\'{textBoxFind.Text}\'", dbCurr.getConnection());
            DataTable dt = new DataTable();
            try
            {
                sda.Fill(dt);
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка!");
            }
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
    }
}
