
namespace TaxiMaxim.WF.InputForms
{
    partial class Find
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
            this.labelErrorFind = new System.Windows.Forms.Label();
            this.labelFind = new System.Windows.Forms.Label();
            this.textBoxFind = new System.Windows.Forms.TextBox();
            this.labelWhere = new System.Windows.Forms.Label();
            this.comboBoxWhere = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnApply);
            this.panel1.Controls.Add(this.btnDiscard);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 150);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(434, 37);
            this.panel1.TabIndex = 2;
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(16, 3);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 8;
            this.btnApply.Text = "Поиск";
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
            // labelErrorFind
            // 
            this.labelErrorFind.AutoSize = true;
            this.labelErrorFind.ForeColor = System.Drawing.Color.Red;
            this.labelErrorFind.Location = new System.Drawing.Point(24, 46);
            this.labelErrorFind.Name = "labelErrorFind";
            this.labelErrorFind.Size = new System.Drawing.Size(79, 13);
            this.labelErrorFind.TabIndex = 7;
            this.labelErrorFind.Text = "labelErrorName";
            this.labelErrorFind.Visible = false;
            // 
            // labelFind
            // 
            this.labelFind.AutoSize = true;
            this.labelFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFind.Location = new System.Drawing.Point(24, 29);
            this.labelFind.Name = "labelFind";
            this.labelFind.Size = new System.Drawing.Size(52, 17);
            this.labelFind.TabIndex = 6;
            this.labelFind.Text = "Поиск:";
            // 
            // textBoxFind
            // 
            this.textBoxFind.Location = new System.Drawing.Point(156, 28);
            this.textBoxFind.Multiline = true;
            this.textBoxFind.Name = "textBoxFind";
            this.textBoxFind.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxFind.Size = new System.Drawing.Size(219, 50);
            this.textBoxFind.TabIndex = 8;
            this.textBoxFind.TextChanged += new System.EventHandler(this.textBoxFind_TextChanged);
            // 
            // labelWhere
            // 
            this.labelWhere.AutoSize = true;
            this.labelWhere.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWhere.Location = new System.Drawing.Point(24, 88);
            this.labelWhere.Name = "labelWhere";
            this.labelWhere.Size = new System.Drawing.Size(79, 17);
            this.labelWhere.TabIndex = 6;
            this.labelWhere.Text = "В столбце:";
            // 
            // comboBoxWhere
            // 
            this.comboBoxWhere.FormattingEnabled = true;
            this.comboBoxWhere.Location = new System.Drawing.Point(156, 88);
            this.comboBoxWhere.Name = "comboBoxWhere";
            this.comboBoxWhere.Size = new System.Drawing.Size(219, 21);
            this.comboBoxWhere.TabIndex = 9;
            this.comboBoxWhere.SelectedIndexChanged += new System.EventHandler(this.comboBoxWhere_SelectedIndexChanged);
            // 
            // Find
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 187);
            this.Controls.Add(this.comboBoxWhere);
            this.Controls.Add(this.textBoxFind);
            this.Controls.Add(this.labelWhere);
            this.Controls.Add(this.labelErrorFind);
            this.Controls.Add(this.labelFind);
            this.Controls.Add(this.panel1);
            this.Name = "Find";
            this.Text = "Find";
            this.Load += new System.EventHandler(this.Find_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnDiscard;
        private System.Windows.Forms.Label labelErrorFind;
        private System.Windows.Forms.Label labelFind;
        private System.Windows.Forms.TextBox textBoxFind;
        private System.Windows.Forms.Label labelWhere;
        private System.Windows.Forms.ComboBox comboBoxWhere;
    }
}