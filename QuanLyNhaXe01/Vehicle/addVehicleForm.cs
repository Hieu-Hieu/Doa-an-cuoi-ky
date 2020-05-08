using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyNhaXe01
{
    public partial class addVehicleForm : Form
    {
        public addVehicleForm()
        {
            InitializeComponent();
        }

        private void radioButtonCar_CheckedChanged_1(object sender, EventArgs e)
        {
            buttonLoadUser.Enabled = false;
            buttonLoadVehiclePictrue.Enabled = false;
            buttonLoadModel.Enabled = true;
            buttonLoadLicensePlate.Enabled = true;

            buttonLoadModel.BackColor = Color.Aqua;
            buttonLoadLicensePlate.BackColor = Color.Aqua;
            buttonLoadUser.BackColor = Color.White;
            buttonLoadVehiclePictrue.BackColor = Color.White;
        }

        private void radioButtonMoto_CheckedChanged(object sender, EventArgs e)
        {
            buttonLoadModel.Enabled = false;
            buttonLoadVehiclePictrue.Enabled = false;
            buttonLoadUser.Enabled = true;
            buttonLoadLicensePlate.Enabled = true;

            buttonLoadUser.BackColor = Color.Aqua;
            buttonLoadLicensePlate.BackColor = Color.Aqua;
            buttonLoadModel.BackColor = Color.White;
            buttonLoadVehiclePictrue.BackColor = Color.White;
        }

        private void radioButtonBike_CheckedChanged(object sender, EventArgs e)
        {
            buttonLoadLicensePlate.Enabled = false;
            buttonLoadModel.Enabled = false;
            buttonLoadVehiclePictrue.Enabled = true;
            buttonLoadUser.Enabled = true;

            buttonLoadVehiclePictrue.BackColor = Color.Aqua;
            buttonLoadUser.BackColor = Color.Aqua;
            buttonLoadModel.BackColor = Color.White;
            buttonLoadLicensePlate.BackColor = Color.White;
        }

        private void buttonLoadModel_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if ((opf.ShowDialog() == DialogResult.OK))
            {
                pictureBoxModel.Image = Image.FromFile(opf.FileName);
            }

        }

        // Kiểm tra dữ liệu
        bool verifCar()
        {
            if (pictureBoxLicensePlate.Image == null
                || pictureBoxModel.Image == null
                || textBoxCardID.Text == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        bool verifBike()
        {
            if (pictureBoxVehiclePicture.Image == null
                || pictureBoxUser.Image == null
                || textBoxCardID.Text == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        bool verifMoto()
        {
            if (pictureBoxLicensePlate.Image == null
                || pictureBoxUser.Image == null
                || textBoxCardID.Text == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        // Nếu còn slot thì trả về true
        bool slot(string loaiXe)
        {
            Vehicle vehicle = new Vehicle();
            DataTable table = vehicle.getVehicle(new SqlCommand("SELECT * FROM Slot"));
            int soXeDangGui = int.Parse(vehicle.execCount("SELECT COUNT(*) FROM Xe WHERE TrangThaiGui = 'Dang Gui'"));
            if (loaiXe == "Xe Dap" && soXeDangGui < int.Parse(table.Rows[0][1].ToString()))
            {
                return true;
            }   
            else if (loaiXe == "Xe Hoi" && soXeDangGui < int.Parse(table.Rows[1][1].ToString()))
            {
                return true;
            }    
            else if (loaiXe == "Xe May" && soXeDangGui < int.Parse(table.Rows[2][1].ToString()))
            {
                return true;
            }
            return false;
        }

        private void buttonAddVehicle_Click(object sender, EventArgs e)
        {
            Vehicle vehicle = new Vehicle();
            try
            { 
                string id = textBoxCardID.Text;
                string type = "Xe May";
                string shape = comboBoxShape.Text;
                if (radioButtonMoto.Checked && verifMoto())
                {
                    if (slot(type) == false)
                    {
                        MessageBox.Show("Out of Slot", "Add Vehicle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }    
                    MemoryStream user_pic = new MemoryStream();
                    MemoryStream license_pic = new MemoryStream();
                    pictureBoxUser.Image.Save(user_pic, pictureBoxUser.Image.RawFormat);
                    pictureBoxLicensePlate.Image.Save(license_pic, pictureBoxLicensePlate.Image.RawFormat);
                    DateTime inTime = dateTimePickerInTime.Value;
                    vehicle.insertMoto(id, type, license_pic, user_pic, inTime, shape);

                }
                else if (radioButtonCar.Checked && verifCar())
                {
                    type = "Xe Hoi";
                    if (slot(type) == false)
                    {
                        MessageBox.Show("Out of Slot", "Add Vehicle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    MemoryStream license_pic = new MemoryStream();
                    MemoryStream model_pic = new MemoryStream();
                    pictureBoxLicensePlate.Image.Save(license_pic, pictureBoxLicensePlate.Image.RawFormat);
                    pictureBoxModel.Image.Save(model_pic, pictureBoxModel.Image.RawFormat);
                    DateTime inTime = dateTimePickerInTime.Value;
                    vehicle.insertCar(id, type, license_pic, model_pic, inTime, shape);
                }
                else if (radioButtonBike.Checked && verifBike())
                {
                    type = "Xe Dap";
                    if (slot(type) == false)
                    {
                        MessageBox.Show("Out of Slot", "Add Vehicle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    MemoryStream user_pic = new MemoryStream();
                    MemoryStream vehicle_pic = new MemoryStream();
                    pictureBoxUser.Image.Save(user_pic, pictureBoxUser.Image.RawFormat);
                    pictureBoxVehiclePicture.Image.Save(vehicle_pic, pictureBoxVehiclePicture.Image.RawFormat);
                    DateTime inTime = dateTimePickerInTime.Value;
                    vehicle.insertBike(id, type, user_pic, vehicle_pic, inTime, shape);
                }
                else
                {
                    MessageBox.Show("Please check your input", "Add Vehicle", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                MessageBox.Show("New Vehicle Added", "Add Vehicle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Card ID is already exists.", "Add Vehice", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonLoadUser_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if ((opf.ShowDialog() == DialogResult.OK))
            {
                pictureBoxUser.Image = Image.FromFile(opf.FileName);
            }

        }

        private void buttonLoadLicensePlate_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if ((opf.ShowDialog() == DialogResult.OK))
            {
                pictureBoxLicensePlate.Image = Image.FromFile(opf.FileName);
            }

        }

        private void buttonLoadVehiclePictrue_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if ((opf.ShowDialog() == DialogResult.OK))
            {
                pictureBoxVehiclePicture.Image = Image.FromFile(opf.FileName);
            }

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonResetData_Click(object sender, EventArgs e)
        {
            textBoxCardID.Text = "";
            radioButtonBike.Checked = false;
            radioButtonCar.Checked = false;
            radioButtonMoto.Checked = false;

            pictureBoxModel.Image = null;
            pictureBoxUser.Image = null;
            pictureBoxVehiclePicture.Image = null;
            pictureBoxLicensePlate.Image = null;
        }
    }
}
