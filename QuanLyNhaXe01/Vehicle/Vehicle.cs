using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaXe01
{
    class Vehicle
    {
        MyDB mydb = new MyDB();

        //MaTheXe, LoaiXe,BienSo,NguoiGui,HieuXe,AnhXe,ThoiGianVao,Slot
        public bool insertCar(string MaTheXe, string LoaiXe, MemoryStream BienSo, MemoryStream HieuXe,
                                     DateTime ThoiGianVao, string HinhThucGui)
        {
            SqlCommand command = new SqlCommand("Insert INTO Xe(MaTheXe, LoaiXe,BienSo,HieuXe,ThoiGianVao, HinhThucGui, TrangThaiGui)" +
                "Values(@ma,@loai,@bienso,@hieuxe,@time,@hinhThuc,'Dang Gui')", mydb.getConnection);

            command.Parameters.Add("@ma", System.Data.SqlDbType.Char).Value = MaTheXe;
            command.Parameters.Add("@loai", System.Data.SqlDbType.NVarChar).Value = LoaiXe;
            command.Parameters.Add("@bienso", System.Data.SqlDbType.Image).Value = BienSo.ToArray();
            command.Parameters.Add("@hieuxe", System.Data.SqlDbType.Image).Value = HieuXe.ToArray();
            command.Parameters.Add("@time", SqlDbType.DateTime).Value = ThoiGianVao;

            command.Parameters.Add("@hinhThuc", SqlDbType.NVarChar).Value = HinhThucGui;


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


        public bool insertMoto(string MaTheXe, string LoaiXe, MemoryStream BienSo, MemoryStream NguoiGui, DateTime ThoiGianVao, string HinhThucGui)
        {

            SqlCommand command = new SqlCommand("Insert INTO Xe(MaTheXe, LoaiXe,BienSo,NguoiGui,ThoiGianVao, HinhThucGui, TrangThaiGui)" +
                "Values(@ma,@loai,@bienso,@nguoigui,@time,@hinhThuc, 'Dang Gui')", mydb.getConnection);

            command.Parameters.Add("@ma", System.Data.SqlDbType.Char).Value = MaTheXe;
            command.Parameters.Add("@loai", System.Data.SqlDbType.NVarChar).Value = LoaiXe;
            command.Parameters.Add("@bienso", System.Data.SqlDbType.Image).Value = BienSo.ToArray();
            command.Parameters.Add("@nguoigui", System.Data.SqlDbType.Image).Value = NguoiGui.ToArray();
            command.Parameters.Add("@time", SqlDbType.DateTime).Value = ThoiGianVao;

            command.Parameters.Add("@hinhThuc", SqlDbType.NVarChar).Value = HinhThucGui;


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

        public bool insertBike(string MaTheXe, string LoaiXe, MemoryStream NguoiGui,
                                    MemoryStream AnhXe, DateTime ThoiGianVao, string HinhThucGui)
        {

            SqlCommand command = new SqlCommand("Insert INTO Xe(MaTheXe, LoaiXe,NguoiGui,AnhXe,ThoiGianVao, HinhThucGui, TrangThaiGui)" +
                "Values(@ma,@loai,@nguoigui,@anhxe,@time,@hinhThuc,'Dang Gui')", mydb.getConnection);

            command.Parameters.Add("@ma", System.Data.SqlDbType.Char).Value = MaTheXe;
            command.Parameters.Add("@loai", System.Data.SqlDbType.NVarChar).Value = LoaiXe;

            command.Parameters.Add("@nguoigui", System.Data.SqlDbType.Image).Value = NguoiGui.ToArray();

            command.Parameters.Add("@anhXe", System.Data.SqlDbType.Image).Value = AnhXe.ToArray();
            command.Parameters.Add("@time", SqlDbType.DateTime).Value = ThoiGianVao;

            command.Parameters.Add("@hinhThuc", SqlDbType.NVarChar).Value = HinhThucGui;

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


        public bool updateCar(string MaTheXe, string LoaiXe, MemoryStream BienSo, MemoryStream HieuXe,
                                    DateTime ThoiGianVao, MemoryStream AnhXe, MemoryStream NguoiGui, string HinhThucGui, string TrangThai)
        {
            SqlCommand command = new SqlCommand("UPDATE Xe SET  LoaiXe=@loai, BienSo= @bienso, HieuXe= @hieuxe,ThoiGianVao=@time, AnhXe=@anhxe, NguoiGui=@nguoigui, " +
                "HinhThucGui=@hinhThuc, TrangThaiGui =@trangThai" +
                "WHERE MaTheXe=@ma", mydb.getConnection);

            command.Parameters.Add("@ma", System.Data.SqlDbType.Char).Value = MaTheXe;
            command.Parameters.Add("@loai", System.Data.SqlDbType.NVarChar).Value = LoaiXe;
            command.Parameters.Add("@bienso", System.Data.SqlDbType.Image).Value = BienSo.ToArray();

            command.Parameters.Add("@hieuxe", System.Data.SqlDbType.Image).Value = HieuXe.ToArray();

            command.Parameters.Add("@time", SqlDbType.DateTime).Value = ThoiGianVao;
            command.Parameters.Add("@anhxe", SqlDbType.Image).Value = AnhXe.ToArray();
            command.Parameters.Add("@nguoigui", SqlDbType.Image).Value = NguoiGui.ToArray();

            command.Parameters.Add("@hinhThuc", SqlDbType.NVarChar).Value = HinhThucGui;
            command.Parameters.Add("@trangThai", SqlDbType.NVarChar).Value = TrangThai;

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

        public bool updateMoto(string MaTheXe, string LoaiXe, MemoryStream BienSo, MemoryStream NguoiGui, DateTime ThoiGianVao, MemoryStream HieuXe, MemoryStream AnhXe, string HinhThucGui, string TrangThai)
        {

            SqlCommand command = new SqlCommand("UPDATE Xe SET LoaiXe=@loai, BienSo= @bienso,NguoiGui= @nguoigui,ThoiGianVao=@time, HieuXe=@hieuxe, AnhXe=@anhxe, HinhThucGui=@hinhThuc, TrangThaiGui=@trangThai " +
                "WHERE MaTheXe=@ma", mydb.getConnection);

            command.Parameters.Add("@ma", System.Data.SqlDbType.Char).Value = MaTheXe;
            command.Parameters.Add("@loai", System.Data.SqlDbType.NVarChar).Value = LoaiXe;
            command.Parameters.Add("@bienso", System.Data.SqlDbType.Image).Value = BienSo.ToArray();
            command.Parameters.Add("@nguoigui", System.Data.SqlDbType.Image).Value = NguoiGui.ToArray();
            command.Parameters.Add("@time", SqlDbType.DateTime).Value = ThoiGianVao;
            command.Parameters.Add("@hieuxe", SqlDbType.Image).Value = HieuXe.ToArray();
            command.Parameters.Add("@anhxe", SqlDbType.Image).Value = AnhXe.ToArray();

            command.Parameters.Add("@hinhThuc", SqlDbType.NVarChar).Value = HinhThucGui;
            command.Parameters.Add("@trangThai", SqlDbType.NVarChar).Value = TrangThai;

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

        public bool updateBike(string MaTheXe, string LoaiXe, MemoryStream NguoiGui,
                                   MemoryStream AnhXe, DateTime ThoiGianVao, MemoryStream BienSo, MemoryStream HieuXe, string HinhThucGui, string TrangThai)
        {

            SqlCommand command = new SqlCommand("UPDATE Xe SET  LoaiXe=@loai, NguoiGui= @nguoigui, AnhXe= @anhxe,ThoiGianVao=@time, BienSo=@bienso, HieuXe=@hieuxe, TrangThaiGui=@trangThai,HinhThucGui=@hinhThuc " +
                "WHERE MaTheXe=@ma", mydb.getConnection);

            command.Parameters.Add("@ma", System.Data.SqlDbType.Char).Value = MaTheXe;
            command.Parameters.Add("@loai", System.Data.SqlDbType.NVarChar).Value = LoaiXe;

            command.Parameters.Add("@nguoigui", System.Data.SqlDbType.Image).Value = NguoiGui.ToArray();

            command.Parameters.Add("@anhXe", System.Data.SqlDbType.Image).Value = AnhXe.ToArray();
            command.Parameters.Add("@time", SqlDbType.DateTime).Value = ThoiGianVao;

            command.Parameters.Add("@bienso", SqlDbType.Image).Value = BienSo.ToArray();
            command.Parameters.Add("@hieuxe", SqlDbType.Image).Value = HieuXe.ToArray();

            command.Parameters.Add("@hinhThuc", SqlDbType.NVarChar).Value = HinhThucGui;
            command.Parameters.Add("@trangThai", SqlDbType.NVarChar).Value = TrangThai;

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


        public DataTable getVehicle(SqlCommand cmd)
        {
            cmd.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public DataTable getTypeVehicle()
        {
            SqlCommand cmd = new SqlCommand("SELECT DISTINCT LoaiXe FROM Xe");
            cmd.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public DataTable getShapeByID(string id)
        {
            SqlCommand cmd = new SqlCommand("SELECT HinhThucGui FROM Xe WHERE MaTheXe = @id");
            cmd.Connection = mydb.getConnection;
            cmd.Parameters.Add("@id", SqlDbType.Char).Value = id;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public DataTable getStatusByID(string id)
        {
            SqlCommand cmd = new SqlCommand("SELECT TrangThaiGui FROM Xe WHERE MaTheXe = @id");
            cmd.Connection = mydb.getConnection;
            cmd.Parameters.Add("@id", SqlDbType.Char).Value = id;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public bool deleteVehicle(string ma)
        {
            SqlCommand command = new SqlCommand("DELETE FROM Xe WHERE MaTheXe=@ma", mydb.getConnection);
            command.Parameters.Add("@ma", SqlDbType.VarChar).Value = ma;

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

        public string execCount(string query)
        {
            SqlCommand command = new SqlCommand(query, mydb.getConnection);
            mydb.openConnection();

            String count = command.ExecuteScalar().ToString();
            mydb.closeConnection();

            return count;
        }

        public string totalVehicle()
        {
            return execCount("SELECT COUNT(*) FROM Xe");
        }

        public string totalVehicle_out()
        {
            return execCount("SELECT COUNT(*) FROM Xe where TrangThaiGui='Da Lay Xe'");
        }
        public string totalVehicle_in()
        {
            return execCount("SELECT COUNT(*) FROM Xe where TrangThaiGui='Dang Gui'");
        }

        public string totalMotorcycle()
        {
            return execCount("SELECT COUNT(*) FROM Xe WHERE LoaiXe = 'Xe May' ");
        }
        public string totalCar()
        {
            return execCount("SELECT COUNT(*) FROM Xe WHERE LoaiXe = 'Xe Hoi' ");
        }
        public string totalBicycle()
        {
            return execCount("SELECT COUNT(*) FROM Xe WHERE LoaiXe = 'Xe Dap' ");
        }

        public bool updateVehicleOut_Xe(string MaTheXe)
        {

            SqlCommand command = new SqlCommand("UPDATE Xe SET ThoiGianRa=GETDATE(), TrangThaiGui='Da Lay Xe' WHERE MaTheXe = @ma", mydb.getConnection);

            command.Parameters.Add("@ma", System.Data.SqlDbType.VarChar).Value = MaTheXe;


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
      
        public bool updateVehicleOut_DoanhThu(string maTheXe, float total)
        {
            
            SqlCommand command = new SqlCommand("insert INTO DoanhThu(MaTheXe, Total) values (@ma, @total)", mydb.getConnection);

            command.Parameters.Add("@ma", System.Data.SqlDbType.VarChar).Value = maTheXe;
            command.Parameters.Add("@total", SqlDbType.Float).Value = total;

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


        public bool vehicletExist(int mathe)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Xe WHERE MaTheXe=@ma", mydb.getConnection);
            command.Parameters.Add("@ma", SqlDbType.Int).Value = mathe;

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
