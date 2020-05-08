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
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            MyDB db = new MyDB();
            SqlDataAdapter adapter = new SqlDataAdapter();

            DataTable table = new DataTable();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Login WHERE username=@User AND password=@Pass", db.getConnection);
            cmd.Parameters.Add("@User", SqlDbType.VarChar).Value = textBoxUser.Text;
            cmd.Parameters.Add("@Pass", SqlDbType.VarChar).Value = textBoxPassword.Text;

            adapter.SelectCommand = cmd;
            adapter.Fill(table);


            if ((table.Rows.Count > 0))
            {
                this.DialogResult = DialogResult.OK;
                //MessageBox.Show("Login successful");
            }
            else
            {
                MessageBox.Show("Invalid Username or Password", "Login error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
