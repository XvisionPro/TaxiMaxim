using System;
using System.Collections;
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
    public partial class DeleteOne: Form
    {
        DataBase dbCurr;
        string queryname, querycolumn;
        public DeleteOne(int[] data, DataBase db, string database, string column)
        {
            dbCurr = db;
            queryname = database;
            querycolumn = column;
            InitializeComponent();
            foreach (var item in data)
            {
                comboBox1.Items.Add(item);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnApply.Enabled = true;
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand($"DELETE FROM {queryname} WHERE {querycolumn} = {comboBox1.SelectedItem}", dbCurr.getConnection());
            dbCurr.openConnection();
            int count = command.ExecuteNonQuery();
            dbCurr.closeConnection();
            MessageBox.Show($"Строка с ID: {comboBox1.SelectedItem} успешно удалена!");
            Close();
        }

        private void btnDiscard_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DeleteOne_Load(object sender, EventArgs e)
        {
            btnApply.Enabled = false;
        }
    }
}
