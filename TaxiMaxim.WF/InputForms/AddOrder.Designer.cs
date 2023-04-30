
namespace TaxiMaxim.WF.InputForms
{
    partial class AddOrder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnDiscard = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.labelErrorPhone = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.labelAdressStart = new System.Windows.Forms.Label();
            this.labelErrorAStart = new System.Windows.Forms.Label();
            this.textBoxAdressStart = new System.Windows.Forms.TextBox();
            this.labelAdressEnd = new System.Windows.Forms.Label();
            this.textBoxAdressEnd = new System.Windows.Forms.TextBox();
            this.labelErrorAEnd = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.labelErrorPrice = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelErrorDate = new System.Windows.Forms.Label();
            this.comboBoxDrivers = new System.Windows.Forms.ComboBox();
            this.labelDriver = new System.Windows.Forms.Label();
            this.labelErrorDriver = new System.Windows.Forms.Label();
            this.checkBoxDriver = new System.Windows.Forms.CheckBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnApply);
            this.panel1.Controls.Add(this.btnDiscard);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 367);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(534, 37);
            this.panel1.TabIndex = 1;
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(16, 3);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 8;
            this.btnApply.Text = "Создать";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnDiscard
            // 
            this.btnDiscard.Location = new System.Drawing.Point(97, 3);
            this.btnDiscard.Name = "btnDiscard";
            this.btnDiscard.Size = new System.Drawing.Size(75, 23);
            this.btnDiscard.TabIndex = 9;
            this.btnDiscard.Text = "Отмена";
            this.btnDiscard.UseVisualStyleBackColor = true;
            this.btnDiscard.Click += new System.EventHandler(this.btnDiscard_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Создание заказа";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPhone.Location = new System.Drawing.Point(44, 51);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(193, 17);
            this.labelPhone.TabIndex = 3;
            this.labelPhone.Text = "Номер телефона заказчика";
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(263, 51);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(128, 20);
            this.textBoxPhone.TabIndex = 0;
            this.textBoxPhone.TextChanged += new System.EventHandler(this.textBoxPhone_TextChanged);
            // 
            // labelErrorPhone
            // 
            this.labelErrorPhone.AutoSize = true;
            this.labelErrorPhone.ForeColor = System.Drawing.Color.Red;
            this.labelErrorPhone.Location = new System.Drawing.Point(44, 68);
            this.labelErrorPhone.Name = "labelErrorPhone";
            this.labelErrorPhone.Size = new System.Drawing.Size(79, 13);
            this.labelErrorPhone.TabIndex = 5;
            this.labelErrorPhone.Text = "labelErrorName";
            this.labelErrorPhone.Visible = false;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(407, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Проверить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelAdressStart
            // 
            this.labelAdressStart.AutoSize = true;
            this.labelAdressStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAdressStart.Location = new System.Drawing.Point(44, 96);
            this.labelAdressStart.Name = "labelAdressStart";
            this.labelAdressStart.Size = new System.Drawing.Size(126, 17);
            this.labelAdressStart.TabIndex = 3;
            this.labelAdressStart.Text = "Начальный адрес";
            // 
            // labelErrorAStart
            // 
            this.labelErrorAStart.AutoSize = true;
            this.labelErrorAStart.ForeColor = System.Drawing.Color.Red;
            this.labelErrorAStart.Location = new System.Drawing.Point(44, 113);
            this.labelErrorAStart.Name = "labelErrorAStart";
            this.labelErrorAStart.Size = new System.Drawing.Size(79, 13);
            this.labelErrorAStart.TabIndex = 5;
            this.labelErrorAStart.Text = "labelErrorName";
            this.labelErrorAStart.Visible = false;
            // 
            // textBoxAdressStart
            // 
            this.textBoxAdressStart.Location = new System.Drawing.Point(263, 96);
            this.textBoxAdressStart.Multiline = true;
            this.textBoxAdressStart.Name = "textBoxAdressStart";
            this.textBoxAdressStart.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxAdressStart.Size = new System.Drawing.Size(219, 50);
            this.textBoxAdressStart.TabIndex = 2;
            this.textBoxAdressStart.TextChanged += new System.EventHandler(this.textBoxAdressStart_TextChanged);
            // 
            // labelAdressEnd
            // 
            this.labelAdressEnd.AutoSize = true;
            this.labelAdressEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAdressEnd.Location = new System.Drawing.Point(44, 157);
            this.labelAdressEnd.Name = "labelAdressEnd";
            this.labelAdressEnd.Size = new System.Drawing.Size(118, 17);
            this.labelAdressEnd.TabIndex = 3;
            this.labelAdressEnd.Text = "Конечный адрес";
            // 
            // textBoxAdressEnd
            // 
            this.textBoxAdressEnd.Location = new System.Drawing.Point(263, 157);
            this.textBoxAdressEnd.Multiline = true;
            this.textBoxAdressEnd.Name = "textBoxAdressEnd";
            this.textBoxAdressEnd.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxAdressEnd.Size = new System.Drawing.Size(219, 50);
            this.textBoxAdressEnd.TabIndex = 3;
            this.textBoxAdressEnd.TextChanged += new System.EventHandler(this.textBoxAdressEnd_TextChanged);
            // 
            // labelErrorAEnd
            // 
            this.labelErrorAEnd.AutoSize = true;
            this.labelErrorAEnd.ForeColor = System.Drawing.Color.Red;
            this.labelErrorAEnd.Location = new System.Drawing.Point(44, 174);
            this.labelErrorAEnd.Name = "labelErrorAEnd";
            this.labelErrorAEnd.Size = new System.Drawing.Size(79, 13);
            this.labelErrorAEnd.TabIndex = 5;
            this.labelErrorAEnd.Text = "labelErrorName";
            this.labelErrorAEnd.Visible = false;
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPrice.Location = new System.Drawing.Point(44, 222);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(105, 17);
            this.labelPrice.TabIndex = 3;
            this.labelPrice.Text = "Цена поездки:";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(263, 222);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(128, 20);
            this.textBoxPrice.TabIndex = 4;
            this.textBoxPrice.TextChanged += new System.EventHandler(this.textBoxPrice_TextChanged);
            // 
            // labelErrorPrice
            // 
            this.labelErrorPrice.AutoSize = true;
            this.labelErrorPrice.ForeColor = System.Drawing.Color.Red;
            this.labelErrorPrice.Location = new System.Drawing.Point(44, 239);
            this.labelErrorPrice.Name = "labelErrorPrice";
            this.labelErrorPrice.Size = new System.Drawing.Size(79, 13);
            this.labelErrorPrice.TabIndex = 5;
            this.labelErrorPrice.Text = "labelErrorName";
            this.labelErrorPrice.Visible = false;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDate.Location = new System.Drawing.Point(44, 264);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(104, 17);
            this.labelDate.TabIndex = 3;
            this.labelDate.Text = "Дата поездки:";
            // 
            // labelErrorDate
            // 
            this.labelErrorDate.AutoSize = true;
            this.labelErrorDate.ForeColor = System.Drawing.Color.Red;
            this.labelErrorDate.Location = new System.Drawing.Point(44, 281);
            this.labelErrorDate.Name = "labelErrorDate";
            this.labelErrorDate.Size = new System.Drawing.Size(79, 13);
            this.labelErrorDate.TabIndex = 5;
            this.labelErrorDate.Text = "labelErrorName";
            this.labelErrorDate.Visible = false;
            // 
            // comboBoxDrivers
            // 
            this.comboBoxDrivers.FormattingEnabled = true;
            this.comboBoxDrivers.Location = new System.Drawing.Point(263, 306);
            this.comboBoxDrivers.Name = "comboBoxDrivers";
            this.comboBoxDrivers.Size = new System.Drawing.Size(164, 21);
            this.comboBoxDrivers.TabIndex = 6;
            // 
            // labelDriver
            // 
            this.labelDriver.AutoSize = true;
            this.labelDriver.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDriver.Location = new System.Drawing.Point(45, 306);
            this.labelDriver.Name = "labelDriver";
            this.labelDriver.Size = new System.Drawing.Size(75, 17);
            this.labelDriver.TabIndex = 3;
            this.labelDriver.Text = "Водитель:";
            // 
            // labelErrorDriver
            // 
            this.labelErrorDriver.AutoSize = true;
            this.labelErrorDriver.ForeColor = System.Drawing.Color.Red;
            this.labelErrorDriver.Location = new System.Drawing.Point(45, 323);
            this.labelErrorDriver.Name = "labelErrorDriver";
            this.labelErrorDriver.Size = new System.Drawing.Size(79, 13);
            this.labelErrorDriver.TabIndex = 5;
            this.labelErrorDriver.Text = "labelErrorName";
            this.labelErrorDriver.Visible = false;
            // 
            // checkBoxDriver
            // 
            this.checkBoxDriver.AutoSize = true;
            this.checkBoxDriver.Location = new System.Drawing.Point(434, 309);
            this.checkBoxDriver.Name = "checkBoxDriver";
            this.checkBoxDriver.Size = new System.Drawing.Size(57, 17);
            this.checkBoxDriver.TabIndex = 7;
            this.checkBoxDriver.Text = "Нкито";
            this.checkBoxDriver.UseVisualStyleBackColor = true;
            this.checkBoxDriver.CheckedChanged += new System.EventHandler(this.checkBoxDriver_CheckedChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(263, 264);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 5;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // AddOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 404);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.checkBoxDriver);
            this.Controls.Add(this.comboBoxDrivers);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelErrorAEnd);
            this.Controls.Add(this.labelErrorAStart);
            this.Controls.Add(this.labelErrorDriver);
            this.Controls.Add(this.labelErrorDate);
            this.Controls.Add(this.labelErrorPrice);
            this.Controls.Add(this.labelErrorPhone);
            this.Controls.Add(this.textBoxAdressEnd);
            this.Controls.Add(this.textBoxAdressStart);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.labelDriver);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelAdressEnd);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelAdressStart);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddOrder";
            this.Text = "AddOrder";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnDiscard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.Label labelErrorPhone;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelAdressStart;
        private System.Windows.Forms.Label labelErrorAStart;
        private System.Windows.Forms.TextBox textBoxAdressStart;
        private System.Windows.Forms.Label labelAdressEnd;
        private System.Windows.Forms.TextBox textBoxAdressEnd;
        private System.Windows.Forms.Label labelErrorAEnd;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label labelErrorPrice;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelErrorDate;
        private System.Windows.Forms.ComboBox comboBoxDrivers;
        private System.Windows.Forms.Label labelDriver;
        private System.Windows.Forms.Label labelErrorDriver;
        private System.Windows.Forms.CheckBox checkBoxDriver;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}