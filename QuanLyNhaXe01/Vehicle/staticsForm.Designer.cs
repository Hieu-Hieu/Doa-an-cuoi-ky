namespace QuanLyNhaXe01
{
    partial class staticsForm
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
            this.labelCar = new System.Windows.Forms.Label();
            this.labelMotorcycle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.labelBike = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelCar
            // 
            this.labelCar.AutoSize = true;
            this.labelCar.BackColor = System.Drawing.Color.Transparent;
            this.labelCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCar.ForeColor = System.Drawing.Color.Navy;
            this.labelCar.Location = new System.Drawing.Point(58, 171);
            this.labelCar.Name = "labelCar";
            this.labelCar.Size = new System.Drawing.Size(108, 37);
            this.labelCar.TabIndex = 1;
            this.labelCar.Text = "label2";
            // 
            // labelMotorcycle
            // 
            this.labelMotorcycle.AutoSize = true;
            this.labelMotorcycle.BackColor = System.Drawing.Color.Transparent;
            this.labelMotorcycle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMotorcycle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelMotorcycle.Location = new System.Drawing.Point(20, 161);
            this.labelMotorcycle.Name = "labelMotorcycle";
            this.labelMotorcycle.Size = new System.Drawing.Size(108, 37);
            this.labelMotorcycle.TabIndex = 2;
            this.labelMotorcycle.Text = "label3";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::QuanLyNhaXe01.Properties.Resources.download;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.labelMotorcycle);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(372, 208);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::QuanLyNhaXe01.Properties.Resources.wfggwg;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.labelCar);
            this.panel2.Location = new System.Drawing.Point(390, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(392, 208);
            this.panel2.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::QuanLyNhaXe01.Properties.Resources.bicycle;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.labelBike);
            this.panel3.Location = new System.Drawing.Point(12, 226);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(372, 279);
            this.panel3.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.labelTotal);
            this.panel4.Location = new System.Drawing.Point(390, 226);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(392, 279);
            this.panel4.TabIndex = 4;
            // 
            // labelBike
            // 
            this.labelBike.AutoSize = true;
            this.labelBike.BackColor = System.Drawing.Color.Transparent;
            this.labelBike.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBike.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.labelBike.Location = new System.Drawing.Point(49, 242);
            this.labelBike.Name = "labelBike";
            this.labelBike.Size = new System.Drawing.Size(106, 37);
            this.labelBike.TabIndex = 3;
            this.labelBike.Text = "label1";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.BackColor = System.Drawing.Color.Transparent;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labelTotal.Location = new System.Drawing.Point(116, 131);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(132, 46);
            this.labelTotal.TabIndex = 2;
            this.labelTotal.Text = "label4";
            // 
            // staticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 517);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "staticsForm";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "staticsForm";
            this.Load += new System.EventHandler(this.staticsForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelCar;
        private System.Windows.Forms.Label labelMotorcycle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label labelBike;
        private System.Windows.Forms.Label labelTotal;
    }
}