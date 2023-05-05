
namespace TaxiMaxim.WF.InputForms
{
    partial class AddVehicle
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
            this.labelErrorNumber = new System.Windows.Forms.Label();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.labelNumber = new System.Windows.Forms.Label();
            this.labelErrorBrand = new System.Windows.Forms.Label();
            this.textBoxBrand = new System.Windows.Forms.TextBox();
            this.labelBrand = new System.Windows.Forms.Label();
            this.labelModel = new System.Windows.Forms.Label();
            this.textBoxModel = new System.Windows.Forms.TextBox();
            this.labelErrorModel = new System.Windows.Forms.Label();
            this.labelColor = new System.Windows.Forms.Label();
            this.textBoxColor = new System.Windows.Forms.TextBox();
            this.labelErrorColor = new System.Windows.Forms.Label();
            this.labelDriver = new System.Windows.Forms.Label();
            this.checkBoxDriver = new System.Windows.Forms.CheckBox();
            this.comboBoxDrivers = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnApply);
            this.panel1.Controls.Add(this.btnDiscard);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 246);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(431, 37);
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
            // labelErrorNumber
            // 
            this.labelErrorNumber.AutoSize = true;
            this.labelErrorNumber.ForeColor = System.Drawing.Color.Red;
            this.labelErrorNumber.Location = new System.Drawing.Point(13, 37);
            this.labelErrorNumber.Name = "labelErrorNumber";
            this.labelErrorNumber.Size = new System.Drawing.Size(79, 13);
            this.labelErrorNumber.TabIndex = 8;
            this.labelErrorNumber.Text = "labelErrorName";
            this.labelErrorNumber.Visible = false;
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.Location = new System.Drawing.Point(232, 20);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(128, 20);
            this.textBoxNumber.TabIndex = 6;
            this.textBoxNumber.TextChanged += new System.EventHandler(this.textBoxNumber_TextChanged);
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNumber.Location = new System.Drawing.Point(13, 20);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(138, 17);
            this.labelNumber.TabIndex = 7;
            this.labelNumber.Text = "Гос. номер машины";
            // 
            // labelErrorBrand
            // 
            this.labelErrorBrand.AutoSize = true;
            this.labelErrorBrand.ForeColor = System.Drawing.Color.Red;
            this.labelErrorBrand.Location = new System.Drawing.Point(12, 81);
            this.labelErrorBrand.Name = "labelErrorBrand";
            this.labelErrorBrand.Size = new System.Drawing.Size(79, 13);
            this.labelErrorBrand.TabIndex = 11;
            this.labelErrorBrand.Text = "labelErrorName";
            this.labelErrorBrand.Visible = false;
            // 
            // textBoxBrand
            // 
            this.textBoxBrand.Location = new System.Drawing.Point(231, 64);
            this.textBoxBrand.Name = "textBoxBrand";
            this.textBoxBrand.Size = new System.Drawing.Size(128, 20);
            this.textBoxBrand.TabIndex = 9;
            this.textBoxBrand.TextChanged += new System.EventHandler(this.textBoxBrand_TextChanged);
            // 
            // labelBrand
            // 
            this.labelBrand.AutoSize = true;
            this.labelBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBrand.Location = new System.Drawing.Point(12, 64);
            this.labelBrand.Name = "labelBrand";
            this.labelBrand.Size = new System.Drawing.Size(108, 17);
            this.labelBrand.TabIndex = 10;
            this.labelBrand.Text = "Марка машины";
            // 
            // labelModel
            // 
            this.labelModel.AutoSize = true;
            this.labelModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelModel.Location = new System.Drawing.Point(12, 106);
            this.labelModel.Name = "labelModel";
            this.labelModel.Size = new System.Drawing.Size(58, 17);
            this.labelModel.TabIndex = 10;
            this.labelModel.Text = "Модель";
            // 
            // textBoxModel
            // 
            this.textBoxModel.Location = new System.Drawing.Point(231, 106);
            this.textBoxModel.Name = "textBoxModel";
            this.textBoxModel.Size = new System.Drawing.Size(128, 20);
            this.textBoxModel.TabIndex = 9;
            this.textBoxModel.TextChanged += new System.EventHandler(this.textBoxModel_TextChanged);
            // 
            // labelErrorModel
            // 
            this.labelErrorModel.AutoSize = true;
            this.labelErrorModel.ForeColor = System.Drawing.Color.Red;
            this.labelErrorModel.Location = new System.Drawing.Point(12, 123);
            this.labelErrorModel.Name = "labelErrorModel";
            this.labelErrorModel.Size = new System.Drawing.Size(79, 13);
            this.labelErrorModel.TabIndex = 11;
            this.labelErrorModel.Text = "labelErrorName";
            this.labelErrorModel.Visible = false;
            // 
            // labelColor
            // 
            this.labelColor.AutoSize = true;
            this.labelColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelColor.Location = new System.Drawing.Point(12, 147);
            this.labelColor.Name = "labelColor";
            this.labelColor.Size = new System.Drawing.Size(89, 17);
            this.labelColor.TabIndex = 10;
            this.labelColor.Text = "Цвет кузова";
            // 
            // textBoxColor
            // 
            this.textBoxColor.Location = new System.Drawing.Point(231, 147);
            this.textBoxColor.Name = "textBoxColor";
            this.textBoxColor.Size = new System.Drawing.Size(128, 20);
            this.textBoxColor.TabIndex = 9;
            this.textBoxColor.TextChanged += new System.EventHandler(this.textBoxColor_TextChanged);
            // 
            // labelErrorColor
            // 
            this.labelErrorColor.AutoSize = true;
            this.labelErrorColor.ForeColor = System.Drawing.Color.Red;
            this.labelErrorColor.Location = new System.Drawing.Point(12, 164);
            this.labelErrorColor.Name = "labelErrorColor";
            this.labelErrorColor.Size = new System.Drawing.Size(79, 13);
            this.labelErrorColor.TabIndex = 11;
            this.labelErrorColor.Text = "labelErrorName";
            this.labelErrorColor.Visible = false;
            // 
            // labelDriver
            // 
            this.labelDriver.AutoSize = true;
            this.labelDriver.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDriver.Location = new System.Drawing.Point(12, 192);
            this.labelDriver.Name = "labelDriver";
            this.labelDriver.Size = new System.Drawing.Size(75, 17);
            this.labelDriver.TabIndex = 10;
            this.labelDriver.Text = "Водитель:";
            // 
            // checkBoxDriver
            // 
            this.checkBoxDriver.AutoSize = true;
            this.checkBoxDriver.Location = new System.Drawing.Point(366, 190);
            this.checkBoxDriver.Name = "checkBoxDriver";
            this.checkBoxDriver.Size = new System.Drawing.Size(57, 17);
            this.checkBoxDriver.TabIndex = 13;
            this.checkBoxDriver.Text = "Никто";
            this.checkBoxDriver.UseVisualStyleBackColor = true;
            // 
            // comboBoxDrivers
            // 
            this.comboBoxDrivers.FormattingEnabled = true;
            this.comboBoxDrivers.Location = new System.Drawing.Point(231, 188);
            this.comboBoxDrivers.Name = "comboBoxDrivers";
            this.comboBoxDrivers.Size = new System.Drawing.Size(129, 21);
            this.comboBoxDrivers.TabIndex = 12;
            // 
            // AddVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 283);
            this.Controls.Add(this.checkBoxDriver);
            this.Controls.Add(this.comboBoxDrivers);
            this.Controls.Add(this.labelErrorColor);
            this.Controls.Add(this.labelErrorModel);
            this.Controls.Add(this.labelErrorBrand);
            this.Controls.Add(this.textBoxColor);
            this.Controls.Add(this.textBoxModel);
            this.Controls.Add(this.textBoxBrand);
            this.Controls.Add(this.labelDriver);
            this.Controls.Add(this.labelColor);
            this.Controls.Add(this.labelModel);
            this.Controls.Add(this.labelBrand);
            this.Controls.Add(this.labelErrorNumber);
            this.Controls.Add(this.textBoxNumber);
            this.Controls.Add(this.labelNumber);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddVehicle";
            this.Text = "AddVehicle";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnDiscard;
        private System.Windows.Forms.Label labelErrorNumber;
        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.Label labelNumber;
        private System.Windows.Forms.Label labelErrorBrand;
        private System.Windows.Forms.TextBox textBoxBrand;
        private System.Windows.Forms.Label labelBrand;
        private System.Windows.Forms.Label labelModel;
        private System.Windows.Forms.TextBox textBoxModel;
        private System.Windows.Forms.Label labelErrorModel;
        private System.Windows.Forms.Label labelColor;
        private System.Windows.Forms.TextBox textBoxColor;
        private System.Windows.Forms.Label labelErrorColor;
        private System.Windows.Forms.Label labelDriver;
        private System.Windows.Forms.CheckBox checkBoxDriver;
        private System.Windows.Forms.ComboBox comboBoxDrivers;
    }
}