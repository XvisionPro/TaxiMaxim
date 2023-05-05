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
    public partial class AddSchedule : Form
    {
        DataBase dbCurr;
        List<Driver> drivers;
        public AddSchedule(List<Driver> request, DataBase db)
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
        private int GetDriverId()
        {
            foreach (var item in drivers)
            {
                if (item.Name == comboBoxDrivers.SelectedItem.ToString())
                    return item.Id;
            }
            return 0;
        }

        private void dateTimePickerStart_ValueChanged(object sender, EventArgs e)
        {
            RemoveError(labelErrorDateStart);
            RemoveError(labelErrorDateEnd);
            if (dateTimePickerStart.Value > dateTimePickerEnd.Value)
                AddError(labelErrorDateStart, "Неверная дата");
        }

        private void dateTimePickerEnd_ValueChanged(object sender, EventArgs e)
        {
            RemoveError(labelErrorDateStart);
            RemoveError(labelErrorDateEnd);
            if (dateTimePickerStart.Value > dateTimePickerEnd.Value)
                AddError(labelErrorDateEnd, "Неверная дата");
        }

        private void comboBoxDrivers_SelectedIndexChanged(object sender, EventArgs e)
        {
            //
        }

        private void btnDiscard_Click(object sender, EventArgs e)
        {
            Close();
            Dispose();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            Schedule schedule = new Schedule();
            schedule.TimeStart = dateTimePickerStart.Value;
            schedule.TimeEnd = dateTimePickerEnd.Value;
            schedule.Driver_Id = GetDriverId();

            SqlCommand command = new SqlCommand($"INSERT INTO SCHEDULE VALUES (\'{schedule.TimeStart}\', \'{schedule.TimeEnd}\', 0, \'{schedule.Driver_Id}\')", dbCurr.getConnection());
            dbCurr.openConnection();
            int count = command.ExecuteNonQuery();
            dbCurr.closeConnection();
            MessageBox.Show("Добавлено успешно!");
            Close();
            Dispose();
        }
    }
}
