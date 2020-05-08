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
using System.Drawing.Printing;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;

namespace QuanLyNhaXe01
{
    public partial class printVehiclesForm : Form
    {
        public printVehiclesForm()
        {
            InitializeComponent();
        }

        Vehicle vehicle = new Vehicle();

        private void printVehiclesForm_Load(object sender, EventArgs e)
        {
            radioButtonCar.Checked = true;
            dataGridViewVehicle.DataSource = vehicle.getVehicle(new SqlCommand("SELECT *FROM Xe  WHERE LoaiXe = 'Xe Hoi'"));

            // makeUpGridForXeMayAndXeDap();
            makeUpGridForAllAndXeHoi();
        }

        private void radioButtonCar_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewVehicle.DataSource = vehicle.getVehicle(new SqlCommand("SELECT MaTheXe, LoaiXe, BienSo, HieuXe, ThoiGianVao, HinhThucGui,TrangThaiGui FROM Xe  WHERE LoaiXe = 'Xe Hoi'"));
        }

        private void radioButtonMoto_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewVehicle.DataSource = vehicle.getVehicle(new SqlCommand("SELECT MaTheXe, LoaiXe, NguoiGui, BienSo, ThoiGianVao,HinhThucGui,TrangThaiGui  FROM dbo.Xe WHERE LoaiXe = 'Xe May'"));
        }

        private void radioButtonBike_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewVehicle.DataSource = vehicle.getVehicle(new SqlCommand("SELECT MaTheXe, LoaiXe, NguoiGui, AnhXe, ThoiGianVao, HinhThucGui,TrangThaiGui  FROM dbo.Xe WHERE LoaiXe = 'Xe Dap'"));
        }

        private void radioButtonAll_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewVehicle.DataSource = vehicle.getVehicle(new SqlCommand("SELECT *FROM Xe"));
        }

        private void radioButtonNo_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePickerFrom.Enabled = false;
            dateTimePickerTo.Enabled = false;
            if (radioButtonCar.Checked)
            {
                radioButtonCar_CheckedChanged(sender, e);
            }
            else if (radioButtonBike.Checked)
            {
                radioButtonBike_CheckedChanged(sender, e);
            }
            else if (radioButtonMoto.Checked)
            {
                radioButtonMoto_CheckedChanged(sender, e); 
            }
            else
            {
                radioButtonAll_CheckedChanged(sender, e); 
            }
        }

        private void radioButtonYes_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePickerFrom.Enabled = true;
            dateTimePickerTo.Enabled = true;
            string query;
            string dateFrom = dateTimePickerFrom.Value.ToString("yyyy-MM-dd");
            string dateTo = dateTimePickerTo.Value.ToString("yyyy-MM-dd");
            if (radioButtonCar.Checked)
            {
                query = "SELECT *FROM Xe  WHERE LoaiXe = 'Xe Hoi' AND ThoiGianVao BETWEEN '" + dateFrom + "' AND '" + dateTo + "'";
            }
            else if (radioButtonBike.Checked)
            {
                query = "SELECT MaTheXe, LoaiXe, NguoiGui, AnhXe, ThoiGianVao, Slot FROM dbo.Xe WHERE LoaiXe = 'Xe Dap' AND ThoiGianVao BETWEEN '" + dateFrom + "' AND '" + dateTo + "'";
            }
            else if (radioButtonMoto.Checked)
            {
                query = "SELECT MaTheXe, LoaiXe, NguoiGui, AnhXe, ThoiGianVao, Slot FROM dbo.Xe WHERE LoaiXe = 'Xe May' AND ThoiGianVao BETWEEN '" + dateFrom + "' AND '" + dateTo + "'";
            }
            else
            {
                query = "SELECT *FROM Xe WHERE ThoiGianVao BETWEEN '" + dateFrom + "' AND '" + dateTo + "'";
            }
            dataGridViewVehicle.DataSource = vehicle.getVehicle(new SqlCommand(query));
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            PrintDialog printDlg = new PrintDialog();
            PrintDocument printDoc = new PrintDocument();
            printDoc.DocumentName = "Print Document";
            printDlg.Document = printDoc;
            printDlg.AllowSelection = true;
            printDlg.AllowSomePages = true;

            if (printDlg.ShowDialog() == DialogResult.OK)
                printDoc.Print();
        }

        private void buttonSaveFile_Click(object sender, EventArgs e)
        {
            // Tham khảo link: https://stackoverflow.com/questions/18182029/how-to-export-datagridview-data-instantly-to-excel-on-button-click

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Documents (*.xls)|*.xls";
            sfd.FileName = "Inventory_Adjustment_Export.xls";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                // Copy DataGridView results to clipboard
                copyAlltoClipboard();

                object misValue = System.Reflection.Missing.Value;
                Excel.Application xlexcel = new Excel.Application();

                xlexcel.DisplayAlerts = false; // Without this you will get two confirm overwrite prompts
                Excel.Workbook xlWorkBook = xlexcel.Workbooks.Add(misValue);
                Excel.Worksheet xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

                // Format column D as text before pasting results, this was required for my data
                Excel.Range rng = xlWorkSheet.get_Range("D:D").Cells;
                rng.NumberFormat = "@";

                // Paste clipboard results to worksheet range
                Excel.Range CR = (Excel.Range)xlWorkSheet.Cells[1, 1];
                CR.Select();
                xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);

                // For some reason column A is always blank in the worksheet. ¯\_(ツ)_/¯
                // Delete blank column A and select cell A1
                Excel.Range delRng = xlWorkSheet.get_Range("A:A").Cells;
                delRng.Delete(Type.Missing);
                xlWorkSheet.get_Range("A1").Select();

                // Save the excel file under the captured location from the SaveFileDialog
                xlWorkBook.SaveAs(sfd.FileName, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                xlexcel.DisplayAlerts = true;
                xlWorkBook.Close(true, misValue, misValue);
                xlexcel.Quit();

                releaseObject(xlWorkSheet);
                releaseObject(xlWorkBook);
                releaseObject(xlexcel);

                // Clear Clipboard and DataGridView selection
                Clipboard.Clear();
                dataGridViewVehicle.ClearSelection();

                // Open the newly saved excel file
                if (File.Exists(sfd.FileName))
                    System.Diagnostics.Process.Start(sfd.FileName);
            }
        }

        private void copyAlltoClipboard()
        {
            dataGridViewVehicle.SelectAll();
            DataObject dataObj = dataGridViewVehicle.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }

        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Exception Occurred while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }


        void makeUpGridForAllAndXeHoi()
        {

            try
            {
                dataGridViewVehicle.ReadOnly = true;

                DataGridViewImageColumn picCol2 = new DataGridViewImageColumn();
                DataGridViewImageColumn picCol3 = new DataGridViewImageColumn();
                DataGridViewImageColumn picCol4 = new DataGridViewImageColumn();
                DataGridViewImageColumn picCol5 = new DataGridViewImageColumn();


                dataGridViewVehicle.RowTemplate.Height = 80;

                picCol2 = (DataGridViewImageColumn)dataGridViewVehicle.Columns[2];
                picCol3 = (DataGridViewImageColumn)dataGridViewVehicle.Columns[3];
                picCol4 = (DataGridViewImageColumn)dataGridViewVehicle.Columns[4];
                picCol5 = (DataGridViewImageColumn)dataGridViewVehicle.Columns[5];

                picCol2.ImageLayout = DataGridViewImageCellLayout.Stretch;
                picCol3.ImageLayout = DataGridViewImageCellLayout.Stretch;
                picCol4.ImageLayout = DataGridViewImageCellLayout.Stretch;
                picCol5.ImageLayout = DataGridViewImageCellLayout.Stretch;

                dataGridViewVehicle.AllowUserToAddRows = false;
            }
            catch
            {

            }
        }

        void makeUpGridForXeMayAndXeDap()
        {
            try
            {
                dataGridViewVehicle.ReadOnly = true;

                DataGridViewImageColumn picCol2 = new DataGridViewImageColumn();
                DataGridViewImageColumn picCol3 = new DataGridViewImageColumn();

                dataGridViewVehicle.RowTemplate.Height = 80;

                picCol2 = (DataGridViewImageColumn)dataGridViewVehicle.Columns[2];
                picCol3 = (DataGridViewImageColumn)dataGridViewVehicle.Columns[3];

                picCol2.ImageLayout = DataGridViewImageCellLayout.Stretch;
                picCol3.ImageLayout = DataGridViewImageCellLayout.Stretch;

                dataGridViewVehicle.AllowUserToAddRows = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
