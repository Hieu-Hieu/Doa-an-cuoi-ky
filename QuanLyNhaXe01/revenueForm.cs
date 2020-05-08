using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace QuanLyNhaXe01
{
    public partial class revenueForm : Form
    {
        public revenueForm()
        {
            InitializeComponent();
            this.dataGridViewShowData.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridViewShowData_DataError);
        }

        Vehicle vehicle = new Vehicle();
       
        void makeUpGridForAll()
        {
            try
            {
                dataGridViewShowData.ReadOnly = true;
                dataGridViewShowData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                DataGridViewImageColumn picCol2 = new DataGridViewImageColumn();
                DataGridViewImageColumn picCol3 = new DataGridViewImageColumn();
                DataGridViewImageColumn picCol4 = new DataGridViewImageColumn();
                DataGridViewImageColumn picCol5 = new DataGridViewImageColumn();


                dataGridViewShowData.RowTemplate.Height = 80;

                picCol2 = (DataGridViewImageColumn)dataGridViewShowData.Columns[2];
                picCol3 = (DataGridViewImageColumn)dataGridViewShowData.Columns[3];
                picCol4 = (DataGridViewImageColumn)dataGridViewShowData.Columns[4];
                picCol5 = (DataGridViewImageColumn)dataGridViewShowData.Columns[5];

                picCol2.ImageLayout = DataGridViewImageCellLayout.Stretch;
                picCol3.ImageLayout = DataGridViewImageCellLayout.Stretch;
                picCol4.ImageLayout = DataGridViewImageCellLayout.Stretch;
                picCol5.ImageLayout = DataGridViewImageCellLayout.Stretch;

                dataGridViewShowData.AllowUserToAddRows = false;
            }
            catch
            {

            }
        }

        private void copyAlltoClipboard()
        {

            dataGridViewShowData.SelectAll();
            DataObject dataObj = dataGridViewShowData.GetClipboardContent();
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

        private void buttonExport_Click(object sender, EventArgs e)
        {
            // Tham khảo link: https://stackoverflow.com/questions/18182029/how-to-export-datagridview-data-instantly-to-excel-on-button-click

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Documents (*.xls)|*.xls";
            sfd.FileName = "Data.xls";
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
                dataGridViewShowData.ClearSelection();

                // Open the newly saved excel file
                if (File.Exists(sfd.FileName))
                    System.Diagnostics.Process.Start(sfd.FileName);
            }
        }

        private void revenueForm_Load(object sender, EventArgs e)
        {
            makeUpGridForAll();
            buttonShowRevenue_Click(sender, e);
        }

        private void dataGridViewShowData_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void buttonShowVehicles_Click(object sender, EventArgs e)
        {
            string dateFrom = dateTimePickerFrom.Value.ToString("yyyy-MM-dd");
            string dateTo = dateTimePickerTo.Value.ToString("yyyy-MM-dd");
            string query = "SELECT * FROM Xe WHERE ThoiGianRa BETWEEN '" + dateFrom + " 00:00:00.000" + "' AND '" + dateTo + " 23:59:59.997" + "'";
            dataGridViewShowData.DataSource = vehicle.getVehicle(new SqlCommand(query));
            makeUpGridForAll();
        }

        private void buttonShowRevenue_Click(object sender, EventArgs e)
        {
            string dateFrom = dateTimePickerFrom.Value.ToString("yyyy-MM-dd");
            string dateTo = dateTimePickerTo.Value.ToString("yyyy-MM-dd");
            string query = "SELECT LoaiXe, COUNT(Xe.MaTheXe) AS SoLuong, SUM(Total) AS TongDoanhThu " +
                "FROM Xe INNER JOIN DoanhThu ON Xe.MaTheXe = DoanhThu.MaTheXe " +
                "WHERE ThoiGianRa BETWEEN '" + dateFrom + " 00:00:00.000" + "' AND '" + dateTo + " 23:59:59.997" + "' " +
                "GROUP BY LoaiXe";
            DataTable table = vehicle.getVehicle(new SqlCommand(query));
            int tatCaXe = 0;
            float tongDoanhThu = 0;
            for (int i = 0; i < table.Rows.Count; i++)
            {
                tatCaXe += int.Parse(table.Rows[i][1].ToString());
                tongDoanhThu += float.Parse(table.Rows[i][2].ToString());
            }
            table.Rows.Add(new object[] { "Tong Doanh Thu", tatCaXe, tongDoanhThu });
            dataGridViewShowData.DataSource = table;
            makeUpGridForAll();
        }
    }
}