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
using TaxiMaxim.BL.Controller;

namespace TaxiMaxim.WF
{
    public partial class MainMenu : Form
    {
        DataBase db = new DataBase("DUBOV_ILYA\\SQLEXPRESS", "TaxiMaximalnaya");
        
        SqlCommandBuilder scb;
        DataTable dt;

        // Tests
        List<Order> Orders = new List<Order>();
        List<Driver> Drivers = new List<Driver>();
        // Events
        event ButtonHandler Apply;
        event ButtonHandler Cancel;
        // Handlers 
        delegate void ButtonHandler();
        //
        

        public MainMenu()
        {
            InitializeComponent();
            try
            {
                loadGridOrders();
                dataBaseCheck_SLabel.Text = "Подключено";
                dataBaseCheck_SLabel.ForeColor = Color.FromArgb(0, 181, 36);               
            }
            catch (Exception)
            {
                dataBaseCheck_SLabel.Text = "Не подключено";
                dataBaseCheck_SLabel.ForeColor = Color.FromArgb(204, 0, 0);

                MessageBox.Show("DB NOT CONNECT");
            }
            Orders = FillOrders();
            loadGridDrivers();
            dGV_Orders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


        }
        private void loadGridOrders()
        {
            using (SqlConnection con = new SqlConnection(db.getConnection().ConnectionString))
            {

                SqlDataAdapter sda = new SqlDataAdapter("SELECT ORDER_ID, ORDER_PHONE_NUMBER, ORDER_ADRESS_START, ORDER_ADRESS_FINISH, ORDER_PRICE, ORDER_DATE, ORDER_PHONE_TYPE, DRIVER_ID FROM ORDERS", db.getConnection());
                dt = new DataTable();
                sda.Fill(dt);
                dGV_Orders.DataSource = dt;
                SqlDataAdapter adapter = new SqlDataAdapter();
                SqlCommand command = new SqlCommand("SELECT ORDER_PHONE_NUMBER, ORDER_ADRESS_START, ORDER_ADRESS_FINISH, ORDER_PRICE, ORDER_DATE, ORDER_PHONE_TYPE, DRIVER_ID FROM ORDERS", db.getConnection());
                DataTable table = new DataTable();
                adapter.SelectCommand = command;
                adapter.Fill(table);

                dGV_Orders.DataSource = table;

            }
        }
        private void loadGridDrivers()
        {
            db.openConnection();
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand command = new SqlCommand("SELECT * FROM DRIVER", db.getConnection());
            SqlDataReader oReader = command.ExecuteReader();
            Drivers = FillDrivers(oReader);
            DataTable table = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            db.closeConnection();
            dGV_drivers.DataSource = table;
            
        }
        private List<Order> FillOrders()
        {
            List<Order> matchingOrder = new List<Order>();
            string oString = "SELECT * FROM ORDERS";
            SqlCommand oCmd = new SqlCommand(oString, db.getConnection());
            db.openConnection();
            using(SqlDataReader oReader = oCmd.ExecuteReader())
            {
                while (oReader.Read())
                {
                    Order mOrder = new Order();
                    mOrder.Id = Convert.ToInt32(oReader["ORDER_ID"]);
                    mOrder.PhoneNumber = oReader["ORDER_PHONE_NUMBER"].ToString();
                    mOrder.AdressStart = oReader["ORDER_ADRESS_START"].ToString();
                    mOrder.AdressFinish = oReader["ORDER_ADRESS_FINISH"].ToString();
                    mOrder.Price = Convert.ToInt32(oReader["ORDER_PRICE"]);
                    mOrder.Date = (DateTime)oReader["ORDER_DATE"];
                    if(oReader["ORDER_PHONE_TYPE"] != DBNull.Value) 
                    mOrder.PhoneType = (bool)oReader["ORDER_PHONE_TYPE"] ;
                    if(oReader["DRIVER_ID"] != DBNull.Value)
                    mOrder.Driver_Id = Convert.ToInt32(oReader["DRIVER_ID"]);
                    matchingOrder.Add(mOrder);

                }
                db.closeConnection();
            }
            return matchingOrder;
        }
        private List<Driver> FillDrivers(SqlDataReader oCmd)
        {
            List<Driver> matchingDriver = new List<Driver>();
            using(SqlDataReader oReader = oCmd)
            {
                while(oReader.Read())
                {
                    Driver mDriver = new Driver();
                    mDriver.Id = Convert.ToInt32(oReader["DRIVER_ID"]);
                    mDriver.Name = oReader["DRIVER_NAME"].ToString();
                    mDriver.Pass = oReader["DRIVER_PASSPORT"].ToString();
                    mDriver.Phone = oReader["DRIVER_TELEPHONE"].ToString();
                    matchingDriver.Add(mDriver);
                }
            }
            return matchingDriver;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           // MessageBox.Show("Activate");
           
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //scb = new SqlCommandBuilder(sda);
            //sda.Update(dt);

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
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void buttonOrderTaxi_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DataTable dt = this.dGV_drivers.DataSource as DataTable;
            fLP_driversIO.Visible = true;
            dGV_drivers.ClearSelection(); //снять выделение всех выбранных ячеек
            int index = 0; // индекс последней строки
            dGV_drivers.Rows[index].Selected = true; // выделить нужную строку
            dGV_drivers.FirstDisplayedScrollingRowIndex = index; // фокус в нужную строку
            dGV_drivers.AllowUserToAddRows = false;
            dGV_drivers.ReadOnly = false;
            dGV_drivers.Columns[0].ReadOnly = true;
            DisableInFlow(fLP_driversTools);

            Apply += ApplyChanges;
            void ApplyChanges()
            {
                dGV_drivers.ClearSelection();
                dGV_drivers.ReadOnly = true;
                fLP_driversIO.Visible = false;
                EnableInFlow(fLP_driversTools);
                Apply -= ApplyChanges;
            }
            
            Cancel += DiscardChanges;
            void DiscardChanges()
            {
                dt.RejectChanges();
                dGV_drivers.CancelEdit();
                dGV_drivers.ClearSelection();
                dGV_drivers.ReadOnly = true;
                fLP_driversIO.Visible = false;
                EnableInFlow(fLP_driversTools);
                Cancel -= DiscardChanges;
            }

        }

        
        private void DisableInFlow(FlowLayoutPanel fLP)//Делает неактивными все кнопки в Flow
        {
            foreach (var tb in fLP.Controls.OfType<Button>())
            {
                tb.Enabled = false;
            }
        }
        private void EnableInFlow(FlowLayoutPanel fLP)//Делает кативными все кнопки в flow
        {
            foreach (var tb in fLP.Controls.OfType<Button>())
            {
                tb.Enabled = true;
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Apply?.Invoke();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Cancel?.Invoke();
        }

        private void dGV_drivers_CurrentCellChanged(object sender, DataGridViewCellEventArgs e)
        {
            switch (dGV_drivers.CurrentCell?.ColumnIndex)
            {
                case 0:
                    break;
                case 1:
                    if (string.IsNullOrWhiteSpace(dGV_drivers.CurrentCell.Value.ToString()))
                    {
                        //TODO: Сделать восстановление на прежнее место, пока не будет норм
                        MessageBox.Show("Поле не может быть пустым или содержать только символы пробела");
                        dGV_drivers.BeginEdit(true);
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
