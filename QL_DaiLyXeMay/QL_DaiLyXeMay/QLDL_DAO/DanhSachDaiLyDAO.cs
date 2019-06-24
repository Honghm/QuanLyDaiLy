using QL_DaiLyXeMay.QLDL_DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_DaiLyXeMay.QLDL_DAO
{
    public class DanhSachDaiLyDAO
    {
        private static DanhSachDaiLyDAO instance;
        public static DanhSachDaiLyDAO Instance
        {
            get { if (instance == null) instance = new DanhSachDaiLyDAO(); return DanhSachDaiLyDAO.instance; }
            private set { DanhSachDaiLyDAO.instance = value; }
        }

        private DanhSachDaiLyDAO() { }
        
        public bool Update(string tendl, string maloai, string sdt, string mail, string diachi, string maquan, string ntn, string tienno,
            string ghichi,string manv, string mahs)
        {
            string query = "UPDATE dbo.DAILY SET" +
                " TenDaiLy = N'" + tendl + "', "
                + "MaLoaiDaiLy = '" + maloai + "', "
                + "DienThoai = '" + sdt + "', "
                + "Email = '" + mail + "', "
                + "DiaChi = N'" + diachi + "', "
                + "MaQuan = '" + maquan + "', "
                + "NgayTiepNhan = '" + ntn + "', "
                + "SoNo = '" + tienno + "', "
                + "GhiChu = N'" + ghichi + "', "
                + "MaNhanVien = '" + manv + "'"
                + "WHERE MaDaiLy = '" + mahs + "'";
            int result = Data_SQL.Instance.GetNonQuery(query);
            return result > 0;

        }
        public bool TaoMoiHoSo(string tendl, string maloai, string sdt, string mail, string diachi, string maquan, string ntn,
            string ghichi, string manv, string mahs)
        {
            string query = "INSERT INTO dbo.DAILY( MaDaiLy , TenDaiLy , MaLoaiDaiLy , DienThoai , Email , DiaChi , MaQuan , NgayTiepNhan , SoNo , GhiChu , MaNhanVien )" +
                    " VALUES('" + mahs + "', "
                    + "N'" + tendl + "', "
                    + "'" + maloai + "', "
                    + "'" + sdt + "', "
                    + "'" + mail + "', "
                    + "N'" + diachi + "', "
                    + "'" + maquan + "', "
                    + "'" + ntn + "', "
                    + "'0', "
                    + "N'" + ghichi + "', "
                    + "'" + manv + "')";
            DataTable result = QLDL_DAL.Data_SQL.Instance.GetQuery(query);
            return result.Rows.Count > 0;
        }
        public bool Xoa(string ma)
        {
            int result = Data_SQL.Instance.GetNonQuery("DELETE FROM dbo.DAILY WHERE MaDaiLy = '" + ma + "'");
            return result > 0;
        }
        public DataTable LoadData()
        {
            DataTable temp = Data_SQL.Instance.GetQuery("select MaDaiLy, TenDaiLy from dbo.DAILY");
            return temp;
        }
        public DataTable GetData(string TenCot, string dataCell)
        {
            DataTable temp;
            temp = Data_SQL.Instance.GetQuery("select * from dbo.DAILY where " + TenCot + " = N'" + dataCell + "'");
            return temp;
        }
        public string GetTenLoaiDaiLy(string mahs)
        {
            string name = Data_SQL.Instance.ExecuteScalar("SELECT dbo.LOAIDAILY.TenLoaiDaiLy " +
                "FROM dbo.DAILY, dbo.LOAIDAILY " +
                "WHERE dbo.LOAIDAILY.MaLoaiDaiLy = dbo.DAILY.MaLoaiDaiLy " +
                    "AND dbo.DAILY.MaDaiLy = '" + mahs + "'").ToString();
            return name;
        }
        public string GetTenQuan(string mahs)
        {
            string name = Data_SQL.Instance.ExecuteScalar("SELECT dbo.QUAN.TenQuan " +
                "FROM dbo.DAILY, dbo.QUAN " +
                "WHERE dbo.QUAN.MaQuan = dbo.DAILY.MaQuan " +
                "AND dbo.DAILY.MaDaiLy = '" + mahs + "'").ToString();
            return name;
        }
        public string GetMaLoaiDL(string ten)
        {
            string ma = Data_SQL.Instance.ExecuteScalar("SELECT MaLoaiDaiLy " +
                "FROM dbo.LOAIDAILY WHERE  TenLoaiDaiLy = N'" + ten + "'").ToString();
            return ma;
        }
        public string GetMaQuan(string ten)
        {
            string ma = Data_SQL.Instance.ExecuteScalar("SELECT MaQuan " +
                "FROM dbo.QUAN WHERE  TenQuan = N'" + ten + "'").ToString();
            return ma;
        }
    }
}
