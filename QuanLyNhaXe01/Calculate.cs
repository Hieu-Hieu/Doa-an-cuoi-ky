using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaXe01
{
    class Calculate
    {

        MyDB mydb = new MyDB();
        public DataTable getData(SqlCommand cmd)
        {
            cmd.Connection = mydb.getConnection;

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public (float, float) parkingFeeAndFine(string LoaiXe, string HinhThucGui, TimeSpan ThoiGianGui)
        {
            Calculate calculate = new Calculate();
            DataTable table = calculate.getData(new SqlCommand("SELECT * FROM PhiGuiXe"));
            float PhiGuiXe = 0;
            float TienPhat = 0;
            float cost;
           
            // Lấy phí gửi xe theo giờ của từng loại xe trong database
            if (LoaiXe == "Xe Dap")
            {
                cost = float.Parse(table.Rows[0][1].ToString());
            }
            else if (LoaiXe == "Xe May")
            {
                cost = float.Parse(table.Rows[2][1].ToString());
            }
            else
            {
                cost = float.Parse(table.Rows[1][1].ToString());
            }

            // Tính mức phí của tất cả loại xe
            if (HinhThucGui == "By Hour")
            {
                PhiGuiXe = cost * ThoiGianGui.Hours;
                if (ThoiGianGui.Days < 1)
                {
                    TienPhat = 0;
                }
                else
                {
                    TienPhat = (cost * 8 * ThoiGianGui.Days) * 2;
                }
            }
            else if (HinhThucGui == "By Day")
            {
                PhiGuiXe = cost * 8;
                if (ThoiGianGui.Days <= 1)
                {
                    TienPhat = 0;
                }
                else
                {
                    TienPhat = cost * 8 * 3;
                }
            }
            else if (HinhThucGui == "By Week")
            {
                PhiGuiXe = cost * 8 * 3;
                if (ThoiGianGui.Days <= 10)
                {
                    TienPhat = 0;
                }
                else
                {
                    TienPhat = cost * 8 * 3 * 2;
                }
            }
            return (PhiGuiXe, TienPhat);
        
        }
    }
}
