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
    public partial class AddOrder : Form
    {
        DataBase dbCurr;
        List<Driver> drivers;
        List<Directory> directory;
        bool isDirectories = false;
        public AddOrder(List<Driver> request, List<Directory> directory, DataBase db)
        {
            dbCurr = db;
            drivers = request;
            this.directory = directory;
            InitializeComponent();
            foreach (var item in drivers)
            {
                comboBoxDrivers.Items.Add(item.Name);
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

        private void textBoxAdressEnd_TextChanged(object sender, EventArgs e)
        {
            RemoveError(labelErrorAEnd);
            if (textBoxAdressEnd.Text.Length == 0)
                AddError(labelErrorAEnd, "Поле не может быть пустым");
        }

        private void textBoxPrice_TextChanged(object sender, EventArgs e)
        {
            RemoveError(labelErrorPrice);
            if (textBoxPrice.Text.Length == 0)
                AddError(labelErrorPrice, "Поле не может быть пустым");
            int result;
            if (!int.TryParse(textBoxPrice.Text, out result))
            {
                AddError(labelErrorPrice, "Поле должно содержать только числа!");
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            RemoveError(labelErrorDate);
            if(dateTimePicker1.Value > DateTime.Today)
            {
                AddError(labelErrorDate, "Выбранная дата не может быть позднее сегодняшней");
            }
        }

        private void checkBoxDriver_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDriver.Checked)
                comboBoxDrivers.Enabled = false;
            else
                comboBoxDrivers.Enabled = true;
        }

        private void btnApply_Click(object sender, EventArgs e)
        {

            Order order = new Order();
            order.PhoneNumber = textBoxPhone.Text;
            order.AdressStart = textBoxAdressStart.Text;
            order.AdressFinish = textBoxAdressEnd.Text;
            order.Date = dateTimePicker1.Value;
            order.PhoneType = isDirectories;
            if (order.PhoneType == false)
                order.Driver_Id = GetDriverId();
            else
                order.Driver_Id = null;
            string driverid = checkBoxDriver.Checked ? "NULL" : order.Driver_Id.ToString();
            order.Price = Convert.ToInt32(textBoxPrice.Text);

            SqlCommand command = new SqlCommand($"INSERT INTO ORDERS VALUES (\'{order.PhoneNumber}\', \'{order.AdressStart}\', \'{order.AdressFinish}\', {order.Price}, \'{order.Date}\', {order.PhoneType.GetHashCode()}, {driverid})", dbCurr.getConnection());
            dbCurr.openConnection();
            int count = command.ExecuteNonQuery();
            dbCurr.closeConnection();
            MessageBox.Show("Добавлено успешно!");
            Close();
            Dispose();
        }

        private void btnDiscard_Click(object sender, EventArgs e)
        {
            Close();
            Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var item in directory)
            {
                if(textBoxPhone.Text == item.Phone)
                {
                    textBoxAdressStart.Text = item.Adress;
                    textBoxAdressStart.Refresh();
                    isDirectories = true;
                    break;
                }
            }
        }

        private int GetDriverId()
        {
            foreach (var item in drivers)
            {
                if (item.Name == comboBoxDrivers.SelectedItem.ToString())
                    return item.Id;
            }
            return 0;
        }
    }
}
