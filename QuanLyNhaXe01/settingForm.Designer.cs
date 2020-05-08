namespace QuanLyNhaXe01
{
    partial class settingForm
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
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxFeeMoto = new System.Windows.Forms.TextBox();
            this.textBoxFeeCar = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBoxFeeBike = new System.Windows.Forms.TextBox();
            this.buttonApplyFee = new System.Windows.Forms.Button();
            this.buttonCanceFee = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonCancelSlot = new System.Windows.Forms.Button();
            this.buttonApplySlot = new System.Windows.Forms.Button();
            this.textBoxMotoSlot = new System.Windows.Forms.TextBox();
            this.textBoxBikeSlot = new System.Windows.Forms.TextBox();
            this.textBoxCarSlot = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxTotalSlot = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1026, 521);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label10.Location = new System.Drawing.Point(392, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(181, 58);
            this.label10.TabIndex = 8;
            this.label10.Text = "Setting";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.textBoxFeeMoto);
            this.groupBox2.Controls.Add(this.textBoxFeeCar);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.textBoxFeeBike);
            this.groupBox2.Controls.Add(this.buttonApplyFee);
            this.groupBox2.Controls.Add(this.buttonCanceFee);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(17, 82);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(463, 394);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Setup Fee";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(102, 207);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(54, 25);
            this.label16.TabIndex = 11;
            this.label16.Text = "Car:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(246, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(199, 25);
            this.label9.TabIndex = 10;
            this.label9.Text = "Currency unit: VNĐ";
            // 
            // textBoxFeeMoto
            // 
            this.textBoxFeeMoto.Location = new System.Drawing.Point(195, 131);
            this.textBoxFeeMoto.Name = "textBoxFeeMoto";
            this.textBoxFeeMoto.Size = new System.Drawing.Size(167, 26);
            this.textBoxFeeMoto.TabIndex = 10;
            // 
            // textBoxFeeCar
            // 
            this.textBoxFeeCar.Location = new System.Drawing.Point(195, 206);
            this.textBoxFeeCar.Name = "textBoxFeeCar";
            this.textBoxFeeCar.Size = new System.Drawing.Size(167, 26);
            this.textBoxFeeCar.TabIndex = 12;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(60, 132);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(117, 25);
            this.label15.TabIndex = 9;
            this.label15.Text = "Motocycle:";
            // 
            // textBoxFeeBike
            // 
            this.textBoxFeeBike.Location = new System.Drawing.Point(195, 75);
            this.textBoxFeeBike.Name = "textBoxFeeBike";
            this.textBoxFeeBike.Size = new System.Drawing.Size(167, 26);
            this.textBoxFeeBike.TabIndex = 8;
            // 
            // buttonApplyFee
            // 
            this.buttonApplyFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonApplyFee.Location = new System.Drawing.Point(107, 279);
            this.buttonApplyFee.Name = "buttonApplyFee";
            this.buttonApplyFee.Size = new System.Drawing.Size(89, 41);
            this.buttonApplyFee.TabIndex = 1;
            this.buttonApplyFee.Text = "Apply";
            this.buttonApplyFee.UseVisualStyleBackColor = true;
            this.buttonApplyFee.Click += new System.EventHandler(this.buttonApplyFee_Click);
            // 
            // buttonCanceFee
            // 
            this.buttonCanceFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCanceFee.Location = new System.Drawing.Point(273, 279);
            this.buttonCanceFee.Name = "buttonCanceFee";
            this.buttonCanceFee.Size = new System.Drawing.Size(89, 41);
            this.buttonCanceFee.TabIndex = 9;
            this.buttonCanceFee.Text = "Cancel";
            this.buttonCanceFee.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(89, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Bicycle:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonCancelSlot);
            this.groupBox1.Controls.Add(this.buttonApplySlot);
            this.groupBox1.Controls.Add(this.textBoxMotoSlot);
            this.groupBox1.Controls.Add(this.textBoxBikeSlot);
            this.groupBox1.Controls.Add(this.textBoxCarSlot);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBoxTotalSlot);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(538, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(431, 394);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Setup Slot";
            // 
            // buttonCancelSlot
            // 
            this.buttonCancelSlot.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelSlot.Location = new System.Drawing.Point(265, 311);
            this.buttonCancelSlot.Name = "buttonCancelSlot";
            this.buttonCancelSlot.Size = new System.Drawing.Size(89, 41);
            this.buttonCancelSlot.TabIndex = 18;
            this.buttonCancelSlot.Text = "Cancel";
            this.buttonCancelSlot.UseVisualStyleBackColor = true;
            // 
            // buttonApplySlot
            // 
            this.buttonApplySlot.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonApplySlot.Location = new System.Drawing.Point(68, 311);
            this.buttonApplySlot.Name = "buttonApplySlot";
            this.buttonApplySlot.Size = new System.Drawing.Size(89, 41);
            this.buttonApplySlot.TabIndex = 17;
            this.buttonApplySlot.Text = "Apply";
            this.buttonApplySlot.UseVisualStyleBackColor = true;
            // 
            // textBoxMotoSlot
            // 
            this.textBoxMotoSlot.Location = new System.Drawing.Point(202, 131);
            this.textBoxMotoSlot.Name = "textBoxMotoSlot";
            this.textBoxMotoSlot.Size = new System.Drawing.Size(167, 26);
            this.textBoxMotoSlot.TabIndex = 16;
            // 
            // textBoxBikeSlot
            // 
            this.textBoxBikeSlot.Location = new System.Drawing.Point(202, 192);
            this.textBoxBikeSlot.Name = "textBoxBikeSlot";
            this.textBoxBikeSlot.Size = new System.Drawing.Size(167, 26);
            this.textBoxBikeSlot.TabIndex = 15;
            // 
            // textBoxCarSlot
            // 
            this.textBoxCarSlot.Location = new System.Drawing.Point(202, 246);
            this.textBoxCarSlot.Name = "textBoxCarSlot";
            this.textBoxCarSlot.Size = new System.Drawing.Size(167, 26);
            this.textBoxCarSlot.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(58, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Total Slots:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(92, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "Car Slot";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(40, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "Bicycle Slots:";
            // 
            // textBoxTotalSlot
            // 
            this.textBoxTotalSlot.Location = new System.Drawing.Point(202, 75);
            this.textBoxTotalSlot.Name = "textBoxTotalSlot";
            this.textBoxTotalSlot.Size = new System.Drawing.Size(167, 26);
            this.textBoxTotalSlot.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(18, 131);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(179, 25);
            this.label8.TabIndex = 12;
            this.label8.Text = "Motorcycle Slots:";
            // 
            // settingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(1050, 545);
            this.Controls.Add(this.panel1);
            this.Name = "settingForm";
            this.Text = "Setting Form";
            this.Load += new System.EventHandler(this.settingForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxMotoSlot;
        private System.Windows.Forms.TextBox textBoxBikeSlot;
        private System.Windows.Forms.TextBox textBoxCarSlot;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxTotalSlot;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonCancelSlot;
        private System.Windows.Forms.Button buttonApplySlot;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBoxFeeMoto;
        private System.Windows.Forms.TextBox textBoxFeeCar;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBoxFeeBike;
        private System.Windows.Forms.Button buttonApplyFee;
        private System.Windows.Forms.Button buttonCanceFee;
        private System.Windows.Forms.Label label3;
    }
}