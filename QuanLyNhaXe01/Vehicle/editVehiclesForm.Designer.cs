namespace QuanLyNhaXe01
{
    partial class editVehiclesForm
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
            this.buttonLoadLicensePlate = new System.Windows.Forms.Button();
            this.radioButtonMoto = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelInTime = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.radioButtonBike = new System.Windows.Forms.RadioButton();
            this.radioButtonCar = new System.Windows.Forms.RadioButton();
            this.pictureBoxLicensePlate = new System.Windows.Forms.PictureBox();
            this.pictureBoxModel = new System.Windows.Forms.PictureBox();
            this.pictureBoxVehiclePicture = new System.Windows.Forms.PictureBox();
            this.buttonLoadModel = new System.Windows.Forms.Button();
            this.pictureBoxUser = new System.Windows.Forms.PictureBox();
            this.buttonLoadUser = new System.Windows.Forms.Button();
            this.buttonLoadVehiclePictrue = new System.Windows.Forms.Button();
            this.dateTimePickerInTime = new System.Windows.Forms.DateTimePicker();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.comboBoxCardID = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonReset = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBoxShape = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.checkBoxStatus = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLicensePlate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxModel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVehiclePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(119, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Card ID:";
            // 
            // buttonLoadLicensePlate
            // 
            this.buttonLoadLicensePlate.BackColor = System.Drawing.Color.SaddleBrown;
            this.buttonLoadLicensePlate.Location = new System.Drawing.Point(698, 357);
            this.buttonLoadLicensePlate.Name = "buttonLoadLicensePlate";
            this.buttonLoadLicensePlate.Size = new System.Drawing.Size(153, 38);
            this.buttonLoadLicensePlate.TabIndex = 2;
            this.buttonLoadLicensePlate.Text = "Upload";
            this.buttonLoadLicensePlate.UseVisualStyleBackColor = false;
            this.buttonLoadLicensePlate.Click += new System.EventHandler(this.buttonLoadLicensePlate_Click);
            // 
            // radioButtonMoto
            // 
            this.radioButtonMoto.AutoSize = true;
            this.radioButtonMoto.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonMoto.Location = new System.Drawing.Point(20, 12);
            this.radioButtonMoto.Name = "radioButtonMoto";
            this.radioButtonMoto.Size = new System.Drawing.Size(177, 33);
            this.radioButtonMoto.TabIndex = 3;
            this.radioButtonMoto.TabStop = true;
            this.radioButtonMoto.Text = "Motorcycle";
            this.radioButtonMoto.UseVisualStyleBackColor = true;
            this.radioButtonMoto.CheckedChanged += new System.EventHandler(this.radioButtonMoto_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(882, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "User:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(866, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Model:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(225, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "Type Of Vehicle:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(490, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(192, 29);
            this.label5.TabIndex = 7;
            this.label5.Text = "License plate:";
            // 
            // labelInTime
            // 
            this.labelInTime.AutoSize = true;
            this.labelInTime.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInTime.Location = new System.Drawing.Point(121, 354);
            this.labelInTime.Name = "labelInTime";
            this.labelInTime.Size = new System.Drawing.Size(123, 29);
            this.labelInTime.TabIndex = 8;
            this.labelInTime.Text = "In Time:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1000, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 20);
            this.label7.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(469, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(213, 29);
            this.label8.TabIndex = 10;
            this.label8.Text = "Vehicle Picture:";
            // 
            // radioButtonBike
            // 
            this.radioButtonBike.AutoSize = true;
            this.radioButtonBike.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonBike.Location = new System.Drawing.Point(20, 92);
            this.radioButtonBike.Name = "radioButtonBike";
            this.radioButtonBike.Size = new System.Drawing.Size(92, 33);
            this.radioButtonBike.TabIndex = 11;
            this.radioButtonBike.TabStop = true;
            this.radioButtonBike.Text = "Bike";
            this.radioButtonBike.UseVisualStyleBackColor = true;
            this.radioButtonBike.CheckedChanged += new System.EventHandler(this.radioButtonBike_CheckedChanged);
            // 
            // radioButtonCar
            // 
            this.radioButtonCar.AutoSize = true;
            this.radioButtonCar.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonCar.Location = new System.Drawing.Point(20, 53);
            this.radioButtonCar.Name = "radioButtonCar";
            this.radioButtonCar.Size = new System.Drawing.Size(82, 33);
            this.radioButtonCar.TabIndex = 12;
            this.radioButtonCar.TabStop = true;
            this.radioButtonCar.Text = "Car";
            this.radioButtonCar.UseVisualStyleBackColor = true;
            this.radioButtonCar.CheckedChanged += new System.EventHandler(this.radioButtonCar_CheckedChanged);
            // 
            // pictureBoxLicensePlate
            // 
            this.pictureBoxLicensePlate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxLicensePlate.Location = new System.Drawing.Point(698, 275);
            this.pictureBoxLicensePlate.Name = "pictureBoxLicensePlate";
            this.pictureBoxLicensePlate.Size = new System.Drawing.Size(153, 76);
            this.pictureBoxLicensePlate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLicensePlate.TabIndex = 14;
            this.pictureBoxLicensePlate.TabStop = false;
            // 
            // pictureBoxModel
            // 
            this.pictureBoxModel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxModel.Location = new System.Drawing.Point(982, 275);
            this.pictureBoxModel.Name = "pictureBoxModel";
            this.pictureBoxModel.Size = new System.Drawing.Size(153, 76);
            this.pictureBoxModel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxModel.TabIndex = 15;
            this.pictureBoxModel.TabStop = false;
            // 
            // pictureBoxVehiclePicture
            // 
            this.pictureBoxVehiclePicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxVehiclePicture.Location = new System.Drawing.Point(698, 102);
            this.pictureBoxVehiclePicture.Name = "pictureBoxVehiclePicture";
            this.pictureBoxVehiclePicture.Size = new System.Drawing.Size(153, 76);
            this.pictureBoxVehiclePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxVehiclePicture.TabIndex = 16;
            this.pictureBoxVehiclePicture.TabStop = false;
            // 
            // buttonLoadModel
            // 
            this.buttonLoadModel.BackColor = System.Drawing.Color.SaddleBrown;
            this.buttonLoadModel.Location = new System.Drawing.Point(982, 357);
            this.buttonLoadModel.Name = "buttonLoadModel";
            this.buttonLoadModel.Size = new System.Drawing.Size(153, 38);
            this.buttonLoadModel.TabIndex = 17;
            this.buttonLoadModel.Text = "Upload";
            this.buttonLoadModel.UseVisualStyleBackColor = false;
            this.buttonLoadModel.Click += new System.EventHandler(this.buttonLoadModel_Click);
            // 
            // pictureBoxUser
            // 
            this.pictureBoxUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxUser.Location = new System.Drawing.Point(982, 102);
            this.pictureBoxUser.Name = "pictureBoxUser";
            this.pictureBoxUser.Size = new System.Drawing.Size(153, 76);
            this.pictureBoxUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxUser.TabIndex = 19;
            this.pictureBoxUser.TabStop = false;
            // 
            // buttonLoadUser
            // 
            this.buttonLoadUser.BackColor = System.Drawing.Color.SaddleBrown;
            this.buttonLoadUser.Location = new System.Drawing.Point(982, 184);
            this.buttonLoadUser.Name = "buttonLoadUser";
            this.buttonLoadUser.Size = new System.Drawing.Size(153, 38);
            this.buttonLoadUser.TabIndex = 20;
            this.buttonLoadUser.Text = "Upload";
            this.buttonLoadUser.UseVisualStyleBackColor = false;
            this.buttonLoadUser.Click += new System.EventHandler(this.buttonLoadUser_Click);
            // 
            // buttonLoadVehiclePictrue
            // 
            this.buttonLoadVehiclePictrue.BackColor = System.Drawing.Color.SaddleBrown;
            this.buttonLoadVehiclePictrue.Location = new System.Drawing.Point(698, 184);
            this.buttonLoadVehiclePictrue.Name = "buttonLoadVehiclePictrue";
            this.buttonLoadVehiclePictrue.Size = new System.Drawing.Size(153, 38);
            this.buttonLoadVehiclePictrue.TabIndex = 21;
            this.buttonLoadVehiclePictrue.Text = "Upload";
            this.buttonLoadVehiclePictrue.UseVisualStyleBackColor = false;
            this.buttonLoadVehiclePictrue.Click += new System.EventHandler(this.buttonLoadVehiclePictrue_Click);
            // 
            // dateTimePickerInTime
            // 
            this.dateTimePickerInTime.Location = new System.Drawing.Point(250, 357);
            this.dateTimePickerInTime.Name = "dateTimePickerInTime";
            this.dateTimePickerInTime.Size = new System.Drawing.Size(344, 26);
            this.dateTimePickerInTime.TabIndex = 22;
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.Blue;
            this.buttonEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEdit.Location = new System.Drawing.Point(293, 539);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(225, 53);
            this.buttonEdit.TabIndex = 23;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Location = new System.Drawing.Point(659, 539);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(225, 53);
            this.buttonCancel.TabIndex = 23;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // comboBoxCardID
            // 
            this.comboBoxCardID.FormattingEnabled = true;
            this.comboBoxCardID.Location = new System.Drawing.Point(270, 102);
            this.comboBoxCardID.Name = "comboBoxCardID";
            this.comboBoxCardID.Size = new System.Drawing.Size(166, 28);
            this.comboBoxCardID.TabIndex = 24;
            this.comboBoxCardID.SelectedIndexChanged += new System.EventHandler(this.comboBoxCardID_SelectedIndexChanged);
           // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.radioButtonCar);
            this.panel1.Controls.Add(this.radioButtonMoto);
            this.panel1.Controls.Add(this.radioButtonBike);
            this.panel1.Location = new System.Drawing.Point(250, 168);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(212, 136);
            this.panel1.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe Script", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label6.Location = new System.Drawing.Point(424, 2);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(311, 67);
            this.label6.TabIndex = 10;
            this.label6.Text = "Edit Vehicles";
            // 
            // buttonReset
            // 
            this.buttonReset.BackColor = System.Drawing.Color.LightSlateGray;
            this.buttonReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReset.Location = new System.Drawing.Point(698, 410);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(437, 43);
            this.buttonReset.TabIndex = 23;
            this.buttonReset.Text = "Reset Data";
            this.buttonReset.UseVisualStyleBackColor = false;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(119, 415);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 29);
            this.label9.TabIndex = 1;
            this.label9.Text = "Shape:";
            // 
            // comboBoxShape
            // 
            this.comboBoxShape.FormattingEnabled = true;
            this.comboBoxShape.Items.AddRange(new object[] {
            "For Hour",
            "For Day",
            "For Week",
            "For Month"});
            this.comboBoxShape.Location = new System.Drawing.Point(250, 420);
            this.comboBoxShape.Name = "comboBoxShape";
            this.comboBoxShape.Size = new System.Drawing.Size(344, 28);
            this.comboBoxShape.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(119, 479);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 29);
            this.label10.TabIndex = 1;
            this.label10.Text = "Status:";
            // 
            // checkBoxStatus
            // 
            this.checkBoxStatus.AutoSize = true;
            this.checkBoxStatus.Checked = true;
            this.checkBoxStatus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxStatus.Location = new System.Drawing.Point(250, 482);
            this.checkBoxStatus.Name = "checkBoxStatus";
            this.checkBoxStatus.Size = new System.Drawing.Size(181, 29);
            this.checkBoxStatus.TabIndex = 26;
            this.checkBoxStatus.Text = "Sending Vehicle";
            this.checkBoxStatus.UseVisualStyleBackColor = true;
            // 
            // editVehiclesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SaddleBrown;
            this.ClientSize = new System.Drawing.Size(1166, 615);
            this.Controls.Add(this.checkBoxStatus);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.comboBoxShape);
            this.Controls.Add(this.comboBoxCardID);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.dateTimePickerInTime);
            this.Controls.Add(this.buttonLoadVehiclePictrue);
            this.Controls.Add(this.buttonLoadUser);
            this.Controls.Add(this.pictureBoxUser);
            this.Controls.Add(this.buttonLoadModel);
            this.Controls.Add(this.pictureBoxVehiclePicture);
            this.Controls.Add(this.pictureBoxModel);
            this.Controls.Add(this.pictureBoxLicensePlate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelInTime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.buttonLoadLicensePlate);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "editVehiclesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Vehicles";
            this.Load += new System.EventHandler(this.editVehiclesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLicensePlate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxModel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVehiclePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonLoadLicensePlate;
        private System.Windows.Forms.RadioButton radioButtonMoto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelInTime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton radioButtonBike;
        private System.Windows.Forms.RadioButton radioButtonCar;
        private System.Windows.Forms.PictureBox pictureBoxLicensePlate;
        private System.Windows.Forms.PictureBox pictureBoxModel;
        private System.Windows.Forms.PictureBox pictureBoxVehiclePicture;
        private System.Windows.Forms.Button buttonLoadModel;
        private System.Windows.Forms.PictureBox pictureBoxUser;
        private System.Windows.Forms.Button buttonLoadUser;
        private System.Windows.Forms.Button buttonLoadVehiclePictrue;
        private System.Windows.Forms.DateTimePicker dateTimePickerInTime;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.ComboBox comboBoxCardID;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBoxShape;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox checkBoxStatus;
    }
}