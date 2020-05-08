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
    public partial class settingForm : Form
    {
        public settingForm()
        {
            InitializeComponent();
        }

        Calculate calculate = new Calculate();
        private void settingForm_Load(object sender, EventArgs e)
        {
            DataTable table = calculate.getData(new SqlCommand("SELECT * FROM PhiGuiXe"));
           textBoxFeeBike.Text = table.Rows[0][1].ToString();
            textBoxFeeMoto.Text = table.Rows[2][2].ToString();
            textBoxFeeCar.Text = table.Rows[1][2].ToString();
            // bike
           

           
        }

        private void buttonApplyFee_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
