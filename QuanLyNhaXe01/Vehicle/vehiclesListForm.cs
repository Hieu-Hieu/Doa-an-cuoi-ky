using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaXe01
{
    public partial class vehiclesListForm : Form
    {
        public vehiclesListForm()
        {
            InitializeComponent();
        }

        Vehicle vehicle = new Vehicle();
        private void vehiclesListForm_Load(object sender, EventArgs e)
        {
            /* DataTable dt = vehicle.getTypeVehicle();
             dt.Rows.Add(new Object[]{
                 "Tat Ca"
             });
             comboBoxTypeVehicle.DataSource = dt;
             comboBoxTypeVehicle.ValueMember = "LoaiXe";
             comboBoxTypeVehicle.DisplayMember = "LoaiXe";*/
            dataGridView1.DataSource = vehicle.getVehicle(new SqlCommand(" Select * from Xe"));
            comboBoxTypeVehicle.Text = "Tat Ca";
            fillGrid();
            makeUpGridForXeMayAndXeDap();

        }

        void fillGrid()
        {
            if (comboBoxTypeVehicle.Text == "Xe May")
            {
                dataGridView1.DataSource = vehicle.getVehicle(new SqlCommand("SELECT MaTheXe, LoaiXe, NguoiGui, BienSo, ThoiGianVao,HinhThucGui,TrangThaiGui  FROM dbo.Xe WHERE LoaiXe = 'Xe May'"));
                makeUpGridForXeMayAndXeDap();
            }
            else if (comboBoxTypeVehicle.Text == "Xe Dap")
            {
                dataGridView1.DataSource = vehicle.getVehicle(new SqlCommand("SELECT MaTheXe, LoaiXe, NguoiGui, AnhXe, ThoiGianVao, HinhThucGui,TrangThaiGui  FROM dbo.Xe WHERE LoaiXe = 'Xe Dap'"));
                makeUpGridForXeMayAndXeDap();
            }
            else if (comboBoxTypeVehicle.Text == "Xe Hoi")
            {
                dataGridView1.DataSource = vehicle.getVehicle(new SqlCommand("SELECT MaTheXe, LoaiXe, BienSo, HieuXe, ThoiGianVao, HinhThucGui, TrangThaiGui FROM Xe  WHERE LoaiXe = 'Xe Hoi'"));
                makeUpGridForXeMayAndXeDap();
            }
            else if (comboBoxTypeVehicle.Text == "Tat Ca")
            {
                dataGridView1.DataSource = vehicle.getVehicle(new SqlCommand("SELECT * FROM Xe"));
                makeUpGridForAllAndXeHoi();
            }
            labelTotal.Text = "Total Vehicle: " + dataGridView1.Rows.Count.ToString();
        }

        void makeUpGridForAllAndXeHoi()
        {
            try
            {
                dataGridView1.ReadOnly = true;

                DataGridViewImageColumn picCol2 = new DataGridViewImageColumn();
                DataGridViewImageColumn picCol3 = new DataGridViewImageColumn();
                DataGridViewImageColumn picCol4 = new DataGridViewImageColumn();
                DataGridViewImageColumn picCol5 = new DataGridViewImageColumn();


                dataGridView1.RowTemplate.Height = 80;

                picCol2 = (DataGridViewImageColumn)dataGridView1.Columns[2];
                picCol3 = (DataGridViewImageColumn)dataGridView1.Columns[3];
                picCol4 = (DataGridViewImageColumn)dataGridView1.Columns[4];
                picCol5 = (DataGridViewImageColumn)dataGridView1.Columns[5];

                picCol2.ImageLayout = DataGridViewImageCellLayout.Stretch;
                picCol3.ImageLayout = DataGridViewImageCellLayout.Stretch;
                picCol4.ImageLayout = DataGridViewImageCellLayout.Stretch;
                picCol5.ImageLayout = DataGridViewImageCellLayout.Stretch;

                dataGridView1.AllowUserToAddRows = false;
            }
            catch
            {

            }
        }

        void makeUpGridForXeMayAndXeDap()
        {
            try
            {
                dataGridView1.ReadOnly = true;

                DataGridViewImageColumn picCol2 = new DataGridViewImageColumn();
                DataGridViewImageColumn picCol3 = new DataGridViewImageColumn();

                dataGridView1.RowTemplate.Height = 80;

                picCol2 = (DataGridViewImageColumn)dataGridView1.Columns[2];
                picCol3 = (DataGridViewImageColumn)dataGridView1.Columns[3];

                picCol2.ImageLayout = DataGridViewImageCellLayout.Stretch;
                picCol3.ImageLayout = DataGridViewImageCellLayout.Stretch;

                dataGridView1.AllowUserToAddRows = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
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

        private void comboBoxTypeVehicle_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillGrid();
        }
    }
}
