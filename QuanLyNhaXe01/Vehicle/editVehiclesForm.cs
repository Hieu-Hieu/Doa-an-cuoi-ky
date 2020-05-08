using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace QuanLyNhaXe01
{
    public partial class editVehiclesForm : Form
    {
        public editVehiclesForm()
        {
            InitializeComponent();
        }

        Vehicle vehicle = new Vehicle();
        MyDB mydb = new MyDB();

        bool verifCar()
        {
            if (pictureBoxLicensePlate.Image == null
                || pictureBoxModel.Image == null)

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
                || pictureBoxUser.Image == null)

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
                || pictureBoxUser.Image == null)

            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void editVehiclesForm_Load(object sender, EventArgs e)
        {
            //  Detach event
            comboBoxCardID.SelectedIndexChanged -= comboBoxCardID_SelectedIndexChanged;

         //   Populate Combobox1
            SqlDataAdapter da = new SqlDataAdapter("SELECT MaTheXe FROM Xe", mydb.getConnection);
            DataSet ds = new DataSet();
            da.Fill(ds);
            comboBoxCardID.DataSource = ds.Tables[0];
            comboBoxCardID.DisplayMember = "MaTheXe";
            comboBoxCardID.ValueMember = "MaTheXe";

            //Attach event again
            comboBoxCardID.SelectedIndexChanged += comboBoxCardID_SelectedIndexChanged;

            DataTable tableShape = vehicle.getShapeByID(comboBoxCardID.Text);
            comboBoxShape.Text = tableShape.Rows[0][0].ToString();

            // checkBox Status
            checkBoxStatus.Enabled = false;

            DataTable tableStatus = vehicle.getStatusByID(comboBoxCardID.Text);
            if (tableStatus.Rows[0][0].ToString() == "Dang Gui")
            {
                checkBoxStatus.Checked = true;
            }    
            else
            {
                checkBoxStatus.Checked = false;
            }    
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            Vehicle vehicle = new Vehicle();
            try
            {
                string id = comboBoxCardID.Text;
                string type = "Xe May";
                string shape = comboBoxShape.Text;
                string status = "Dang Gui";
                if (checkBoxStatus.Checked == false)
                {
                    status = "Da Lay Xe";
                }    

                if (radioButtonMoto.Checked && verifMoto())
                {
                    MemoryStream user_pic = new MemoryStream();
                    MemoryStream license_pic = new MemoryStream();
                    MemoryStream model_pic = new MemoryStream();
                    MemoryStream vehicle_pic = new MemoryStream();

                    pictureBoxUser.Image.Save(user_pic, pictureBoxUser.Image.RawFormat);
                    pictureBoxLicensePlate.Image.Save(license_pic, pictureBoxLicensePlate.Image.RawFormat);

                    DateTime inTime = dateTimePickerInTime.Value;
                    vehicle.updateMoto(id, type, license_pic, user_pic, inTime, model_pic, vehicle_pic, shape, status);

                }
                else if (radioButtonCar.Checked && verifCar())
                {
                    type = "Xe Hoi";
                    MemoryStream user_pic = new MemoryStream();
                    MemoryStream license_pic = new MemoryStream();
                    MemoryStream model_pic = new MemoryStream();
                    MemoryStream vehicle_pic = new MemoryStream();
                    pictureBoxLicensePlate.Image.Save(license_pic, pictureBoxLicensePlate.Image.RawFormat);
                    pictureBoxModel.Image.Save(model_pic, pictureBoxModel.Image.RawFormat);
                    DateTime inTime = dateTimePickerInTime.Value;
                    vehicle.updateCar(id, type, license_pic, model_pic, inTime, vehicle_pic, user_pic, shape, status);
                }
                else if (radioButtonBike.Checked && verifBike())
                {
                    type = "Xe Dap";
                    MemoryStream user_pic = new MemoryStream();
                    MemoryStream license_pic = new MemoryStream();
                    MemoryStream model_pic = new MemoryStream();
                    MemoryStream vehicle_pic = new MemoryStream();
                    pictureBoxUser.Image.Save(user_pic, pictureBoxUser.Image.RawFormat);
                    pictureBoxVehiclePicture.Image.Save(vehicle_pic, pictureBoxVehiclePicture.Image.RawFormat);
                    DateTime inTime = dateTimePickerInTime.Value;
                    vehicle.updateBike(id, type, user_pic, vehicle_pic, inTime, license_pic, model_pic, shape, status);
                }
                else
                {
                    MessageBox.Show("Please check your input", "Update Vehicle", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                MessageBox.Show(" Vehicle Updated", "Update Vehicle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Vehicle has not been updated.", "Update Vehice", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void showData()
        {
            string maTheXe = comboBoxCardID.SelectedValue.ToString();
            DataTable table = vehicle.getVehicle(new SqlCommand("SELECT LoaiXe, BienSo, NguoiGui, HieuXe, AnhXe, ThoiGianVao FROM Xe WHERE MaTheXe = " + maTheXe));

            #region Fill Picture
            if (table.Rows[0]["LoaiXe"].ToString() == "Xe May")
            {
                radioButtonMoto.Checked = true;
                // get image BienSo
                byte[] bytes_bso = (byte[])table.Rows[0]["BienSo"];
                MemoryStream bso = new MemoryStream(bytes_bso);
                pictureBoxLicensePlate.Image = Image.FromStream(bso);

                // get image Nguoi Gui
                byte[] bytes_nguoigui = (byte[])table.Rows[0]["NguoiGui"];
                MemoryStream nguoigui = new MemoryStream(bytes_nguoigui);
                pictureBoxUser.Image = Image.FromStream(nguoigui);

                pictureBoxModel.Image = null;
                pictureBoxVehiclePicture.Image = null;

                buttonLoadModel.Enabled = false;
                buttonLoadVehiclePictrue.Enabled = false;
                buttonLoadUser.Enabled = true;
                buttonLoadLicensePlate.Enabled = true;
            }    
            else if (table.Rows[0]["LoaiXe"].ToString() == "Xe Dap")
            {
                radioButtonBike.Checked = true;
                // get image Anh Xe
                byte[] bytes_anhxe = (byte[])table.Rows[0]["AnhXe"];
                MemoryStream anhxe = new MemoryStream(bytes_anhxe);
                pictureBoxVehiclePicture.Image = Image.FromStream(anhxe);

                // get image NguoiGui
                byte[] bytes_nguoigui = (byte[])table.Rows[0]["NguoiGui"];
                MemoryStream nguoigui = new MemoryStream(bytes_nguoigui);
                pictureBoxUser.Image = Image.FromStream(nguoigui);

                pictureBoxModel.Image = null;
                pictureBoxLicensePlate.Image = null;

                buttonLoadLicensePlate.Enabled = false;
                buttonLoadModel.Enabled = false;
                buttonLoadVehiclePictrue.Enabled = true;
                buttonLoadUser.Enabled = true;
            }
            else
            {
                radioButtonCar.Checked = true;
                // get image Hieu Xe
                byte[] bytes_hieuxe = (byte[])table.Rows[0]["HieuXe"];
                MemoryStream hieuxe = new MemoryStream(bytes_hieuxe);
                pictureBoxModel.Image = Image.FromStream(hieuxe);

                // get image BienSo
                byte[] bytes_bienso = (byte[])table.Rows[0]["BienSo"];
                MemoryStream bienso = new MemoryStream(bytes_bienso);
                pictureBoxLicensePlate.Image = Image.FromStream(bienso);

                pictureBoxUser.Image = null;
                pictureBoxVehiclePicture.Image = null;

                buttonLoadUser.Enabled = false;
                buttonLoadVehiclePictrue.Enabled = false;
                buttonLoadModel.Enabled = true;
                buttonLoadLicensePlate.Enabled = true;
            }
            #endregion

            dateTimePickerInTime.Value = (DateTime)table.Rows[0]["ThoiGianVao"];
            DataTable tableShape = vehicle.getShapeByID(comboBoxCardID.Text);

            comboBoxShape.Text = tableShape.Rows[0][0].ToString();

            DataTable tableStatus = vehicle.getStatusByID(comboBoxCardID.Text);
            if (tableStatus.Rows[0][0].ToString() == "Dang Gui")
            {
                checkBoxStatus.Checked = true;
            }
            else
            {
                checkBoxStatus.Checked = false;
            }
        }

        
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButtonCar_CheckedChanged(object sender, EventArgs e)
        {
            buttonLoadUser.Enabled = false;
            buttonLoadVehiclePictrue.Enabled = false;
            buttonLoadModel.Enabled = true;
            buttonLoadLicensePlate.Enabled = true;

            pictureBoxUser.Image = null;
            pictureBoxVehiclePicture.Image = null;

            buttonLoadModel.BackColor = Color.SaddleBrown;
            buttonLoadLicensePlate.BackColor = Color.SaddleBrown;
            buttonLoadUser.BackColor = Color.Transparent;
            buttonLoadVehiclePictrue.BackColor = Color.Transparent;

        }

        private void radioButtonMoto_CheckedChanged(object sender, EventArgs e)
        {
            buttonLoadModel.Enabled = false;
            buttonLoadVehiclePictrue.Enabled = false;
            buttonLoadUser.Enabled = true;
            buttonLoadLicensePlate.Enabled = true;

            pictureBoxModel.Image = null;
            pictureBoxVehiclePicture.Image = null;

            buttonLoadUser.BackColor = Color.SaddleBrown;
            buttonLoadLicensePlate.BackColor = Color.SaddleBrown;
            buttonLoadModel.BackColor = Color.Transparent;
            buttonLoadVehiclePictrue.BackColor = Color.Transparent;

        }

        private void radioButtonBike_CheckedChanged(object sender, EventArgs e)
        {
            buttonLoadLicensePlate.Enabled = false;
            buttonLoadModel.Enabled = false;
            buttonLoadVehiclePictrue.Enabled = true;
            buttonLoadUser.Enabled = true;

            pictureBoxLicensePlate.Image = null;
            pictureBoxModel.Image = null;

            buttonLoadVehiclePictrue.BackColor = Color.SaddleBrown;
            buttonLoadUser.BackColor = Color.SaddleBrown;
            buttonLoadModel.BackColor = Color.Transparent;
            buttonLoadLicensePlate.BackColor = Color.Transparent;

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

        private void buttonLoadModel_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if ((opf.ShowDialog() == DialogResult.OK))
            {
                pictureBoxModel.Image = Image.FromFile(opf.FileName);
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            radioButtonBike.Checked = false;
            radioButtonCar.Checked = false;
            radioButtonMoto.Checked = false;
            pictureBoxModel.Image = null;
            pictureBoxUser.Image = null;
            pictureBoxVehiclePicture.Image = null;
            pictureBoxLicensePlate.Image = null;

            dateTimePickerInTime.Value = DateTime.Now;
        }

        private void comboBoxCardID_SelectedIndexChanged(object sender, EventArgs e)
        {
            showData();
        }
    }
}
