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
    public partial class deleteVehicleByID : Form
    {
        public deleteVehicleByID()
        {
            InitializeComponent();
        }

        Vehicle vehicle = new Vehicle();

        private void deleteVehicleByID_Load(object sender, EventArgs e)
        {
            comboBoxID.DataSource = vehicle.getVehicle(new SqlCommand("SELECT MaTheXe FROM Xe"));
            comboBoxID.ValueMember = "MaTheXe";
            comboBoxID.ValueMember = "MaTheXe";
            comboBoxID_SelectionChangeCommitted(sender, e);
        }

        private void comboBoxID_SelectionChangeCommitted(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT MaTheXe, LoaiXe, ThoiGianVao, AnhXe FROM Xe WHERE MaTheXe = " + comboBoxID.Text);

            DataTable table = vehicle.getVehicle(command);

            if (table.Rows.Count > 0)
            {
                labelCardID.Text = table.Rows[0]["MaTheXe"].ToString();
                labelTypeOfVehicle.Text = table.Rows[0]["LoaiXe"].ToString();
                labelInTime.Text = table.Rows[0]["ThoiGianVao"].ToString();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string id = comboBoxID.Text;
                if (MessageBox.Show("Do you want to detele this vehicle", "Delete Vehicle", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    vehicle.deleteVehicle(id);
                    deleteVehicleByID_Load(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete Vehicle", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
