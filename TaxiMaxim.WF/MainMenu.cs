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
using TaxiMaxim.WF.InputForms;
using System.Reflection;

namespace TaxiMaxim.WF
{
    public partial class MainMenu : Form
    {
        DataBase db = new DataBase("DESKTOP-VPOMAI1\\SQL44", "TaxiMaximalnaya");
        
        DataTable dt;
        HashSet<int> ChangedRowsDrivers = new HashSet<int>();
        HashSet<int> ChangedRowsOrders = new HashSet<int>();
        HashSet<int> ChangedRowsVehicles = new HashSet<int>();
        HashSet<int> ChangedRowsSchedules = new HashSet<int>();
        HashSet<int> ChangedRowsDirectory = new HashSet<int>();

        // Lists
        List<Order> Orders = new List<Order>();
        List<Driver> Drivers = new List<Driver>();
        List<Vehicle> Vehicles = new List<Vehicle>();
        List<Schedule> Schedules = new List<Schedule>();
        List<Directory> Directories = new List<Directory>();

        // Events
        event ButtonHandler Apply;
        event ButtonHandler Cancel;
        // Handlers 
        delegate void ButtonHandler();
        

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
            loadGridVehicles();
            loadGridSchedules();
            loadGridDirectory();
            dGV_Orders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dGV_drivers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dGV_Schedule.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dGV_Vehicle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dGV_Directory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


        }
        //Обновление всех таблиц во вью
        private void loadGridOrders()
        {
            using (SqlConnection con = new SqlConnection(db.getConnection().ConnectionString))
            {

                SqlDataAdapter sda = new SqlDataAdapter("SELECT ORDER_ID, ORDER_PHONE_NUMBER, ORDER_ADRESS_START, ORDER_ADRESS_FINISH, ORDER_PRICE, ORDER_DATE, ORDER_PHONE_TYPE, DRIVER_ID FROM ORDERS", db.getConnection());
                dt = new DataTable();
                sda.Fill(dt);
                dGV_Orders.DataSource = dt;
            }
            Orders = FillOrders();
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
        private void loadGridVehicles()
        {
            db.openConnection();
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand command = new SqlCommand("SELECT * FROM VEHICLE", db.getConnection());
            SqlDataReader oReader = command.ExecuteReader();
            Vehicles = FillVehicles(oReader);
            DataTable table = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            db.closeConnection();
            dGV_Vehicle.DataSource = table;
        }
        private void loadGridSchedules()
        {
            db.openConnection();
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand command = new SqlCommand("SELECT * FROM SCHEDULE", db.getConnection());
            SqlDataReader oReader = command.ExecuteReader();
            Schedules = FillSchedules(oReader);
            DataTable table = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            db.closeConnection();
            dGV_Schedule.DataSource = table;
        }
        private void loadGridDirectory()
        {
            db.openConnection();
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand command = new SqlCommand("SELECT * FROM DIRECTORY", db.getConnection());
            SqlDataReader oReader = command.ExecuteReader();
            Directories = FillDirectory(oReader);
            DataTable table = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            db.closeConnection();
            dGV_Directory.DataSource = table;
        }

        //Вытягивание данных из БД
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
        private List<Vehicle> FillVehicles(SqlDataReader oCmd)
        {
            List<Vehicle> matchingVehicle = new List<Vehicle>();
            using (SqlDataReader oReader = oCmd)
            {
                while (oReader.Read())
                {
                    Vehicle mVehicle = new Vehicle();
                    mVehicle.Id = Convert.ToInt32(oReader["VEHICLE_ID"]);
                    mVehicle.Number = oReader["VEHICLE_NUMBER"].ToString();
                    mVehicle.Brand = oReader["VEHICLE_BRAND"].ToString();
                    mVehicle.Model = oReader["VEHICLE_MODEL"].ToString();
                    mVehicle.Color = oReader["VEHICLE_COLOR"].ToString();
                    mVehicle.DriverID = Convert.ToInt32(oReader["DRIVER_ID"]);
                    matchingVehicle.Add(mVehicle);
                }
            }
            return matchingVehicle;
        }
        private List<Schedule> FillSchedules(SqlDataReader oCmd)
        {
            List<Schedule> matchingSchedule = new List<Schedule>();
            using (SqlDataReader oReader = oCmd)
            {
                while (oReader.Read())
                {
                    Schedule mSchedule = new Schedule();
                    mSchedule.Id = Convert.ToInt32(oReader["SCHEDULE_ID"]);
                    mSchedule.TimeStart = Convert.ToDateTime(oReader["SCHEDULE_DATE_START"]);
                    mSchedule.TimeEnd = Convert.ToDateTime(oReader["SCHEDULE_DATE_FINISH"]);
                    mSchedule.isWorking = (bool)oReader["SCHEDULE_GO_WORK"];
                    mSchedule.Driver_Id = Convert.ToInt32(oReader["DRIVER_ID"]);
                    matchingSchedule.Add(mSchedule);
                }
            }
            return matchingSchedule;
        }
        private List<Directory> FillDirectory(SqlDataReader oCmd)
        {
            List<Directory> matchingDirectory = new List<Directory>();
            using (SqlDataReader oReader = oCmd)
            {
                while (oReader.Read())
                {
                    Directory mDirectory = new Directory();
                    mDirectory.Id = Convert.ToInt32(oReader["DIRECTORY_ID"]);
                    mDirectory.Adress = oReader["DIRECTORY_ADRESS"].ToString();
                    mDirectory.Phone = oReader["DIRECTORY_ADRESS"].ToString();
                    if(oReader["ORDER_ID"] is DBNull)
                    {
                        mDirectory.Order_Id = null;
                    } else
                    mDirectory.Order_Id = int.Parse(oReader["ORDER_ID"].ToString());
                    matchingDirectory.Add(mDirectory);
                }
            }
            return matchingDirectory;
        }
        //Вспомогательные функции
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
        public static Task<object> GetTaskFromEvent(object o, string evt)
        {
            if (o == null || evt == null) throw new ArgumentNullException("Arguments cannot be null");

            EventInfo einfo = o.GetType().GetEvent(evt);
            if (einfo == null)
            {
                throw new ArgumentException(String.Format("*{0}* has no *{1}* event", o, evt));
            }

            TaskCompletionSource<object> tcs = new TaskCompletionSource<object>();
            MethodInfo mi = null;
            Delegate deleg = null;
            EventHandler handler = null;

            //код обработчика события
            handler = (s, e) =>
            {
                mi = handler.Method;
                deleg = Delegate.CreateDelegate(einfo.EventHandlerType, handler.Target, mi);
                einfo.RemoveEventHandler(s, deleg); //отцепляем обработчик события
                tcs.TrySetResult(null); //сигнализируем о наступлении события
            };

            mi = handler.Method;
            deleg = Delegate.CreateDelegate(einfo.EventHandlerType, handler.Target, mi); //получаем делегат нужного типа
            einfo.AddEventHandler(o, deleg); //присоединяем обработчик события
            return tcs.Task;
        }  //Для асинхронной функции ожидания закрытия формы

        //Driver toolbar buttons
        private async void dBtn_Add_Click(object sender, EventArgs e)
        {
            bool create = false;

            foreach (Form form in Application.OpenForms)
            {
                if (form.Name.ToString() == "AddDriver")
                {
                    //this.Hide();
                    form.Visible = true;
                    create = true;
                    break;
                }
            }
            if (create == false)
            {
                AddDriver createC = new AddDriver(db);
                //this.Hide();
                createC.Show();

                await GetTaskFromEvent(createC, "FormClosed");
                loadGridDrivers();

            }

        }
        private async void dBtn_Remove_Click(object sender, EventArgs e)
        {
            bool create = false;

            foreach (Form form in Application.OpenForms)
            {
                if (form.Name.ToString() == "DeleteOne")
                {
                    //this.Hide();
                    form.Visible = true;
                    create = true;
                    break;
                }
            }
            if (create == false)
            {
                Driver[] arrDriver = Drivers.ToArray();
                int[] data = new int[Drivers.Count];
                for (int i = 0; i < Drivers.Count; i++)
                {
                    data[i] = arrDriver[i].Id;
                }
                DeleteOne createC = new DeleteOne(data, db, "DRIVER", "DRIVER_ID");
                //this.Hide();
                createC.Show();

                await GetTaskFromEvent(createC, "FormClosed");
                loadGridDrivers();
                createC.Dispose();

            }
        }
        private void dBtn_Refresh_Click(object sender, EventArgs e)
        {
            loadGridDrivers();
        }
        private async void dBtn_Find_Click(object sender, EventArgs e)
        {
            bool create = false;

            foreach (Form form in Application.OpenForms)
            {
                if (form.Name.ToString() == "Find")
                {
                    //this.Hide();
                    form.Visible = true;
                    create = true;
                    break;
                }
            }
            if (create == false)
            {
                string[] data = new string[dGV_drivers.Columns.Count];
                for (int i = 0; i < data.Length; i++)
                {
                    data[i] = dGV_drivers.Columns[i].HeaderText;
                }
                Find createC = new Find(data, db, "DRIVER");
                //this.Hide();
                createC.Show();

                await GetTaskFromEvent(createC, "FormClosed");
                createC.Dispose();

            }
        }
        private async void dBtn_Sorting_Click(object sender, EventArgs e)
        {
            bool create = false;

            foreach (Form form in Application.OpenForms)
            {
                if (form.Name.ToString() == "Sorting")
                {
                    //this.Hide();
                    form.Visible = true;
                    create = true;
                    break;
                }
            }
            if (create == false)
            {
                string[] data = new string[dGV_drivers.Columns.Count];
                for (int i = 0; i < data.Length; i++)
                {
                    data[i] = dGV_drivers.Columns[i].HeaderText;
                }
                Sorting createC = new Sorting(db, data, "DRIVER");
                //this.Hide();
                createC.Show();

                await GetTaskFromEvent(createC, "FormClosed");
                createC.Dispose();

            }
        }
        private void btn_editmode(object sender, EventArgs e)
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
                foreach (var item in ChangedRowsDrivers)
                {
                    Driver temp = new Driver();
                    temp.Id = (int)dGV_drivers[0, item].Value;
                    temp.Name = (string)dGV_drivers[1, item].Value;
                    temp.Pass = (string)dGV_drivers[2, item].Value;
                    temp.Phone = (string)dGV_drivers[3, item].Value;
                    SqlCommand command = new SqlCommand($"UPDATE DRIVER SET DRIVER_NAME=\'{temp.Name}\', DRIVER_PASSPORT=\'{temp.Pass}\', DRIVER_TELEPHONE=\'{temp.Phone}\' WHERE DRIVER_ID={temp.Id}", db.getConnection());
                    db.openConnection();
                    int count = command.ExecuteNonQuery();
                    db.closeConnection();
                }
                ChangedRowsDrivers.Clear();
                EnableInFlow(fLP_driversTools);
                loadGridDrivers();
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

        }//Редактирование в таблице Drivers
        private void dGV_drivers_CurrentCellChanged(object sender, DataGridViewCellEventArgs e)
        {
            ChangedRowsDrivers.Add(e.RowIndex);
        }//Считывание изменённых строк
        private void button19_Click(object sender, EventArgs e)
        {
            Apply?.Invoke();
        }//Кнопка Галочка
        private void button20_Click(object sender, EventArgs e)
        {
            Cancel?.Invoke();
        }//Кнопка Крестик

        //Orders toolbar buttons
        private async void oBtn_Add_Click(object sender, EventArgs e)
        {
            bool create = false;

            foreach (Form form in Application.OpenForms)
            {
                if (form.Name.ToString() == "AddOrder")
                {
                    //this.Hide();
                    form.Visible = true;
                    create = true;
                    break;
                }
            }
            if (create == false)
            {
                AddOrder createC = new AddOrder(Drivers, db);
                //this.Hide();
                createC.Show();

                await GetTaskFromEvent(createC, "FormClosed");
                loadGridOrders();

            }
        }
        private async void oBtnRemove_Click(object sender, EventArgs e)
        {
            bool create = false;

            foreach (Form form in Application.OpenForms)
            {
                if (form.Name.ToString() == "DeleteOne")
                {
                    //this.Hide();
                    form.Visible = true;
                    create = true;
                    break;
                }
            }
            if (create == false)
            {
                Order[] arrOrders = Orders.ToArray();
                int[] data = new int[Orders.Count];
                for (int i = 0; i < Orders.Count; i++)
                {
                    data[i] = arrOrders[i].Id;
                }
                DeleteOne createC = new DeleteOne(data, db, "ORDERS", "ORDER_ID");
                //this.Hide();
                createC.Show();

                await GetTaskFromEvent(createC, "FormClosed");
                loadGridOrders();
                createC.Dispose();

            }
        }
        private void oBtn_Refresh_Click(object sender, EventArgs e)
        {
            loadGridOrders();
        }
        private async void oBtn_Find_Click(object sender, EventArgs e)
        {
            bool create = false;

            foreach (Form form in Application.OpenForms)
            {
                if (form.Name.ToString() == "Find")
                {
                    //this.Hide();
                    form.Visible = true;
                    create = true;
                    break;
                }
            }
            if (create == false)
            {
                string[] data = new string[dGV_Orders.Columns.Count];
                for (int i = 0; i < data.Length; i++)
                {
                    data[i] = dGV_Orders.Columns[i].HeaderText;
                }
                Find createC = new Find(data, db, "ORDERS");
                //this.Hide();
                createC.Show();

                await GetTaskFromEvent(createC, "FormClosed");
                createC.Dispose();

            }
        }
        private async void oBtn_Sorting_Click(object sender, EventArgs e)
        {
            bool create = false;

            foreach (Form form in Application.OpenForms)
            {
                if (form.Name.ToString() == "Sorting")
                {
                    //this.Hide();
                    form.Visible = true;
                    create = true;
                    break;
                }
            }
            if (create == false)
            {
                string[] data = new string[dGV_Orders.Columns.Count];
                for (int i = 0; i < data.Length; i++)
                {
                    data[i] = dGV_Orders.Columns[i].HeaderText;
                }
                Sorting createC = new Sorting(db, data, "ORDERS");
                //this.Hide();
                createC.Show();

                await GetTaskFromEvent(createC, "FormClosed");
                createC.Dispose();

            }
        }
        private void oBtn_Edit_Click(object sender, EventArgs e)
        {
            DataTable dt = this.dGV_Orders.DataSource as DataTable;
            fLP_OrdersIO.Visible = true;
            dGV_Orders.ClearSelection(); //снять выделение всех выбранных ячеек
            int index = 0; // индекс последней строки
            dGV_Orders.Rows[index].Selected = true; // выделить нужную строку
            dGV_Orders.FirstDisplayedScrollingRowIndex = index; // фокус в нужную строку
            dGV_Orders.AllowUserToAddRows = false;
            dGV_Orders.ReadOnly = false;
            dGV_Orders.Columns[0].ReadOnly = true;
            DisableInFlow(fLP_OrdersTools);

            Apply += ApplyChanges;
            void ApplyChanges()
            {
                dGV_Orders.ClearSelection();
                dGV_Orders.ReadOnly = true;
                fLP_OrdersIO.Visible = false;
                foreach (var item in ChangedRowsOrders)
                {
                    Order temp = new Order();
                    temp.Id = (int)dGV_Orders[0, item].Value;
                    temp.PhoneNumber = (string)dGV_Orders[1, item].Value;
                    temp.AdressStart = (string)dGV_Orders[2, item].Value;
                    temp.AdressFinish = (string)dGV_Orders[3, item].Value;
                    temp.Price = Math.Round((decimal)dGV_Orders[4, item].Value, 0);
                    temp.Date = (DateTime)dGV_Orders[5, item].Value;
                    temp.PhoneType = (bool?)dGV_Orders[6, item].Value;
                    temp.Driver_Id = (int)dGV_Orders[7, item].Value;
                    SqlCommand command = new SqlCommand($"UPDATE ORDERS SET " +
                        $"ORDER_PHONE_NUMBER=\'{temp.PhoneNumber}\'," +
                        $"ORDER_ADRESS_START=\'{temp.AdressStart}\'," +
                        $"ORDER_ADRESS_FINISH=\'{temp.AdressFinish}\'," +
                        $"ORDER_PRICE=\'{temp.Price}\'," +
                        $"ORDER_DATE=\'{temp.Date}\'," +
                        $"ORDER_PHONE_TYPE=\'{temp.PhoneType.GetHashCode()}\'," +
                        $"DRIVER_ID=\'{temp.Driver_Id}\'" +
                        $"WHERE ORDER_ID={temp.Id}", db.getConnection());
                    db.openConnection();
                    int count = command.ExecuteNonQuery();
                    db.closeConnection();
                }
                ChangedRowsOrders.Clear();
                loadGridOrders();
                EnableInFlow(fLP_OrdersTools);
                Apply -= ApplyChanges;
            }

            Cancel += DiscardChanges;
            void DiscardChanges()
            {
                dt.RejectChanges();
                dGV_Orders.CancelEdit();
                dGV_Orders.ClearSelection();
                dGV_Orders.ReadOnly = true;
                fLP_OrdersIO.Visible = false;
                EnableInFlow(fLP_OrdersTools);
                Cancel -= DiscardChanges;
            }
        }
        private void oBtn_Apply_Click(object sender, EventArgs e)
        {
            Apply?.Invoke();
        }
        private void oBtn_Cancel_Click(object sender, EventArgs e)
        {
            Cancel?.Invoke();
        }
        private void dGV_Orders_CellEndEdit(object sender, DataGridViewCellEventArgs e)//Считывание изменённых строк
        {
            ChangedRowsOrders.Add(e.RowIndex);
        }

        //Vehicles toolbar buttons
        private async void vBtn_Add_Click(object sender, EventArgs e)
        {
            bool create = false;

            foreach (Form form in Application.OpenForms)
            {
                if (form.Name.ToString() == "AddVehicle")
                {
                    //this.Hide();
                    form.Visible = true;
                    create = true;
                    break;
                }
            }
            if (create == false)
            {
                AddVehicle createC = new AddVehicle(Drivers, db);
                //this.Hide();
                createC.Show();

                await GetTaskFromEvent(createC, "FormClosed");
                loadGridVehicles();

            }
        }
        private async void vBtn_Delete_Click(object sender, EventArgs e)
        {
            bool create = false;

            foreach (Form form in Application.OpenForms)
            {
                if (form.Name.ToString() == "DeleteOne")
                {
                    //this.Hide();
                    form.Visible = true;
                    create = true;
                    break;
                }
            }
            if (create == false)
            {
                Vehicle[] arr = Vehicles.ToArray();
                int[] data = new int[Vehicles.Count];
                for (int i = 0; i < Vehicles.Count; i++)
                {
                    data[i] = arr[i].Id;
                }
                DeleteOne createC = new DeleteOne(data, db, "VEHICLE", "VEHICLE_ID");
                //this.Hide();
                createC.Show();

                await GetTaskFromEvent(createC, "FormClosed");
                loadGridVehicles();
                createC.Dispose();
            }
        }
        private void vBtn_Refresh_Click(object sender, EventArgs e)
        {
            loadGridVehicles();
        }
        private async void vBtn_Find_Click(object sender, EventArgs e)
        {
            bool create = false;

            foreach (Form form in Application.OpenForms)
            {
                if (form.Name.ToString() == "Find")
                {
                    //this.Hide();
                    form.Visible = true;
                    create = true;
                    break;
                }
            }
            if (create == false)
            {
                string[] data = new string[dGV_Vehicle.Columns.Count];
                for (int i = 0; i < data.Length; i++)
                {
                    data[i] = dGV_Vehicle.Columns[i].HeaderText;
                }
                Find createC = new Find(data, db, "VEHICLE");
                //this.Hide();
                createC.Show();

                await GetTaskFromEvent(createC, "FormClosed");
                createC.Dispose();

            }
        }
        private async void vBtn_Sort_Click(object sender, EventArgs e)
        {
            bool create = false;

            foreach (Form form in Application.OpenForms)
            {
                if (form.Name.ToString() == "Sorting")
                {
                    //this.Hide();
                    form.Visible = true;
                    create = true;
                    break;
                }
            }
            if (create == false)
            {
                string[] data = new string[dGV_Vehicle.Columns.Count];
                for (int i = 0; i < data.Length; i++)
                {
                    data[i] = dGV_Vehicle.Columns[i].HeaderText;
                }
                Sorting createC = new Sorting(db, data, "VEHICLE");
                //this.Hide();
                createC.Show();

                await GetTaskFromEvent(createC, "FormClosed");
                createC.Dispose();

            }
        }
        private void vBtn_Edit_Click(object sender, EventArgs e)
        {
            DataTable dt = this.dGV_Vehicle.DataSource as DataTable;
            fLP_VehicleIO.Visible = true;
            dGV_Vehicle.ClearSelection(); //снять выделение всех выбранных ячеек
            int index = 0; // индекс последней строки
            dGV_Vehicle.Rows[index].Selected = true; // выделить нужную строку
            dGV_Vehicle.FirstDisplayedScrollingRowIndex = index; // фокус в нужную строку
            dGV_Vehicle.AllowUserToAddRows = false;
            dGV_Vehicle.ReadOnly = false;
            dGV_Vehicle.Columns[0].ReadOnly = true;
            DisableInFlow(fLP_VehicleTools);

            Apply += ApplyChanges;
            void ApplyChanges()
            {
                dGV_Vehicle.ClearSelection();
                dGV_Vehicle.ReadOnly = true;
                fLP_VehicleIO.Visible = false;
                foreach (var item in ChangedRowsVehicles)
                {
                    Vehicle temp = new Vehicle();
                    temp.Id = (int)dGV_Vehicle[0, item].Value;
                    temp.Number = (string)dGV_Vehicle[1, item].Value;
                    temp.Brand = (string)dGV_Vehicle[2, item].Value;
                    temp.Model = (string)dGV_Vehicle[3, item].Value;
                    temp.Color = (string)dGV_Vehicle[4, item].Value;
                    temp.DriverID = (int)dGV_Vehicle[5, item].Value;
                    SqlCommand command = new SqlCommand($"UPDATE VEHICLE SET " +
                        $"VEHICLE_NUMBER=\'{temp.Number}\'," +
                        $"VEHICLE_BRAND=\'{temp.Brand}\'," +
                        $"VEHICLE_MODEL=\'{temp.Model}\'," +
                        $"VEHICLE_COLOR=\'{temp.Color}\'," +
                        $"DRIVER_ID=\'{temp.DriverID}\'" +
                        $"WHERE VEHICLE_ID={temp.Id}", db.getConnection());
                    db.openConnection();
                    int count = command.ExecuteNonQuery();
                    db.closeConnection();
                }
                ChangedRowsVehicles.Clear();
                loadGridVehicles();
                EnableInFlow(fLP_VehicleTools);
                Apply -= ApplyChanges;
            }

            Cancel += DiscardChanges;
            void DiscardChanges()
            {
                dt.RejectChanges();
                dGV_Vehicle.CancelEdit();
                dGV_Vehicle.ClearSelection();
                dGV_Vehicle.ReadOnly = true;
                fLP_VehicleIO.Visible = false;
                EnableInFlow(fLP_VehicleTools);
                Cancel -= DiscardChanges;
            }
        }
        private void vBtn_Apply_Click(object sender, EventArgs e)
        {
            Apply?.Invoke();
        }
        private void vBtn_Cancel_Click(object sender, EventArgs e)
        {
            Cancel?.Invoke();
        }
        private void dGV_Vehicle_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            ChangedRowsVehicles.Add(e.RowIndex);
        }

        //Schedules toolbar buttons
        private async void sBtn_Add_Click(object sender, EventArgs e)
        {
            bool create = false;

            foreach (Form form in Application.OpenForms)
            {
                if (form.Name.ToString() == "AddSchedule")
                {
                    //this.Hide();
                    form.Visible = true;
                    create = true;
                    break;
                }
            }
            if (create == false)
            {
                AddSchedule createC = new AddSchedule(Drivers, db);
                //this.Hide();
                createC.Show();

                await GetTaskFromEvent(createC, "FormClosed");
                loadGridSchedules();

            }
        }
        private async void sBtn_Remove_Click(object sender, EventArgs e)
        {
            bool create = false;

            foreach (Form form in Application.OpenForms)
            {
                if (form.Name.ToString() == "DeleteOne")
                {
                    //this.Hide();
                    form.Visible = true;
                    create = true;
                    break;
                }
            }
            if (create == false)
            {
                Schedule[] arr = Schedules.ToArray();
                int[] data = new int[Schedules.Count];
                for (int i = 0; i < Schedules.Count; i++)
                {
                    data[i] = arr[i].Id;
                }
                DeleteOne createC = new DeleteOne(data, db, "SCHEDULE", "SCHEDULE_ID");
                //this.Hide();
                createC.Show();

                await GetTaskFromEvent(createC, "FormClosed");
                loadGridSchedules();
                createC.Dispose();
            }
        }
        private void sBtn_Refresh_Click(object sender, EventArgs e)
        {
            loadGridSchedules();
        }
        private async void sBtn_Find_Click(object sender, EventArgs e)
        {
            bool create = false;

            foreach (Form form in Application.OpenForms)
            {
                if (form.Name.ToString() == "Find")
                {
                    //this.Hide();
                    form.Visible = true;
                    create = true;
                    break;
                }
            }
            if (create == false)
            {
                string[] data = new string[dGV_Schedule.Columns.Count];
                for (int i = 0; i < data.Length; i++)
                {
                    data[i] = dGV_Schedule.Columns[i].HeaderText;
                }
                Find createC = new Find(data, db, "SCHEDULE");
                //this.Hide();
                createC.Show();

                await GetTaskFromEvent(createC, "FormClosed");
                createC.Dispose();

            }
        }
        private async void sBtn_Sort_Click(object sender, EventArgs e)
        {
            bool create = false;

            foreach (Form form in Application.OpenForms)
            {
                if (form.Name.ToString() == "Sorting")
                {
                    //this.Hide();
                    form.Visible = true;
                    create = true;
                    break;
                }
            }
            if (create == false)
            {
                string[] data = new string[dGV_Schedule.Columns.Count];
                for (int i = 0; i < data.Length; i++)
                {
                    data[i] = dGV_Schedule.Columns[i].HeaderText;
                }
                Sorting createC = new Sorting(db, data, "SCHEDULE");
                //this.Hide();
                createC.Show();

                await GetTaskFromEvent(createC, "FormClosed");
                createC.Dispose();

            }
        }
        private void sBtn_Apply_Click(object sender, EventArgs e)
        {
            Apply?.Invoke();
        }
        private void sBtn_Cancel_Click(object sender, EventArgs e)
        {
            Cancel?.Invoke();
        }
        private void dGV_Schedule_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if(string.IsNullOrEmpty(dGV_Schedule[e.ColumnIndex,e.RowIndex].Value.ToString()) )
            {

            }
                ChangedRowsSchedules.Add(e.RowIndex);
        }
        private void sBtn_Edit_Click(object sender, EventArgs e)
        {
            DataTable dt = this.dGV_Schedule.DataSource as DataTable;
            fLP_ScheduleIO.Visible = true;
            dGV_Schedule.ClearSelection(); //снять выделение всех выбранных ячеек
            int index = 0; // индекс последней строки
            dGV_Schedule.Rows[index].Selected = true; // выделить нужную строку
            dGV_Schedule.FirstDisplayedScrollingRowIndex = index; // фокус в нужную строку
            dGV_Schedule.AllowUserToAddRows = false;
            dGV_Schedule.ReadOnly = false;
            dGV_Schedule.Columns[0].ReadOnly = true;
            DisableInFlow(fLP_ScheduleTools);

            Apply += ApplyChanges;
            void ApplyChanges()
            {
                dGV_Schedule.ClearSelection();
                dGV_Schedule.ReadOnly = true;
                fLP_ScheduleIO.Visible = false;
                foreach (var item in ChangedRowsSchedules)
                {
                    Schedule temp = new Schedule();
                    temp.Id = (int)dGV_Schedule[0, item].Value;
                    temp.TimeStart = (DateTime)dGV_Schedule[1, item].Value;
                    temp.TimeEnd = (DateTime)dGV_Schedule[2, item].Value;
                    temp.isWorking = (bool)dGV_Schedule[3, item].Value;
                    temp.Driver_Id = (int)dGV_Schedule[4, item].Value;
                    SqlCommand command = new SqlCommand($"UPDATE Schedule SET " +
                        $"SCHEDULE_DATE_START=\'{temp.TimeStart}\'," +
                        $"SCHEDULE_DATE_FINISH=\'{temp.TimeEnd}\'," +
                        $"SCHEDULE_GO_WORK=\'{temp.isWorking.GetHashCode()}\'," +
                        $"DRIVER_ID=\'{temp.Driver_Id}\'" +
                        $"WHERE SCHEDULE_ID={temp.Id}", db.getConnection());
                    db.openConnection();
                    int count = command.ExecuteNonQuery();
                    db.closeConnection();
                }
                ChangedRowsSchedules.Clear();
                loadGridSchedules();
                EnableInFlow(fLP_ScheduleTools);
                Apply -= ApplyChanges;
            }

            Cancel += DiscardChanges;
            void DiscardChanges()
            {
                dt.RejectChanges();
                dGV_Schedule.CancelEdit();
                dGV_Schedule.ClearSelection();
                dGV_Schedule.ReadOnly = true;
                fLP_ScheduleIO.Visible = false;
                EnableInFlow(fLP_ScheduleTools);
                Cancel -= DiscardChanges;
            }
        }
        private void dGV_Schedule_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show(e.Exception.ToString());
            MessageBox.Show($"Введенны некорректные данные, исправьте значение изменённого элемента {e.RowIndex} строки");
            e.Cancel = true;
            e.ThrowException = false;
        }

        private void drBtn_Add_Click(object sender, EventArgs e)
        {

        }

        private async void drBtn_Delete_Click(object sender, EventArgs e)
        {
            bool create = false;

            foreach (Form form in Application.OpenForms)
            {
                if (form.Name.ToString() == "DeleteOne")
                {
                    //this.Hide();
                    form.Visible = true;
                    create = true;
                    break;
                }
            }
            if (create == false)
            {
                Directory[] arr = Directories.ToArray();
                int[] data = new int[Directories.Count];
                for (int i = 0; i < Directories.Count; i++)
                {
                    data[i] = arr[i].Id;
                }
                DeleteOne createC = new DeleteOne(data, db, "DIRECTORY", "DIRECTORY_ID");
                //this.Hide();
                createC.Show();

                await GetTaskFromEvent(createC, "FormClosed");
                loadGridDirectory();
                createC.Dispose();
            }
        }

        private void drBtn_Refresh_Click(object sender, EventArgs e)
        {
            loadGridDirectory();
        }

        private async void drBtn_Find_Click(object sender, EventArgs e)
        {
            bool create = false;

            foreach (Form form in Application.OpenForms)
            {
                if (form.Name.ToString() == "Find")
                {
                    //this.Hide();
                    form.Visible = true;
                    create = true;
                    break;
                }
            }
            if (create == false)
            {
                string[] data = new string[dGV_Directory.Columns.Count];
                for (int i = 0; i < data.Length; i++)
                {
                    data[i] = dGV_Directory.Columns[i].HeaderText;
                }
                Find createC = new Find(data, db, "DIRECTORY");
                //this.Hide();
                createC.Show();

                await GetTaskFromEvent(createC, "FormClosed");
                createC.Dispose();

            }
        }

        private async void drBtn_Sort_Click(object sender, EventArgs e)
        {
            bool create = false;

            foreach (Form form in Application.OpenForms)
            {
                if (form.Name.ToString() == "Sorting")
                {
                    //this.Hide();
                    form.Visible = true;
                    create = true;
                    break;
                }
            }
            if (create == false)
            {
                string[] data = new string[dGV_Directory.Columns.Count];
                for (int i = 0; i < data.Length; i++)
                {
                    data[i] = dGV_Directory.Columns[i].HeaderText;
                }
                Sorting createC = new Sorting(db, data, "DIRECTORY");
                //this.Hide();
                createC.Show();

                await GetTaskFromEvent(createC, "FormClosed");
                createC.Dispose();

            }
        }

        private void drBtn_Edit_Click(object sender, EventArgs e)
        {
            DataTable dt = this.dGV_Directory.DataSource as DataTable;
            fLP_DirectoryIO.Visible = true;
            dGV_Directory.ClearSelection(); //снять выделение всех выбранных ячеек
            int index = 0; // индекс последней строки
            dGV_Directory.Rows[index].Selected = true; // выделить нужную строку
            dGV_Directory.FirstDisplayedScrollingRowIndex = index; // фокус в нужную строку
            dGV_Directory.AllowUserToAddRows = false;
            dGV_Directory.ReadOnly = false;
            dGV_Directory.Columns[0].ReadOnly = true;
            DisableInFlow(fLP_DirectoryTools);

            Apply += ApplyChanges;
            void ApplyChanges()
            {
                dGV_Directory.ClearSelection();
                dGV_Directory.ReadOnly = true;
                fLP_DirectoryIO.Visible = false;
                foreach (var item in ChangedRowsDirectory)
                {
                    Directory temp = new Directory();
                    temp.Id = (int)dGV_Directory[0, item].Value;
                    temp.Phone = (string)dGV_Directory[1, item].Value;
                    temp.Adress = (string)dGV_Directory[2, item].Value;
                    string orderid; 
                    if (dGV_Directory[3, item].Value is DBNull)
                    {
                        temp.Order_Id = null;
                        orderid = "NULL";
                    }
                    else
                    {
                        temp.Order_Id = (int)dGV_Directory[3, item].Value;
                        orderid = temp.Order_Id.ToString();
                    }

                    SqlCommand command = new SqlCommand($"UPDATE DIRECTORY SET " +
                        $"DIRECTORY_TELEPHONE=\'{temp.Phone}\'," +
                        $"DIRECTORY_ADRESS=\'{temp.Adress}\'," +
                        $"ORDER_ID={orderid} " +
                        $"WHERE DIRECTORY_ID={temp.Id}", db.getConnection());
                    db.openConnection();
                    int count = command.ExecuteNonQuery();
                    db.closeConnection();
                }
                ChangedRowsDirectory.Clear();
                loadGridDirectory();
                EnableInFlow(fLP_DirectoryTools);
                Apply -= ApplyChanges;
            }

            Cancel += DiscardChanges;
            void DiscardChanges()
            {
                dt.RejectChanges();
                dGV_Directory.CancelEdit();
                dGV_Directory.ClearSelection();
                dGV_Directory.ReadOnly = true;
                fLP_DirectoryIO.Visible = false;
                EnableInFlow(fLP_DirectoryTools);
                Cancel -= DiscardChanges;
            }
        }

        private void drBtn_Apply_Click(object sender, EventArgs e)
        {
            Apply?.Invoke();
        }

        private void drBtn_Cancel_Click(object sender, EventArgs e)
        {
            Cancel?.Invoke();
        }

        private void dGV_Directory_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            ChangedRowsDirectory.Add(e.RowIndex);
        }

        //Directory toolbar buttons

    }
}


//TODO:Добавить штуку, чтоб возвращало ошибку при невозможной связи. К примеру Driver_ID не существует
//TODO: Чистить векторы с данными после действий
