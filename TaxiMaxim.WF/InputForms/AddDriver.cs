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
    public partial class AddDriver : Form
    {
        DataBase dbCurr;
        public AddDriver(DataBase db)
        {
            dbCurr = db;
            InitializeComponent();
        }

        private void labelPass_Click(object sender, EventArgs e)
        {

        }

        private void labelPhone_Click(object sender, EventArgs e)
        {

        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            RemoveError(labelErrorName);
            if(textBoxName.Text.Length == 0)
                AddError(labelErrorName, "Имя не может быть пустым");
            if (textBoxName.Text.Length <= 4)
                AddError(labelErrorName, "Имя не может быть меньше 4 символов");
        }
        private void textBoxPass_TextChanged(object sender, EventArgs e)
        {
            RemoveError(labelErrorPass);
            if (textBoxPass.Text.Length == 0)
                AddError(labelErrorPass, "Поле не может быть пустым");
            if (textBoxPass.Text.Length != 10)
                AddError(labelErrorPass, "Поле должно содержать 10 символов");
            long result;
            if(!long.TryParse(textBoxPass.Text, out result)){
                AddError(labelErrorPass, "Поле должно содержать только числа!");
            }
        }

        private void textBoxPhone_TextChanged(object sender, EventArgs e)
        {
            RemoveError(labelErrorPhone);
            RemoveError(labelErrorPhone);
            if (textBoxPhone.Text.Length == 0)
                AddError(labelErrorPhone, "Поле не может быть пустым");
            if (textBoxPhone.Text.Length != 11)
                AddError(labelErrorPhone, "Поле должно содержать 10 символов");
            long result;
            if (!long.TryParse(textBoxPhone.Text, out result))
            {
                AddError(labelErrorPhone, "Поле должно содержать только числа!");
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

        private void btnApply_Click(object sender, EventArgs e)
        {
            Driver driver = new Driver();
            driver.Name = textBoxName.Text;
            driver.Pass = textBoxPass.Text;
            driver.Phone = textBoxPhone.Text;
            SqlCommand command = new SqlCommand($"INSERT INTO DRIVER VALUES (\'{driver.Name}\', \'{driver.Pass}\', \'{driver.Phone}\')", dbCurr.getConnection());
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

        private void AddDriver_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
