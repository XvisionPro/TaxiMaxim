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
    public partial class AddDirectory : Form
    {
        DataBase dbCurr;
        List<Order> drivers;
        public AddDirectory(List<Order> request, DataBase db)
        {
            drivers = request;
            dbCurr = db;
            InitializeComponent();
            foreach (var item in drivers)
            {
                comboBoxDrivers.Items.Add(item.Id);
            }
            btnApply.Enabled = false;
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
        private int GetDriverId()
        {
            foreach (var item in drivers)
            {
                if (item.Id.ToString() == comboBoxDrivers.SelectedItem.ToString())
                    return item.Id;
            }
            return 0;
        }

        private void textBoxPhone_TextChanged(object sender, EventArgs e)
        {
            RemoveError(labelErrorPhone);
            if (textBoxPhone.Text.Length == 0)
                AddError(labelErrorPhone, "Поле не может быть пустым");
            if (textBoxPhone.Text.Length != 11)
                AddError(labelErrorPhone, "Поле должно содержать 11 символов");
            long result;
            if (!long.TryParse(textBoxPhone.Text, out result))
            {
                AddError(labelErrorPhone, "Поле должно содержать только числа!");
            }
        }

        private void textBoxAdressStart_TextChanged(object sender, EventArgs e)
        {
            RemoveError(labelErrorAStart);
            if (textBoxAdressStart.Text.Length == 0)
                AddError(labelErrorAStart, "Поле не может быть пустым");
        }

        private void comboBoxDrivers_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnApply.Enabled = true;
        }

        private void btnDiscard_Click(object sender, EventArgs e)
        {
            Close();
            Dispose();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            Directory order = new Directory();
            order.Phone = textBoxPhone.Text;
            order.Adress = textBoxAdressStart.Text;
            if (!checkBoxDriver.Checked)
                order.Order_Id = GetDriverId();
            else
                order.Order_Id = null;
            string orderid = order.Order_Id == null ? "NULL" : order.Order_Id.ToString();
            SqlCommand command = new SqlCommand($"INSERT INTO DIRECTORY VALUES (\'{order.Phone}\', \'{order.Adress}\', {orderid})", dbCurr.getConnection());
            dbCurr.openConnection();
            int count = command.ExecuteNonQuery();
            dbCurr.closeConnection();
            MessageBox.Show("Добавлено успешно!");
            Close();
            Dispose();
        }
    }
}
