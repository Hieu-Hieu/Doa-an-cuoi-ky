namespace QuanLyNhaXe01
{
    partial class manageVehiclesForm
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
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridVManageVehicle = new System.Windows.Forms.DataGridView();
            this.buttonPay = new System.Windows.Forms.Button();
            this.comboBoxTypeVehicle = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxSearchLicenPlate = new System.Windows.Forms.TextBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.labelDaRa = new System.Windows.Forms.Label();
            this.labelDangGui = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVManageVehicle)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(527, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 29);
            this.label6.TabIndex = 5;
            this.label6.Text = "Search:";
            // 
            // dataGridVManageVehicle
            // 
            this.dataGridVManageVehicle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridVManageVehicle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridVManageVehicle.Location = new System.Drawing.Point(18, 102);
            this.dataGridVManageVehicle.Name = "dataGridVManageVehicle";
            this.dataGridVManageVehicle.RowHeadersWidth = 62;
            this.dataGridVManageVehicle.RowTemplate.Height = 28;
            this.dataGridVManageVehicle.Size = new System.Drawing.Size(1446, 501);
            this.dataGridVManageVehicle.TabIndex = 0;
            this.dataGridVManageVehicle.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridVManageVehicle_DataError);
            // 
            // buttonPay
            // 
            this.buttonPay.BackColor = System.Drawing.Color.Green;
            this.buttonPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPay.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonPay.Location = new System.Drawing.Point(1250, 20);
            this.buttonPay.Name = "buttonPay";
            this.buttonPay.Size = new System.Drawing.Size(214, 57);
            this.buttonPay.TabIndex = 9;
            this.buttonPay.Text = "Pay";
            this.buttonPay.UseVisualStyleBackColor = false;
            this.buttonPay.Click += new System.EventHandler(this.buttonPay_Click);
            // 
            // comboBoxTypeVehicle
            // 
            this.comboBoxTypeVehicle.FormattingEnabled = true;
            this.comboBoxTypeVehicle.Location = new System.Drawing.Point(226, 35);
            this.comboBoxTypeVehicle.Name = "comboBoxTypeVehicle";
            this.comboBoxTypeVehicle.Size = new System.Drawing.Size(227, 28);
            this.comboBoxTypeVehicle.TabIndex = 8;
            this.comboBoxTypeVehicle.SelectedIndexChanged += new System.EventHandler(this.comboBoxTypeVehicle_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Type of vehicle:";
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.Crimson;
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonDelete.Location = new System.Drawing.Point(762, 692);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(217, 66);
            this.buttonDelete.TabIndex = 7;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.DarkCyan;
            this.buttonEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEdit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonEdit.Location = new System.Drawing.Point(452, 692);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(216, 66);
            this.buttonEdit.TabIndex = 0;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.Green;
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonAdd.Location = new System.Drawing.Point(146, 692);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(216, 66);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxSearchLicenPlate
            // 
            this.textBoxSearchLicenPlate.Location = new System.Drawing.Point(635, 38);
            this.textBoxSearchLicenPlate.Name = "textBoxSearchLicenPlate";
            this.textBoxSearchLicenPlate.Size = new System.Drawing.Size(344, 26);
            this.textBoxSearchLicenPlate.TabIndex = 6;
            this.textBoxSearchLicenPlate.TextChanged += new System.EventHandler(this.textBoxSearchLicenPlate_TextChanged);
            // 
            // labelStatus
            // 
            this.labelStatus.BackColor = System.Drawing.Color.Purple;
            this.labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelStatus.Location = new System.Drawing.Point(1189, 606);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(275, 60);
            this.labelStatus.TabIndex = 2;
            this.labelStatus.Text = "Status";
            this.labelStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelStatus.Click += new System.EventHandler(this.labelStatus_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.BackColor = System.Drawing.Color.Blue;
            this.buttonRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRefresh.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonRefresh.Location = new System.Drawing.Point(1029, 20);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(184, 57);
            this.buttonRefresh.TabIndex = 0;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = false;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // labelDaRa
            // 
            this.labelDaRa.BackColor = System.Drawing.Color.Purple;
            this.labelDaRa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDaRa.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelDaRa.Location = new System.Drawing.Point(908, 606);
            this.labelDaRa.Name = "labelDaRa";
            this.labelDaRa.Size = new System.Drawing.Size(275, 60);
            this.labelDaRa.TabIndex = 10;
            this.labelDaRa.Text = "Status";
            this.labelDaRa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDangGui
            // 
            this.labelDangGui.BackColor = System.Drawing.Color.Purple;
            this.labelDangGui.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDangGui.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelDangGui.Location = new System.Drawing.Point(627, 606);
            this.labelDangGui.Name = "labelDangGui";
            this.labelDangGui.Size = new System.Drawing.Size(275, 60);
            this.labelDangGui.TabIndex = 11;
            this.labelDangGui.Text = "Status";
            this.labelDangGui.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // manageVehiclesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1476, 787);
            this.Controls.Add(this.labelDangGui);
            this.Controls.Add(this.labelDaRa);
            this.Controls.Add(this.buttonPay);
            this.Controls.Add(this.dataGridVManageVehicle);
            this.Controls.Add(this.comboBoxTypeVehicle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.textBoxSearchLicenPlate);
            this.Name = "manageVehiclesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Vehicles";
            this.Load += new System.EventHandler(this.manageVehiclesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVManageVehicle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridVManageVehicle;
        private System.Windows.Forms.TextBox textBoxSearchLicenPlate;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ComboBox comboBoxTypeVehicle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonPay;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Label labelDaRa;
        private System.Windows.Forms.Label labelDangGui;
    }
}