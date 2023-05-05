
namespace TaxiMaxim.WF.InputForms
{
    partial class AddSchedule
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
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.labelErrorDateStart = new System.Windows.Forms.Label();
            this.labelDateStart = new System.Windows.Forms.Label();
            this.labelDateEnd = new System.Windows.Forms.Label();
            this.labelErrorDateEnd = new System.Windows.Forms.Label();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
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
            this.panel1.Location = new System.Drawing.Point(0, 162);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(467, 37);
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
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.Location = new System.Drawing.Point(232, 28);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerStart.TabIndex = 8;
            this.dateTimePickerStart.ValueChanged += new System.EventHandler(this.dateTimePickerStart_ValueChanged);
            // 
            // labelErrorDateStart
            // 
            this.labelErrorDateStart.AutoSize = true;
            this.labelErrorDateStart.ForeColor = System.Drawing.Color.Red;
            this.labelErrorDateStart.Location = new System.Drawing.Point(13, 45);
            this.labelErrorDateStart.Name = "labelErrorDateStart";
            this.labelErrorDateStart.Size = new System.Drawing.Size(79, 13);
            this.labelErrorDateStart.TabIndex = 7;
            this.labelErrorDateStart.Text = "labelErrorName";
            this.labelErrorDateStart.Visible = false;
            // 
            // labelDateStart
            // 
            this.labelDateStart.AutoSize = true;
            this.labelDateStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDateStart.Location = new System.Drawing.Point(13, 28);
            this.labelDateStart.Name = "labelDateStart";
            this.labelDateStart.Size = new System.Drawing.Size(151, 17);
            this.labelDateStart.TabIndex = 6;
            this.labelDateStart.Text = "Дата начала работы:";
            // 
            // labelDateEnd
            // 
            this.labelDateEnd.AutoSize = true;
            this.labelDateEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDateEnd.Location = new System.Drawing.Point(13, 71);
            this.labelDateEnd.Name = "labelDateEnd";
            this.labelDateEnd.Size = new System.Drawing.Size(142, 17);
            this.labelDateEnd.TabIndex = 6;
            this.labelDateEnd.Text = "Дата конца работы:";
            // 
            // labelErrorDateEnd
            // 
            this.labelErrorDateEnd.AutoSize = true;
            this.labelErrorDateEnd.ForeColor = System.Drawing.Color.Red;
            this.labelErrorDateEnd.Location = new System.Drawing.Point(13, 88);
            this.labelErrorDateEnd.Name = "labelErrorDateEnd";
            this.labelErrorDateEnd.Size = new System.Drawing.Size(79, 13);
            this.labelErrorDateEnd.TabIndex = 7;
            this.labelErrorDateEnd.Text = "labelErrorName";
            this.labelErrorDateEnd.Visible = false;
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.Location = new System.Drawing.Point(232, 71);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerEnd.TabIndex = 8;
            this.dateTimePickerEnd.ValueChanged += new System.EventHandler(this.dateTimePickerEnd_ValueChanged);
            // 
            // comboBoxDrivers
            // 
            this.comboBoxDrivers.FormattingEnabled = true;
            this.comboBoxDrivers.Location = new System.Drawing.Point(232, 111);
            this.comboBoxDrivers.Name = "comboBoxDrivers";
            this.comboBoxDrivers.Size = new System.Drawing.Size(164, 21);
            this.comboBoxDrivers.TabIndex = 14;
            this.comboBoxDrivers.SelectedIndexChanged += new System.EventHandler(this.comboBoxDrivers_SelectedIndexChanged);
            // 
            // labelDriver
            // 
            this.labelDriver.AutoSize = true;
            this.labelDriver.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDriver.Location = new System.Drawing.Point(14, 111);
            this.labelDriver.Name = "labelDriver";
            this.labelDriver.Size = new System.Drawing.Size(75, 17);
            this.labelDriver.TabIndex = 12;
            this.labelDriver.Text = "Водитель:";
            // 
            // AddSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 199);
            this.Controls.Add(this.comboBoxDrivers);
            this.Controls.Add(this.labelDriver);
            this.Controls.Add(this.dateTimePickerEnd);
            this.Controls.Add(this.dateTimePickerStart);
            this.Controls.Add(this.labelErrorDateEnd);
            this.Controls.Add(this.labelErrorDateStart);
            this.Controls.Add(this.labelDateEnd);
            this.Controls.Add(this.labelDateStart);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddSchedule";
            this.Text = "AddSchedule";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnDiscard;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.Label labelErrorDateStart;
        private System.Windows.Forms.Label labelDateStart;
        private System.Windows.Forms.Label labelDateEnd;
        private System.Windows.Forms.Label labelErrorDateEnd;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.ComboBox comboBoxDrivers;
        private System.Windows.Forms.Label labelDriver;
    }
}