namespace QuanLyNhaXe01
{
    partial class revenueForm
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
            this.dataGridViewShowData = new System.Windows.Forms.DataGridView();
            this.buttonShowVehicles = new System.Windows.Forms.Button();
            this.buttonShowRevenue = new System.Windows.Forms.Button();
            this.buttonExport = new System.Windows.Forms.Button();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowData)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewShowData
            // 
            this.dataGridViewShowData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewShowData.Location = new System.Drawing.Point(12, 195);
            this.dataGridViewShowData.Name = "dataGridViewShowData";
            this.dataGridViewShowData.RowHeadersWidth = 62;
            this.dataGridViewShowData.RowTemplate.Height = 28;
            this.dataGridViewShowData.Size = new System.Drawing.Size(1233, 445);
            this.dataGridViewShowData.TabIndex = 0;
            this.dataGridViewShowData.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridViewShowData_DataError);
            // 
            // buttonShowVehicles
            // 
            this.buttonShowVehicles.Location = new System.Drawing.Point(304, 133);
            this.buttonShowVehicles.Name = "buttonShowVehicles";
            this.buttonShowVehicles.Size = new System.Drawing.Size(197, 35);
            this.buttonShowVehicles.TabIndex = 1;
            this.buttonShowVehicles.Text = "Show Vehicles";
            this.buttonShowVehicles.UseVisualStyleBackColor = true;
            this.buttonShowVehicles.Click += new System.EventHandler(this.buttonShowVehicles_Click);
            // 
            // buttonShowRevenue
            // 
            this.buttonShowRevenue.Location = new System.Drawing.Point(851, 133);
            this.buttonShowRevenue.Name = "buttonShowRevenue";
            this.buttonShowRevenue.Size = new System.Drawing.Size(303, 35);
            this.buttonShowRevenue.TabIndex = 1;
            this.buttonShowRevenue.Text = "Show Revenue";
            this.buttonShowRevenue.UseVisualStyleBackColor = true;
            this.buttonShowRevenue.Click += new System.EventHandler(this.buttonShowRevenue_Click);
            // 
            // buttonExport
            // 
            this.buttonExport.Location = new System.Drawing.Point(318, 670);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(197, 35);
            this.buttonExport.TabIndex = 1;
            this.buttonExport.Text = "Export";
            this.buttonExport.UseVisualStyleBackColor = true;
            this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
            // 
            // buttonPrint
            // 
            this.buttonPrint.Location = new System.Drawing.Point(721, 670);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(197, 35);
            this.buttonPrint.TabIndex = 1;
            this.buttonPrint.Text = "Print";
            this.buttonPrint.UseVisualStyleBackColor = true;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFrom.Location = new System.Drawing.Point(506, 65);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(135, 26);
            this.dateTimePickerFrom.TabIndex = 2;
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerTo.Location = new System.Drawing.Point(721, 65);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(144, 26);
            this.dateTimePickerTo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(367, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Range From:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(663, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "To";
            // 
            // revenueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1257, 730);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePickerFrom);
            this.Controls.Add(this.dateTimePickerTo);
            this.Controls.Add(this.buttonPrint);
            this.Controls.Add(this.buttonShowRevenue);
            this.Controls.Add(this.buttonExport);
            this.Controls.Add(this.buttonShowVehicles);
            this.Controls.Add(this.dataGridViewShowData);
            this.Name = "revenueForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Revenue";
            this.Load += new System.EventHandler(this.revenueForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewShowData;
        private System.Windows.Forms.Button buttonShowVehicles;
        private System.Windows.Forms.Button buttonShowRevenue;
        private System.Windows.Forms.Button buttonExport;
        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}