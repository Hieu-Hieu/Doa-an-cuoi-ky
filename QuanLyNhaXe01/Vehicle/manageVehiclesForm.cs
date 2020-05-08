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

namespace QuanLyNhaXe01
{
    public partial class manageVehiclesForm : Form
    {
        public manageVehiclesForm()
        {
            InitializeComponent();
            this.dataGridVManageVehicle.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridVManageVehicle_DataError);
        }

        Vehicle vehicle = new Vehicle();

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            editVehiclesForm editForm = new editVehiclesForm();
            editForm.ShowDialog(this);
        }

        private void textBoxSearchLicenPlate_TextChanged(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT *FROM Xe WHERE CONCAT(MaTheXe, LoaiXe, ThoiGianVao) LIKE '%" + textBoxSearchLicenPlate.Text + "%'");
            dataGridVManageVehicle.DataSource = vehicle.getVehicle(command);
        }

        private void manageVehiclesForm_Load(object sender, EventArgs e)
        {
            DataTable dt = vehicle.getTypeVehicle();
            dt.Rows.Add(new Object[]{
                "Tat Ca"
            });
            comboBoxTypeVehicle.DataSource = dt;
            comboBoxTypeVehicle.ValueMember = "LoaiXe";
            comboBoxTypeVehicle.DisplayMember = "LoaiXe";
            fillGrid();
            makeUpGridForXeMayAndXeDap();

            labelDangGui.Text = "Existing: " + vehicle.totalVehicle_in();
            labelDaRa.Text = "Leave: " + vehicle.totalVehicle_out();
            labelStatus.Text = "Total Vehicle: " + vehicle.totalVehicle();
        }


        void fillGrid()
        {
            if (comboBoxTypeVehicle.Text == "Xe May")
            {
                dataGridVManageVehicle.DataSource = vehicle.getVehicle(new SqlCommand("SELECT MaTheXe, LoaiXe, NguoiGui, BienSo, ThoiGianVao, HinhThucGui, TrangThaiGui FROM dbo.Xe WHERE LoaiXe = 'Xe May'"));
                makeUpGridForXeMayAndXeDap();
            }
            else if (comboBoxTypeVehicle.Text == "Xe Dap")
            {
                dataGridVManageVehicle.DataSource = vehicle.getVehicle(new SqlCommand("SELECT MaTheXe, LoaiXe, NguoiGui, AnhXe, ThoiGianVao, HinhThucGui,TrangThaiGui FROM dbo.Xe WHERE LoaiXe = 'Xe Dap'"));
                makeUpGridForXeMayAndXeDap();
            }
            else if (comboBoxTypeVehicle.Text == "Xe Hoi")
            {
                dataGridVManageVehicle.DataSource = vehicle.getVehicle(new SqlCommand("SELECT MaTheXe, LoaiXe, HieuXe, BienSo, ThoiGianVao, HinhThucGui,TrangThaiGui FROM Xe  WHERE LoaiXe = 'Xe Hoi'"));
                makeUpGridForXeMayAndXeDap();
            }
            else if (comboBoxTypeVehicle.Text == "Tat Ca")
            {
                dataGridVManageVehicle.DataSource = vehicle.getVehicle(new SqlCommand("SELECT * FROM Xe"));
                makeUpGridForAllAndXeHoi();
            }

            labelDangGui.Text = "Existing: " + vehicle.totalVehicle_in();
            labelDaRa.Text = "Leave: " + vehicle.totalVehicle_out();
            labelStatus.Text = "Total Vehicle: " + vehicle.totalVehicle();

        }

        private void comboBoxTypeVehicle_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillGrid();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            addVehicleForm addForm = new addVehicleForm();
            addForm.ShowDialog(this);
        }

        void makeUpGridForAllAndXeHoi()
        {
            try
            {
                dataGridVManageVehicle.ReadOnly = true;

                DataGridViewImageColumn picCol2 = new DataGridViewImageColumn();
                DataGridViewImageColumn picCol3 = new DataGridViewImageColumn();
                DataGridViewImageColumn picCol4 = new DataGridViewImageColumn();
                DataGridViewImageColumn picCol5 = new DataGridViewImageColumn();
                

                dataGridVManageVehicle.RowTemplate.Height = 80;

                picCol2 = (DataGridViewImageColumn)dataGridVManageVehicle.Columns[2];
                picCol3 = (DataGridViewImageColumn)dataGridVManageVehicle.Columns[3];
                picCol4 = (DataGridViewImageColumn)dataGridVManageVehicle.Columns[4];
                picCol5 = (DataGridViewImageColumn)dataGridVManageVehicle.Columns[5];

                picCol2.ImageLayout = DataGridViewImageCellLayout.Stretch;
                picCol3.ImageLayout = DataGridViewImageCellLayout.Stretch;
                picCol4.ImageLayout = DataGridViewImageCellLayout.Stretch;
                picCol5.ImageLayout = DataGridViewImageCellLayout.Stretch;

                dataGridVManageVehicle.AllowUserToAddRows = false;
            }
            catch
            {
                
            }
        }

        void makeUpGridForXeMayAndXeDap()
        {
            try
            {
                dataGridVManageVehicle.ReadOnly = true;

                DataGridViewImageColumn picCol2 = new DataGridViewImageColumn();
                DataGridViewImageColumn picCol3 = new DataGridViewImageColumn();
                
                dataGridVManageVehicle.RowTemplate.Height = 80;

                picCol2 = (DataGridViewImageColumn)dataGridVManageVehicle.Columns[2];
                picCol3 = (DataGridViewImageColumn)dataGridVManageVehicle.Columns[3];
                
                picCol2.ImageLayout = DataGridViewImageCellLayout.Stretch;
                picCol3.ImageLayout = DataGridViewImageCellLayout.Stretch;
                
                dataGridVManageVehicle.AllowUserToAddRows = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            fillGrid();
            
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string id = dataGridVManageVehicle.CurrentRow.Cells[0].Value.ToString();
                if (MessageBox.Show("Do you want to detele this vehicle", "Delete Vehicle", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    vehicle.deleteVehicle(id);
                    fillGrid();
                }    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete Vehicle", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonPay_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridVManageVehicle.CurrentRow.Cells["TrangThaiGui"].Value.ToString() == "Dang Gui")
                {
                    string id = dataGridVManageVehicle.CurrentRow.Cells[0].Value.ToString();
                    paymentForm pay = new paymentForm(id);
                    pay.ShowDialog();
                }
                else
                {
                    MessageBox.Show("This vehicle paid!", "Pay", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        private void dataGridVManageVehicle_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void labelStatus_Click(object sender, EventArgs e)
        {

        }
    }
}
