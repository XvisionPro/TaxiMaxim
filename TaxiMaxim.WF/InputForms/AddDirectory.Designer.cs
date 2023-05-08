
namespace TaxiMaxim.WF.InputForms
{
    partial class AddDirectory
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
            this.labelErrorAStart = new System.Windows.Forms.Label();
            this.textBoxAdressStart = new System.Windows.Forms.TextBox();
            this.labelAdressStart = new System.Windows.Forms.Label();
            this.labelErrorPhone = new System.Windows.Forms.Label();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.labelPhone = new System.Windows.Forms.Label();
            this.checkBoxDriver = new System.Windows.Forms.CheckBox();
            this.comboBoxDrivers = new System.Windows.Forms.ComboBox();
            this.labelDriver = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnApply);
            this.panel1.Controls.Add(this.btnDiscard);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 208);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(495, 37);
            this.panel1.TabIndex = 2;
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
            // labelErrorAStart
            // 
            this.labelErrorAStart.AutoSize = true;
            this.labelErrorAStart.ForeColor = System.Drawing.Color.Red;
            this.labelErrorAStart.Location = new System.Drawing.Point(27, 93);
            this.labelErrorAStart.Name = "labelErrorAStart";
            this.labelErrorAStart.Size = new System.Drawing.Size(79, 13);
            this.labelErrorAStart.TabIndex = 8;
            this.labelErrorAStart.Text = "labelErrorName";
            this.labelErrorAStart.Visible = false;
            // 
            // textBoxAdressStart
            // 
            this.textBoxAdressStart.Location = new System.Drawing.Point(246, 76);
            this.textBoxAdressStart.Multiline = true;
            this.textBoxAdressStart.Name = "textBoxAdressStart";
            this.textBoxAdressStart.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxAdressStart.Size = new System.Drawing.Size(219, 50);
            this.textBoxAdressStart.TabIndex = 6;
            this.textBoxAdressStart.TextChanged += new System.EventHandler(this.textBoxAdressStart_TextChanged);
            // 
            // labelAdressStart
            // 
            this.labelAdressStart.AutoSize = true;
            this.labelAdressStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAdressStart.Location = new System.Drawing.Point(27, 76);
            this.labelAdressStart.Name = "labelAdressStart";
            this.labelAdressStart.Size = new System.Drawing.Size(122, 17);
            this.labelAdressStart.TabIndex = 7;
            this.labelAdressStart.Text = "Домашний адрес";
            // 
            // labelErrorPhone
            // 
            this.labelErrorPhone.AutoSize = true;
            this.labelErrorPhone.ForeColor = System.Drawing.Color.Red;
            this.labelErrorPhone.Location = new System.Drawing.Point(27, 46);
            this.labelErrorPhone.Name = "labelErrorPhone";
            this.labelErrorPhone.Size = new System.Drawing.Size(79, 13);
            this.labelErrorPhone.TabIndex = 11;
            this.labelErrorPhone.Text = "labelErrorName";
            this.labelErrorPhone.Visible = false;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(246, 29);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(128, 20);
            this.textBoxPhone.TabIndex = 9;
            this.textBoxPhone.TextChanged += new System.EventHandler(this.textBoxPhone_TextChanged);
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPhone.Location = new System.Drawing.Point(27, 29);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(121, 17);
            this.labelPhone.TabIndex = 10;
            this.labelPhone.Text = "Номер телефона";
            // 
            // checkBoxDriver
            // 
            this.checkBoxDriver.AutoSize = true;
            this.checkBoxDriver.Location = new System.Drawing.Point(416, 151);
            this.checkBoxDriver.Name = "checkBoxDriver";
            this.checkBoxDriver.Size = new System.Drawing.Size(57, 17);
            this.checkBoxDriver.TabIndex = 15;
            this.checkBoxDriver.Text = "Никто";
            this.checkBoxDriver.UseVisualStyleBackColor = true;
            // 
            // comboBoxDrivers
            // 
            this.comboBoxDrivers.FormattingEnabled = true;
            this.comboBoxDrivers.Location = new System.Drawing.Point(245, 148);
            this.comboBoxDrivers.Name = "comboBoxDrivers";
            this.comboBoxDrivers.Size = new System.Drawing.Size(164, 21);
            this.comboBoxDrivers.TabIndex = 14;
            this.comboBoxDrivers.SelectedIndexChanged += new System.EventHandler(this.comboBoxDrivers_SelectedIndexChanged);
            // 
            // labelDriver
            // 
            this.labelDriver.AutoSize = true;
            this.labelDriver.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDriver.Location = new System.Drawing.Point(27, 148);
            this.labelDriver.Name = "labelDriver";
            this.labelDriver.Size = new System.Drawing.Size(75, 17);
            this.labelDriver.TabIndex = 12;
            this.labelDriver.Text = "Водитель:";
            // 
            // AddDirectory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 245);
            this.Controls.Add(this.checkBoxDriver);
            this.Controls.Add(this.comboBoxDrivers);
            this.Controls.Add(this.labelDriver);
            this.Controls.Add(this.labelErrorPhone);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.labelErrorAStart);
            this.Controls.Add(this.textBoxAdressStart);
            this.Controls.Add(this.labelAdressStart);
            this.Controls.Add(this.panel1);
            this.Name = "AddDirectory";
            this.Text = "AddDirectory";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnDiscard;
        private System.Windows.Forms.Label labelErrorAStart;
        private System.Windows.Forms.TextBox textBoxAdressStart;
        private System.Windows.Forms.Label labelAdressStart;
        private System.Windows.Forms.Label labelErrorPhone;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.CheckBox checkBoxDriver;
        private System.Windows.Forms.ComboBox comboBoxDrivers;
        private System.Windows.Forms.Label labelDriver;
    }
}