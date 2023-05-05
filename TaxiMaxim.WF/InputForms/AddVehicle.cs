using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaxiMaxim.BL.Model;

namespace TaxiMaxim.WF.InputForms
{
    public partial class AddVehicle : Form
    {
        DataBase dbCurr;
        List<Driver> drivers;
        public AddVehicle(List<Driver> request, DataBase db)
        {
            dbCurr = db;
            drivers = request;
            InitializeComponent();
            foreach (var item in drivers)
            {
                comboBoxDrivers.Items.Add(item.Name);
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

        private void textBoxNumber_TextChanged(object sender, EventArgs e)
        {
            RemoveError(labelErrorNumber);
            if(textBoxNumber.Text.Length !=8 
                || !Regex.IsMatch(textBoxNumber.Text[0].ToString(), @"^[а-яА-Я]+$") 
                || !Regex.IsMatch(textBoxNumber.Text.Substring(1,3), @"^[0-9]+$")
                || !Regex.IsMatch(textBoxNumber.Text.Substring(4,2), @"^[а-яА-Я]+$")
                || !Regex.IsMatch(textBoxNumber.Text.Substring(6, 2), @"^[0-9]+$") )
                AddError(labelErrorNumber, "Неверный формат строки (Х777ХХ77)");
        }

        private void textBoxBrand_TextChanged(object sender, EventArgs e)
        {
            RemoveError(labelErrorBrand);
            if (textBoxBrand.Text.Length == 0)
                AddError(labelErrorBrand, "Поле не может быть пустым!");
            if(Regex.IsMatch(textBoxBrand.Text, @"^[0-9]+$"))
                AddError(labelErrorBrand, "Марка машины не может быть числом");
        }

        private void textBoxModel_TextChanged(object sender, EventArgs e)
        {
            RemoveError(labelErrorModel);
            if (textBoxModel.Text.Length == 0)
                AddError(labelErrorModel, "Поле не может быть пустым!");
        }

        private void textBoxColor_TextChanged(object sender, EventArgs e)
        {
            RemoveError(labelErrorColor);
            if (textBoxColor.Text.Length == 0)
                AddError(labelErrorColor, "Поле не может быть пустым!");
            if (Regex.IsMatch(textBoxColor.Text, @"^[0-9]+$"))
                AddError(labelErrorColor, "Марка машины не может быть числом");
        }

        private void btnDiscard_Click(object sender, EventArgs e)
        {
            Close();
            Dispose();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            Vehicle vehicle = new Vehicle();
            vehicle.Number = textBoxNumber.Text;
            vehicle.Brand = textBoxBrand.Text;
            vehicle.Model = textBoxModel.Text;
            vehicle.Color = textBoxColor.Text;
            vehicle.DriverID = GetDriverId();
            if (checkBoxDriver.Checked)
                vehicle.DriverID = null;

            SqlCommand command = new SqlCommand($"INSERT INTO VEHICLE VALUES (\'{vehicle.Number}\', \'{vehicle.Brand}\', \'{vehicle.Model}\', \'{vehicle.Color}\', \'{vehicle.DriverID}\')", dbCurr.getConnection());
            dbCurr.openConnection();
            int count = command.ExecuteNonQuery();
            dbCurr.closeConnection();
            MessageBox.Show("Добавлено успешно!");
            Close();
            Dispose();
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
