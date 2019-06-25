using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QL_DaiLyXeMay.QLDL_DTO;

namespace QL_DaiLyXeMay.QLDL_DAO
{
    public class KiemTra
    {
        private static KiemTra instance;

        public static KiemTra Instance
        {
            get { if (instance == null) instance = new KiemTra(); return KiemTra.instance; }
            private set { KiemTra.instance = value; }
        }

        private KiemTra() { }
        public bool KiemTraTaiKhoan(string TaiKhoan, string MatKhau)
        {
            return true;//bỏ qua bước đăng nhập, test
            string query = "SELECT MaNhanVien" +
                " FROM dbo.TAIKHOAN WHERE MaNhanVien = '" + TaiKhoan + "' AND MatKhau = '" + MatKhau + "'";
            DataTable result = QLDL_DAL.Data_SQL.Instance.GetQuery(query);
            return result.Rows.Count > 0;

        }
        public int KiemTraLoaiTaiKhoan(string TenTaiKhoan)
        {
            return 0;//set quyền vì đã bỏ qua bước đăng nhập, test
            string query = "SELECT LoaiTaiKhoan" +
                " FROM dbo.TAIKHOAN WHERE MaNhanVien = '" + TenTaiKhoan + "'";

            object get_Data = QLDL_DAL.Data_SQL.Instance.ExecuteScalar(query);
            switch (get_Data.ToString())
            {
                case "Quản lý":
                case "Quản Lý":
                case "quản lý":
                    {
                        return 1;
                        break;
                    }

                case "Quản trị viên":
                case "Quản Trị Viên":
                case "quản trị viên":
                    {
                        return 2;
                        break;
                    }
            }
            return 0;
        }
    }
}
