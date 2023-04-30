
namespace TaxiMaxim.WF
{
    partial class MainMenu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Manager = new System.Windows.Forms.TabPage();
            this.fLP_OrdersIO = new System.Windows.Forms.FlowLayoutPanel();
            this.oBtn_Apply = new System.Windows.Forms.Button();
            this.oBtn_Cancel = new System.Windows.Forms.Button();
            this.fLP_driversIO = new System.Windows.Forms.FlowLayoutPanel();
            this.dBtn_Apply = new System.Windows.Forms.Button();
            this.dBtn_Cancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dGV_drivers = new System.Windows.Forms.DataGridView();
            this.fLP_OrdersTools = new System.Windows.Forms.FlowLayoutPanel();
            this.oBtn_Add = new System.Windows.Forms.Button();
            this.oBtnRemove = new System.Windows.Forms.Button();
            this.oBtn_Refresh = new System.Windows.Forms.Button();
            this.oBtn_Find = new System.Windows.Forms.Button();
            this.oBtn_Sorting = new System.Windows.Forms.Button();
            this.oBtn_Edit = new System.Windows.Forms.Button();
            this.oBtn_Insert = new System.Windows.Forms.Button();
            this.fLP_driversTools = new System.Windows.Forms.FlowLayoutPanel();
            this.dBtn_Add = new System.Windows.Forms.Button();
            this.dBtn_Remove = new System.Windows.Forms.Button();
            this.dBtn_Refresh = new System.Windows.Forms.Button();
            this.dBtn_Find = new System.Windows.Forms.Button();
            this.dBtn_Sorting = new System.Windows.Forms.Button();
            this.dBtn_Edit = new System.Windows.Forms.Button();
            this.dBtn_Insert = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox_activeDrivers = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox_activeOrders = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dGV_Orders = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.AutoPark = new System.Windows.Forms.TabPage();
            this.tableTest = new System.Windows.Forms.TableLayoutPanel();
            this.HouseBooking = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button21 = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.dataBaseCheck_SLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.чтотоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonOrderTaxi = new System.Windows.Forms.ToolStripButton();
            this.tabControl1.SuspendLayout();
            this.Manager.SuspendLayout();
            this.fLP_OrdersIO.SuspendLayout();
            this.fLP_driversIO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_drivers)).BeginInit();
            this.fLP_OrdersTools.SuspendLayout();
            this.fLP_driversTools.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Orders)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            this.AutoPark.SuspendLayout();
            this.HouseBooking.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button1.Location = new System.Drawing.Point(741, 152);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 37);
            this.button1.TabIndex = 1;
            this.button1.Text = "Обновить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(610, 152);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 37);
            this.button2.TabIndex = 2;
            this.button2.Text = "Добавить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.Manager);
            this.tabControl1.Controls.Add(this.AutoPark);
            this.tabControl1.Controls.Add(this.HouseBooking);
            this.tabControl1.Location = new System.Drawing.Point(0, 25);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1264, 714);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 6;
            // 
            // Manager
            // 
            this.Manager.Controls.Add(this.fLP_OrdersIO);
            this.Manager.Controls.Add(this.fLP_driversIO);
            this.Manager.Controls.Add(this.label2);
            this.Manager.Controls.Add(this.label1);
            this.Manager.Controls.Add(this.dGV_drivers);
            this.Manager.Controls.Add(this.fLP_OrdersTools);
            this.Manager.Controls.Add(this.fLP_driversTools);
            this.Manager.Controls.Add(this.panel1);
            this.Manager.Controls.Add(this.dGV_Orders);
            this.Manager.Controls.Add(this.flowLayoutPanel2);
            this.Manager.Location = new System.Drawing.Point(4, 25);
            this.Manager.Name = "Manager";
            this.Manager.Padding = new System.Windows.Forms.Padding(3);
            this.Manager.Size = new System.Drawing.Size(1256, 685);
            this.Manager.TabIndex = 0;
            this.Manager.Text = "Диспетчер";
            this.Manager.UseVisualStyleBackColor = true;
            this.Manager.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // fLP_OrdersIO
            // 
            this.fLP_OrdersIO.Controls.Add(this.oBtn_Apply);
            this.fLP_OrdersIO.Controls.Add(this.oBtn_Cancel);
            this.fLP_OrdersIO.Location = new System.Drawing.Point(890, 115);
            this.fLP_OrdersIO.Name = "fLP_OrdersIO";
            this.fLP_OrdersIO.Size = new System.Drawing.Size(131, 46);
            this.fLP_OrdersIO.TabIndex = 10;
            this.fLP_OrdersIO.Visible = false;
            // 
            // oBtn_Apply
            // 
            this.oBtn_Apply.BackgroundImage = global::TaxiMaxim.WF.Properties.Resources.approved;
            this.oBtn_Apply.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.oBtn_Apply.Location = new System.Drawing.Point(3, 3);
            this.oBtn_Apply.Name = "oBtn_Apply";
            this.oBtn_Apply.Size = new System.Drawing.Size(38, 40);
            this.oBtn_Apply.TabIndex = 6;
            this.oBtn_Apply.UseVisualStyleBackColor = true;
            this.oBtn_Apply.Click += new System.EventHandler(this.button19_Click);
            // 
            // oBtn_Cancel
            // 
            this.oBtn_Cancel.BackgroundImage = global::TaxiMaxim.WF.Properties.Resources.close;
            this.oBtn_Cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.oBtn_Cancel.Location = new System.Drawing.Point(47, 3);
            this.oBtn_Cancel.Name = "oBtn_Cancel";
            this.oBtn_Cancel.Size = new System.Drawing.Size(38, 40);
            this.oBtn_Cancel.TabIndex = 6;
            this.oBtn_Cancel.UseVisualStyleBackColor = true;
            this.oBtn_Cancel.Click += new System.EventHandler(this.button20_Click);
            // 
            // fLP_driversIO
            // 
            this.fLP_driversIO.Controls.Add(this.dBtn_Apply);
            this.fLP_driversIO.Controls.Add(this.dBtn_Cancel);
            this.fLP_driversIO.Location = new System.Drawing.Point(365, 118);
            this.fLP_driversIO.Name = "fLP_driversIO";
            this.fLP_driversIO.Size = new System.Drawing.Size(131, 46);
            this.fLP_driversIO.TabIndex = 10;
            this.fLP_driversIO.Visible = false;
            // 
            // dBtn_Apply
            // 
            this.dBtn_Apply.BackgroundImage = global::TaxiMaxim.WF.Properties.Resources.approved;
            this.dBtn_Apply.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dBtn_Apply.Location = new System.Drawing.Point(3, 3);
            this.dBtn_Apply.Name = "dBtn_Apply";
            this.dBtn_Apply.Size = new System.Drawing.Size(38, 40);
            this.dBtn_Apply.TabIndex = 6;
            this.dBtn_Apply.UseVisualStyleBackColor = true;
            this.dBtn_Apply.Click += new System.EventHandler(this.button19_Click);
            // 
            // dBtn_Cancel
            // 
            this.dBtn_Cancel.BackgroundImage = global::TaxiMaxim.WF.Properties.Resources.close;
            this.dBtn_Cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dBtn_Cancel.Location = new System.Drawing.Point(47, 3);
            this.dBtn_Cancel.Name = "dBtn_Cancel";
            this.dBtn_Cancel.Size = new System.Drawing.Size(38, 40);
            this.dBtn_Cancel.TabIndex = 6;
            this.dBtn_Cancel.UseVisualStyleBackColor = true;
            this.dBtn_Cancel.Click += new System.EventHandler(this.button20_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(550, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Заказы";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(29, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Водители";
            // 
            // dGV_drivers
            // 
            this.dGV_drivers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dGV_drivers.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dGV_drivers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_drivers.Location = new System.Drawing.Point(11, 170);
            this.dGV_drivers.Name = "dGV_drivers";
            this.dGV_drivers.ReadOnly = true;
            this.dGV_drivers.RowHeadersWidth = 51;
            this.dGV_drivers.Size = new System.Drawing.Size(485, 486);
            this.dGV_drivers.TabIndex = 3;
            this.dGV_drivers.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV_drivers_CurrentCellChanged);
            // 
            // fLP_OrdersTools
            // 
            this.fLP_OrdersTools.Controls.Add(this.oBtn_Add);
            this.fLP_OrdersTools.Controls.Add(this.oBtnRemove);
            this.fLP_OrdersTools.Controls.Add(this.oBtn_Refresh);
            this.fLP_OrdersTools.Controls.Add(this.oBtn_Find);
            this.fLP_OrdersTools.Controls.Add(this.oBtn_Sorting);
            this.fLP_OrdersTools.Controls.Add(this.oBtn_Edit);
            this.fLP_OrdersTools.Controls.Add(this.oBtn_Insert);
            this.fLP_OrdersTools.Location = new System.Drawing.Point(536, 115);
            this.fLP_OrdersTools.Name = "fLP_OrdersTools";
            this.fLP_OrdersTools.Size = new System.Drawing.Size(347, 46);
            this.fLP_OrdersTools.TabIndex = 2;
            // 
            // oBtn_Add
            // 
            this.oBtn_Add.BackgroundImage = global::TaxiMaxim.WF.Properties.Resources.free_icon_plus_1828819;
            this.oBtn_Add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.oBtn_Add.Location = new System.Drawing.Point(3, 3);
            this.oBtn_Add.Name = "oBtn_Add";
            this.oBtn_Add.Size = new System.Drawing.Size(38, 40);
            this.oBtn_Add.TabIndex = 0;
            this.oBtn_Add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.oBtn_Add.UseVisualStyleBackColor = true;
            this.oBtn_Add.Click += new System.EventHandler(this.button3_Click);
            // 
            // oBtnRemove
            // 
            this.oBtnRemove.BackgroundImage = global::TaxiMaxim.WF.Properties.Resources.free_icon_minus_1828779;
            this.oBtnRemove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.oBtnRemove.Location = new System.Drawing.Point(47, 3);
            this.oBtnRemove.Name = "oBtnRemove";
            this.oBtnRemove.Size = new System.Drawing.Size(38, 40);
            this.oBtnRemove.TabIndex = 1;
            this.oBtnRemove.UseVisualStyleBackColor = true;
            // 
            // oBtn_Refresh
            // 
            this.oBtn_Refresh.BackgroundImage = global::TaxiMaxim.WF.Properties.Resources.free_icon_reload_1828841;
            this.oBtn_Refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.oBtn_Refresh.Location = new System.Drawing.Point(91, 3);
            this.oBtn_Refresh.Name = "oBtn_Refresh";
            this.oBtn_Refresh.Size = new System.Drawing.Size(38, 40);
            this.oBtn_Refresh.TabIndex = 2;
            this.oBtn_Refresh.UseVisualStyleBackColor = true;
            // 
            // oBtn_Find
            // 
            this.oBtn_Find.BackgroundImage = global::TaxiMaxim.WF.Properties.Resources.free_icon_search_1828855;
            this.oBtn_Find.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.oBtn_Find.Location = new System.Drawing.Point(135, 3);
            this.oBtn_Find.Name = "oBtn_Find";
            this.oBtn_Find.Size = new System.Drawing.Size(38, 40);
            this.oBtn_Find.TabIndex = 3;
            this.oBtn_Find.UseVisualStyleBackColor = true;
            // 
            // oBtn_Sorting
            // 
            this.oBtn_Sorting.BackgroundImage = global::TaxiMaxim.WF.Properties.Resources.free_icon_filter_1828699;
            this.oBtn_Sorting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.oBtn_Sorting.Location = new System.Drawing.Point(179, 3);
            this.oBtn_Sorting.Name = "oBtn_Sorting";
            this.oBtn_Sorting.Size = new System.Drawing.Size(38, 40);
            this.oBtn_Sorting.TabIndex = 4;
            this.oBtn_Sorting.UseVisualStyleBackColor = true;
            // 
            // oBtn_Edit
            // 
            this.oBtn_Edit.BackgroundImage = global::TaxiMaxim.WF.Properties.Resources.pencil;
            this.oBtn_Edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.oBtn_Edit.Location = new System.Drawing.Point(223, 3);
            this.oBtn_Edit.Name = "oBtn_Edit";
            this.oBtn_Edit.Size = new System.Drawing.Size(38, 40);
            this.oBtn_Edit.TabIndex = 5;
            this.oBtn_Edit.UseVisualStyleBackColor = true;
            this.oBtn_Edit.Click += new System.EventHandler(this.btn_editmode);
            // 
            // oBtn_Insert
            // 
            this.oBtn_Insert.BackgroundImage = global::TaxiMaxim.WF.Properties.Resources.free_icon_clipboard_1828661;
            this.oBtn_Insert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.oBtn_Insert.Location = new System.Drawing.Point(267, 3);
            this.oBtn_Insert.Name = "oBtn_Insert";
            this.oBtn_Insert.Size = new System.Drawing.Size(38, 40);
            this.oBtn_Insert.TabIndex = 6;
            this.oBtn_Insert.UseVisualStyleBackColor = true;
            // 
            // fLP_driversTools
            // 
            this.fLP_driversTools.Controls.Add(this.dBtn_Add);
            this.fLP_driversTools.Controls.Add(this.dBtn_Remove);
            this.fLP_driversTools.Controls.Add(this.dBtn_Refresh);
            this.fLP_driversTools.Controls.Add(this.dBtn_Find);
            this.fLP_driversTools.Controls.Add(this.dBtn_Sorting);
            this.fLP_driversTools.Controls.Add(this.dBtn_Edit);
            this.fLP_driversTools.Controls.Add(this.dBtn_Insert);
            this.fLP_driversTools.Location = new System.Drawing.Point(11, 118);
            this.fLP_driversTools.Name = "fLP_driversTools";
            this.fLP_driversTools.Size = new System.Drawing.Size(347, 46);
            this.fLP_driversTools.TabIndex = 2;
            // 
            // dBtn_Add
            // 
            this.dBtn_Add.BackgroundImage = global::TaxiMaxim.WF.Properties.Resources.free_icon_plus_1828819;
            this.dBtn_Add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dBtn_Add.Location = new System.Drawing.Point(3, 3);
            this.dBtn_Add.Name = "dBtn_Add";
            this.dBtn_Add.Size = new System.Drawing.Size(38, 40);
            this.dBtn_Add.TabIndex = 0;
            this.dBtn_Add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.dBtn_Add.UseVisualStyleBackColor = true;
            this.dBtn_Add.Click += new System.EventHandler(this.button3_Click);
            // 
            // dBtn_Remove
            // 
            this.dBtn_Remove.BackgroundImage = global::TaxiMaxim.WF.Properties.Resources.free_icon_minus_1828779;
            this.dBtn_Remove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dBtn_Remove.Location = new System.Drawing.Point(47, 3);
            this.dBtn_Remove.Name = "dBtn_Remove";
            this.dBtn_Remove.Size = new System.Drawing.Size(38, 40);
            this.dBtn_Remove.TabIndex = 1;
            this.dBtn_Remove.UseVisualStyleBackColor = true;
            // 
            // dBtn_Refresh
            // 
            this.dBtn_Refresh.BackgroundImage = global::TaxiMaxim.WF.Properties.Resources.free_icon_reload_1828841;
            this.dBtn_Refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dBtn_Refresh.Location = new System.Drawing.Point(91, 3);
            this.dBtn_Refresh.Name = "dBtn_Refresh";
            this.dBtn_Refresh.Size = new System.Drawing.Size(38, 40);
            this.dBtn_Refresh.TabIndex = 2;
            this.dBtn_Refresh.UseVisualStyleBackColor = true;
            // 
            // dBtn_Find
            // 
            this.dBtn_Find.BackgroundImage = global::TaxiMaxim.WF.Properties.Resources.free_icon_search_1828855;
            this.dBtn_Find.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dBtn_Find.Location = new System.Drawing.Point(135, 3);
            this.dBtn_Find.Name = "dBtn_Find";
            this.dBtn_Find.Size = new System.Drawing.Size(38, 40);
            this.dBtn_Find.TabIndex = 3;
            this.dBtn_Find.UseVisualStyleBackColor = true;
            // 
            // dBtn_Sorting
            // 
            this.dBtn_Sorting.BackgroundImage = global::TaxiMaxim.WF.Properties.Resources.free_icon_filter_1828699;
            this.dBtn_Sorting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dBtn_Sorting.Location = new System.Drawing.Point(179, 3);
            this.dBtn_Sorting.Name = "dBtn_Sorting";
            this.dBtn_Sorting.Size = new System.Drawing.Size(38, 40);
            this.dBtn_Sorting.TabIndex = 4;
            this.dBtn_Sorting.UseVisualStyleBackColor = true;
            // 
            // dBtn_Edit
            // 
            this.dBtn_Edit.BackgroundImage = global::TaxiMaxim.WF.Properties.Resources.pencil;
            this.dBtn_Edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dBtn_Edit.Location = new System.Drawing.Point(223, 3);
            this.dBtn_Edit.Name = "dBtn_Edit";
            this.dBtn_Edit.Size = new System.Drawing.Size(38, 40);
            this.dBtn_Edit.TabIndex = 5;
            this.dBtn_Edit.UseVisualStyleBackColor = true;
            this.dBtn_Edit.Click += new System.EventHandler(this.btn_editmode);
            // 
            // dBtn_Insert
            // 
            this.dBtn_Insert.BackgroundImage = global::TaxiMaxim.WF.Properties.Resources.free_icon_clipboard_1828661;
            this.dBtn_Insert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dBtn_Insert.Location = new System.Drawing.Point(267, 3);
            this.dBtn_Insert.Name = "dBtn_Insert";
            this.dBtn_Insert.Size = new System.Drawing.Size(38, 40);
            this.dBtn_Insert.TabIndex = 6;
            this.dBtn_Insert.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.textBox_activeDrivers);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.textBox_activeOrders);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(536, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(702, 74);
            this.panel1.TabIndex = 1;
            // 
            // textBox_activeDrivers
            // 
            this.textBox_activeDrivers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_activeDrivers.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_activeDrivers.Location = new System.Drawing.Point(532, 38);
            this.textBox_activeDrivers.Name = "textBox_activeDrivers";
            this.textBox_activeDrivers.Size = new System.Drawing.Size(170, 32);
            this.textBox_activeDrivers.TabIndex = 3;
            this.textBox_activeDrivers.Text = "NULL";
            this.textBox_activeDrivers.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox4.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox4.Location = new System.Drawing.Point(0, 38);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(533, 32);
            this.textBox4.TabIndex = 2;
            this.textBox4.Text = "Количество активных водителей";
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textBox_activeOrders
            // 
            this.textBox_activeOrders.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_activeOrders.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_activeOrders.Location = new System.Drawing.Point(532, 0);
            this.textBox_activeOrders.Name = "textBox_activeOrders";
            this.textBox_activeOrders.Size = new System.Drawing.Size(170, 32);
            this.textBox_activeOrders.TabIndex = 1;
            this.textBox_activeOrders.Text = "NULL";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(533, 32);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Количество активных заказов:";
            // 
            // dGV_Orders
            // 
            this.dGV_Orders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGV_Orders.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dGV_Orders.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dGV_Orders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_Orders.Location = new System.Drawing.Point(536, 170);
            this.dGV_Orders.Name = "dGV_Orders";
            this.dGV_Orders.ReadOnly = true;
            this.dGV_Orders.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dGV_Orders.RowHeadersWidth = 51;
            this.dGV_Orders.Size = new System.Drawing.Size(702, 486);
            this.dGV_Orders.TabIndex = 0;
            this.dGV_Orders.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.button11);
            this.flowLayoutPanel2.Controls.Add(this.button12);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(502, 341);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(30, 76);
            this.flowLayoutPanel2.TabIndex = 8;
            // 
            // button11
            // 
            this.button11.BackgroundImage = global::TaxiMaxim.WF.Properties.Resources.free_icon_info_1828752;
            this.button11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button11.Location = new System.Drawing.Point(3, 3);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(25, 29);
            this.button11.TabIndex = 0;
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.BackgroundImage = global::TaxiMaxim.WF.Properties.Resources.free_icon_info_1828752;
            this.button12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button12.Location = new System.Drawing.Point(3, 38);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(25, 30);
            this.button12.TabIndex = 1;
            this.button12.UseVisualStyleBackColor = true;
            // 
            // AutoPark
            // 
            this.AutoPark.Controls.Add(this.tableTest);
            this.AutoPark.Location = new System.Drawing.Point(4, 25);
            this.AutoPark.Name = "AutoPark";
            this.AutoPark.Padding = new System.Windows.Forms.Padding(3);
            this.AutoPark.Size = new System.Drawing.Size(1256, 685);
            this.AutoPark.TabIndex = 1;
            this.AutoPark.Text = "Автопарк";
            this.AutoPark.UseVisualStyleBackColor = true;
            // 
            // tableTest
            // 
            this.tableTest.ColumnCount = 2;
            this.tableTest.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableTest.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableTest.Location = new System.Drawing.Point(185, 102);
            this.tableTest.Name = "tableTest";
            this.tableTest.RowCount = 2;
            this.tableTest.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableTest.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableTest.Size = new System.Drawing.Size(388, 234);
            this.tableTest.TabIndex = 0;
            // 
            // HouseBooking
            // 
            this.HouseBooking.Controls.Add(this.panel2);
            this.HouseBooking.Controls.Add(this.dataGridView3);
            this.HouseBooking.Location = new System.Drawing.Point(4, 25);
            this.HouseBooking.Name = "HouseBooking";
            this.HouseBooking.Size = new System.Drawing.Size(1256, 685);
            this.HouseBooking.TabIndex = 2;
            this.HouseBooking.Text = "Домовая книжка";
            this.HouseBooking.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.button21);
            this.panel2.Location = new System.Drawing.Point(437, 109);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(816, 573);
            this.panel2.TabIndex = 2;
            // 
            // button21
            // 
            this.button21.Location = new System.Drawing.Point(738, 547);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(75, 23);
            this.button21.TabIndex = 0;
            this.button21.Text = "button21";
            this.button21.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(8, 109);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.Size = new System.Drawing.Size(423, 573);
            this.dataGridView3.TabIndex = 1;
            this.dataGridView3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSplitButton1,
            this.dataBaseCheck_SLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 739);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1264, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.BackColor = System.Drawing.SystemColors.Menu;
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(78, 17);
            this.toolStripSplitButton1.Text = "База данных:";
            // 
            // dataBaseCheck_SLabel
            // 
            this.dataBaseCheck_SLabel.BackColor = System.Drawing.SystemColors.Control;
            this.dataBaseCheck_SLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dataBaseCheck_SLabel.Name = "dataBaseCheck_SLabel";
            this.dataBaseCheck_SLabel.Size = new System.Drawing.Size(127, 17);
            this.dataBaseCheck_SLabel.Text = "toolStripStatusLabel1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox1,
            this.buttonOrderTaxi});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1264, 25);
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.чтотоToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.ShowDropDownArrow = false;
            this.toolStripComboBox1.Size = new System.Drawing.Size(45, 22);
            this.toolStripComboBox1.Text = "Меню";
            this.toolStripComboBox1.Click += new System.EventHandler(this.toolStripComboBox1_Click);
            // 
            // чтотоToolStripMenuItem
            // 
            this.чтотоToolStripMenuItem.Name = "чтотоToolStripMenuItem";
            this.чтотоToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.чтотоToolStripMenuItem.Text = "Что-то";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // buttonOrderTaxi
            // 
            this.buttonOrderTaxi.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.buttonOrderTaxi.Image = ((System.Drawing.Image)(resources.GetObject("buttonOrderTaxi.Image")));
            this.buttonOrderTaxi.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonOrderTaxi.Name = "buttonOrderTaxi";
            this.buttonOrderTaxi.Size = new System.Drawing.Size(91, 22);
            this.buttonOrderTaxi.Text = "Заказать такси";
            this.buttonOrderTaxi.Click += new System.EventHandler(this.buttonOrderTaxi_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1264, 761);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1280, 800);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ТаксиМаксим";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tabControl1.ResumeLayout(false);
            this.Manager.ResumeLayout(false);
            this.Manager.PerformLayout();
            this.fLP_OrdersIO.ResumeLayout(false);
            this.fLP_driversIO.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_drivers)).EndInit();
            this.fLP_OrdersTools.ResumeLayout(false);
            this.fLP_driversTools.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Orders)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.AutoPark.ResumeLayout(false);
            this.HouseBooking.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dGV_Orders;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Manager;
        private System.Windows.Forms.TabPage AutoPark;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripSplitButton1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripComboBox1;
        private System.Windows.Forms.ToolStripMenuItem чтотоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton buttonOrderTaxi;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox_activeOrders;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStripStatusLabel dataBaseCheck_SLabel;
        private System.Windows.Forms.TextBox textBox_activeDrivers;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.FlowLayoutPanel fLP_driversTools;
        private System.Windows.Forms.Button dBtn_Add;
        private System.Windows.Forms.Button dBtn_Remove;
        private System.Windows.Forms.Button dBtn_Refresh;
        private System.Windows.Forms.Button dBtn_Find;
        private System.Windows.Forms.Button dBtn_Sorting;
        private System.Windows.Forms.Button dBtn_Edit;
        private System.Windows.Forms.Button dBtn_Insert;
        private System.Windows.Forms.DataGridView dGV_drivers;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.TabPage HouseBooking;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableTest;
        private System.Windows.Forms.FlowLayoutPanel fLP_driversIO;
        private System.Windows.Forms.Button dBtn_Apply;
        private System.Windows.Forms.Button dBtn_Cancel;
        private System.Windows.Forms.FlowLayoutPanel fLP_OrdersIO;
        private System.Windows.Forms.Button oBtn_Apply;
        private System.Windows.Forms.Button oBtn_Cancel;
        private System.Windows.Forms.FlowLayoutPanel fLP_OrdersTools;
        private System.Windows.Forms.Button oBtn_Add;
        private System.Windows.Forms.Button oBtnRemove;
        private System.Windows.Forms.Button oBtn_Refresh;
        private System.Windows.Forms.Button oBtn_Find;
        private System.Windows.Forms.Button oBtn_Sorting;
        private System.Windows.Forms.Button oBtn_Edit;
        private System.Windows.Forms.Button oBtn_Insert;
    }
}

