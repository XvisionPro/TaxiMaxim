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
        DataBase db = new DataBase();
        SqlDataAdapter sda;
        SqlCommandBuilder scb;
        DataTable dt;
        public MainMenu()
        {
            InitializeComponent();
            sda = new SqlDataAdapter("SELECT ORDER_ID, ORDER_PHONE_NUMBER, ORDER_ADRESS_START, ORDER_ADRESS_FINISH, ORDER_PRICE, ORDER_DATE, ORDER_PHONE_TYPE, DRIVER_ID FROM ORDERS", db.getConnection());
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            try
            {
                db.openConnection();
                //MessageBox.Show("DataBase is  CONNECT");

                dataBaseCheck_SLabel.Text = "Подключено";
                dataBaseCheck_SLabel.ForeColor = Color.FromArgb(0, 181, 36);
                SqlDataAdapter adapter = new SqlDataAdapter();
                SqlCommand command = new SqlCommand("SELECT ORDER_PHONE_NUMBER, ORDER_ADRESS_START, ORDER_ADRESS_FINISH, ORDER_PRICE, ORDER_DATE, ORDER_PHONE_TYPE, DRIVER_ID FROM ORDERS", db.getConnection());
                DataTable table = new DataTable();

                adapter.SelectCommand = command;
                adapter.Fill(table);
                string StrQuery;
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    StrQuery = @"INSERT INTO ORDERS (ORDER_PHONE_NUMBER, ORDER_ADRESS_START, ORDER_ADRESS_FINISH, ORDER_PRICE, ORDER_DATE, ORDER_PHONE_TYPE, DRIVER_ID) VALUES (" + dataGridView1.Rows[i].Cells["ORDER_PHONE_NUMBER"].Value + ", " + dataGridView1.Rows[i].Cells["ORDER_ADRESS_START"].Value + ", " + dataGridView1.Rows[i].Cells["ORDER_ADRESS_FINISH"].Value + ", " + dataGridView1.Rows[i].Cells["ORDER_PRICE"].Value + ", " + dataGridView1.Rows[i].Cells["ORDER_PRICE"].Value + ", " + dataGridView1.Rows[i].Cells["DRIVER_ID"].Value + ");";
                    //comand.CommandText = StrQuery;
                    //comand.ExecuteNonQuery();
                }
                db.closeConnection();

                //DataGridView dgv = new DataGridView();
                //dgv.Height = 200;
                //dgv.Width = 800;
                //this.Controls.Add(dgv);

                dataGridView1.DataSource = table;
            }
            catch (Exception)
            {
                dataBaseCheck_SLabel.Text = "Не подключено";
                dataBaseCheck_SLabel.ForeColor = Color.FromArgb(204, 0, 0);
                MessageBox.Show("DB NOT CONNECT");
                throw;
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           // MessageBox.Show("Activate");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            scb = new SqlCommandBuilder(sda);
            sda.Update(dt);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OrderMenu form2 = new OrderMenu();
            form2.Show();
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

    }
}
