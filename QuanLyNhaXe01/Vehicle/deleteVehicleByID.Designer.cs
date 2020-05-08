namespace QuanLyNhaXe01
{
    partial class deleteVehicleByID
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.labelCardID = new System.Windows.Forms.Label();
            this.labelTypeOfVehicle = new System.Windows.Forms.Label();
            this.labelInTime = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxID = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(46, 252);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Card ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(394, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Type Of Vehicle:";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label.Location = new System.Drawing.Point(47, 323);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(100, 29);
            this.label.TabIndex = 23;
            this.label.Text = "In Time:";
            // 
            // labelCardID
            // 
            this.labelCardID.AutoSize = true;
            this.labelCardID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelCardID.Location = new System.Drawing.Point(173, 252);
            this.labelCardID.Name = "labelCardID";
            this.labelCardID.Size = new System.Drawing.Size(66, 29);
            this.labelCardID.TabIndex = 26;
            this.labelCardID.Text = "label";
            // 
            // labelTypeOfVehicle
            // 
            this.labelTypeOfVehicle.AutoSize = true;
            this.labelTypeOfVehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelTypeOfVehicle.Location = new System.Drawing.Point(591, 252);
            this.labelTypeOfVehicle.Name = "labelTypeOfVehicle";
            this.labelTypeOfVehicle.Size = new System.Drawing.Size(66, 29);
            this.labelTypeOfVehicle.TabIndex = 27;
            this.labelTypeOfVehicle.Text = "label";
            // 
            // labelInTime
            // 
            this.labelInTime.AutoSize = true;
            this.labelInTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelInTime.Location = new System.Drawing.Point(265, 323);
            this.labelInTime.Name = "labelInTime";
            this.labelInTime.Size = new System.Drawing.Size(66, 29);
            this.labelInTime.TabIndex = 28;
            this.labelInTime.Text = "label";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Location = new System.Drawing.Point(5, 206);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(740, 23);
            this.panel1.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(23, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 29);
            this.label3.TabIndex = 26;
            this.label3.Text = "Select Vehicle ID:";
            // 
            // comboBoxID
            // 
            this.comboBoxID.FormattingEnabled = true;
            this.comboBoxID.Location = new System.Drawing.Point(232, 142);
            this.comboBoxID.Name = "comboBoxID";
            this.comboBoxID.Size = new System.Drawing.Size(250, 28);
            this.comboBoxID.TabIndex = 34;
            this.comboBoxID.SelectionChangeCommitted += new System.EventHandler(this.comboBoxID_SelectionChangeCommitted);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("VNI-Present", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(222, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(289, 56);
            this.label4.TabIndex = 26;
            this.label4.Text = "Delete Vehicle";
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.Red;
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonDelete.Location = new System.Drawing.Point(531, 125);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(154, 52);
            this.buttonDelete.TabIndex = 35;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.SaddleBrown;
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonExit.Location = new System.Drawing.Point(531, 311);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(154, 52);
            this.buttonExit.TabIndex = 35;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // deleteVehicleByID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 386);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.comboBoxID);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelInTime);
            this.Controls.Add(this.labelTypeOfVehicle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelCardID);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "deleteVehicleByID";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "paymentForm";
            this.Load += new System.EventHandler(this.deleteVehicleByID_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label labelCardID;
        private System.Windows.Forms.Label labelTypeOfVehicle;
        private System.Windows.Forms.Label labelInTime;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonExit;
    }
}