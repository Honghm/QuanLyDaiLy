using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QL_DaiLyXeMay.QLDL_DAL;
using QL_DaiLyXeMay.QLDL_DTO;

namespace QL_DaiLyXeMay.QLDL_DAO
{
    public class QuanTriVienDAO
    {
        private static QuanTriVienDAO instance;

        public static QuanTriVienDAO Instance
        {
            get { if (instance == null) instance = new QuanTriVienDAO(); return QuanTriVienDAO.instance; }
            private set { QuanTriVienDAO.instance = value; }
        }

        private QuanTriVienDAO() { }
        public string RandomString(int size, bool lowerCase) //Tạo chuỗi ký tự ngẫu nhiên
        {
            StringBuilder builder = new StringBuilder();
            Random random = new Random();
            char ch;
            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }
            if (lowerCase)
                return builder.ToString().ToLower();
            return builder.ToString();
        }
        public int RandomNumber(int min, int max) //Tạo chuỗi số ngẫu nhiên
        {
            Random random = new Random();
            return random.Next(min, max);
        }
        public string GetPassword()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(RandomString(3, true));
            builder.Append(RandomNumber(100, 999));
            return builder.ToString();
        }
        public bool Update(string tentk, string mk,string tennv, string loaitk)
        {
             string query = "UPDATE dbo.TAIKHOAN SET " +
                    "TenNhanVien = N'" + tennv + "', " +
                    "MatKhau = '" + mk + " ', " +
                    "LoaiTaiKhoan = N'" + loaitk + "'" +
                    "WHERE MaNhanVien = '" + tentk + "'";
            int result = Data_SQL.Instance.GetNonQuery(query);
            return result > 0;
            
        }
        public bool TaoMoiTaiKhoan(string tentk, string mk, string tennv, string loaitk)
        {
            string query = "INSERT INTO dbo.TAIKHOAN ( MaNhanVien , TenNhanVien , MatKhau , LoaiTaiKhoan ) " +
                   "VALUES ('" + tentk + "', N'" + tennv + "', '" + mk + " ', N'" + loaitk + "')";
            int result = QLDL_DAL.Data_SQL.Instance.GetNonQuery(query);
            return result > 0;
        }
        public bool Xoa(string tentk)
        {
            int result = Data_SQL.Instance.GetNonQuery("DELETE FROM dbo.TAIKHOAN WHERE MaNhanVien = '" + tentk + "'");
            return result > 0;
        }
        public DataTable LoadData()
        {
            DataTable temp = Data_SQL.Instance.GetQuery("SELECT MaNhanVien, MatKhau FROM dbo.TAIKHOAN");
            return temp;
        }
        public DataTable GetData(string TenCot, string dataCell)
        {
            DataTable temp;
            temp = Data_SQL.Instance.GetQuery("select * from dbo.TAIKHOAN where " + TenCot + " = N'" + dataCell + "'");
            return temp;
        }
    }
}
