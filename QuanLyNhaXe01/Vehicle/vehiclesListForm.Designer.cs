namespace QuanLyNhaXe01
{
    partial class vehiclesListForm
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.comboBoxTypeVehicle = new System.Windows.Forms.ComboBox();
            this.xeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetQuanLyNhaXe = new QuanLyNhaXe01.DataSetQuanLyNhaXe();
            this.label1 = new System.Windows.Forms.Label();
            this.xeTableAdapter = new QuanLyNhaXe01.DataSetQuanLyNhaXeTableAdapters.XeTableAdapter();
            this.labelTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetQuanLyNhaXe)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(32, 91);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1218, 490);
            this.dataGridView1.TabIndex = 0;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonRefresh.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonRefresh.Location = new System.Drawing.Point(393, 615);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(181, 52);
            this.buttonRefresh.TabIndex = 1;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = false;
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonDelete.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonDelete.Location = new System.Drawing.Point(785, 615);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(173, 52);
            this.buttonDelete.TabIndex = 2;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // comboBoxTypeVehicle
            // 
            this.comboBoxTypeVehicle.FormattingEnabled = true;
            this.comboBoxTypeVehicle.Items.AddRange(new object[] {
            "Xe May",
            "Xe Dap",
            "Xe Hoi",
            "Tat Ca"});
            this.comboBoxTypeVehicle.Location = new System.Drawing.Point(271, 20);
            this.comboBoxTypeVehicle.Name = "comboBoxTypeVehicle";
            this.comboBoxTypeVehicle.Size = new System.Drawing.Size(223, 28);
            this.comboBoxTypeVehicle.TabIndex = 3;
            this.comboBoxTypeVehicle.SelectedIndexChanged += new System.EventHandler(this.comboBoxTypeVehicle_SelectedIndexChanged);
            // 
            // xeBindingSource
            // 
            this.xeBindingSource.DataMember = "Xe";
            this.xeBindingSource.DataSource = this.dataSetQuanLyNhaXe;
            // 
            // dataSetQuanLyNhaXe
            // 
            this.dataSetQuanLyNhaXe.DataSetName = "DataSetQuanLyNhaXe";
            this.dataSetQuanLyNhaXe.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(47, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Type Of Vehicle:";
            // 
            // xeTableAdapter
            // 
            this.xeTableAdapter.ClearBeforeFill = true;
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelTotal.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelTotal.Location = new System.Drawing.Point(878, 46);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(80, 29);
            this.labelTotal.TabIndex = 5;
            this.labelTotal.Text = "Total: ";
            // 
            // vehiclesListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1294, 696);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxTypeVehicle);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.dataGridView1);
            this.Name = "vehiclesListForm";
            this.Text = "VehicleList";
            this.Load += new System.EventHandler(this.vehiclesListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetQuanLyNhaXe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.ComboBox comboBoxTypeVehicle;
        private System.Windows.Forms.Label label1;
        private DataSetQuanLyNhaXe dataSetQuanLyNhaXe;
        private System.Windows.Forms.BindingSource xeBindingSource;
        private DataSetQuanLyNhaXeTableAdapters.XeTableAdapter xeTableAdapter;
        private System.Windows.Forms.Label labelTotal;
    }
}