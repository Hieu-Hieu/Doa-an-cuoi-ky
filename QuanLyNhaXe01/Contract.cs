using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaXe01
{
    class Contract
    {
        MyDB mydb = new MyDB();
        public bool addContract(int soHD, string loaiHD, DateTime ngayKy, string maKH, string loaiXe, string moTa,
            decimal giaHD, DateTime ngayNhiemThu)
        {

            SqlCommand command = new SqlCommand("INSERT INTO Contract(SoHD, LoaiHD, NgayKyHD,MaKH,LoaiXe, Mota, GiaTriHD, NgayNhiemThu) " +
                "VALUES(@soHD, @loai, @ngayKY, @maKH, @loaiXe, @moTa, @giaHD, @ngayNT)", mydb.getConnection);

            command.Parameters.Add("@soHD", SqlDbType.Int).Value = soHD;
            command.Parameters.Add("loai", SqlDbType.NVarChar).Value = loaiHD;
            command.Parameters.Add("@ngayKY", SqlDbType.DateTime).Value = ngayKy;
            command.Parameters.Add("@maKH", SqlDbType.NVarChar).Value = maKH;
            command.Parameters.Add("@loaiXe", SqlDbType.VarChar).Value = loaiXe;
            command.Parameters.Add("@moTa", SqlDbType.Text).Value = moTa;

            command.Parameters.Add("@giaHD", SqlDbType.Decimal).Value = giaHD;
            command.Parameters.Add("@ngayNT", SqlDbType.DateTime).Value = ngayNhiemThu;

            mydb.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }

        public bool updateContract(int soHD, string loaiHD, DateTime ngayKy, string maKH, string loaiXe, string moTa,
           decimal giaHD, DateTime ngayNhiemThu)

        {

            SqlCommand command = new SqlCommand("UPDATE Contract SET  LoaiHD=@loai, NgayKyHD=@ngayKY, MaKH=@maKH, LoaiXe=@loaiXe, Mota=@moTa, GiaTriHD=@giaHD, NgayNhiemThu=@ngayNT WHERE SoHD=@soHD)", mydb.getConnection);

            command.Parameters.Add("@soHD", SqlDbType.Int).Value = soHD;
            command.Parameters.Add("loai", SqlDbType.NVarChar).Value = loaiHD;
            command.Parameters.Add("@ngayKY", SqlDbType.DateTime).Value = ngayKy;
            command.Parameters.Add("@maKH", SqlDbType.NVarChar).Value = maKH;
            command.Parameters.Add("@loaiXe", SqlDbType.VarChar).Value = loaiXe;
            command.Parameters.Add("@moTa", SqlDbType.Text).Value = moTa;

            command.Parameters.Add("@giaHD", SqlDbType.Decimal).Value = giaHD;
            command.Parameters.Add("@ngayNT", SqlDbType.DateTime).Value = ngayNhiemThu;

            mydb.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }

        public bool deleteContractByID(int soHD)
        {
            SqlCommand command = new SqlCommand("DELETE FROM Contract WHERE SoHD=@so", mydb.getConnection);
            command.Parameters.Add("@so", SqlDbType.Int).Value = soHD;

            mydb.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }

        public bool contractExist(int soHD)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Contract WHERE SoHD=@so", mydb.getConnection);
            command.Parameters.Add("@so", SqlDbType.Int).Value = soHD;

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();

            adapter.Fill(table);

            mydb.openConnection();
            if ((table.Rows.Count == 0))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
