using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaXe01
{
    public partial class editContractForm : Form
    {
        public editContractForm()
        {
            InitializeComponent();
        }

        Contract contract = new Contract();
        private void buttonEdit_Click(object sender, EventArgs e)
        {

        }


        private void removeContracByID()
        {
            try
            {
                int contractID = Convert.ToInt32(textBoxContractID.Text);
                //  display a confirmation message before the delete
                if ((MessageBox.Show("Are You Sure You Want To Delete This Contract", "Delete Contract", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    if (contract.deleteContractByID(contractID))
                    {
                        MessageBox.Show("Contract Deleted", "Delete Contract", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //  clear fields after delete
                        textBoxContractID.Text = "";
                        textBoxCustomerID.Text = "";
                        comboBoxVehicleType.Text= "";
                        textBoxContractValue.Text = "";
                        textBoxDescibe.Text = "";

                        comboBoxContractType.Text = "";

                        dateTimePickerReceive.Value = DateTime.Now;
                        dateTimePickerSign.Value = DateTime.Now;
                    }
                    else
                    {
                        MessageBox.Show("Contract Not Deleted", "Delete Contract", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }

            }
            catch
            {
                MessageBox.Show("Please Enter A Valid ID", "Delete Contract", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
