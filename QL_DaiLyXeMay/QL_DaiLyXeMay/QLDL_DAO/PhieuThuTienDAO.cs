using QL_DaiLyXeMay.QLDL_DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_DaiLyXeMay.QLDL_DAO
{
    public class PhieuThuTienDAO
    {
        private static PhieuThuTienDAO instance;

        public static PhieuThuTienDAO Instance
        {
            get { if (instance == null) instance = new PhieuThuTienDAO(); return PhieuThuTienDAO.instance; }
            private set { PhieuThuTienDAO.instance = value; }
        }

        private PhieuThuTienDAO() { }

        public DataTable LoadDataDaiLy(string ma)
        {
            DataTable data = Data_SQL.Instance.GetQuery("SELECT DienThoai, DiaChi FROM dbo.DAILY WHERE MaDaiLy = '"+ ma +"'");
            return data;
        }
        public DataTable LoadMaDaiLy()
        {
            DataTable data = Data_SQL.Instance.GetQuery("SELECT MaDaiLy FROM dbo.DAILY");
            return data;
        }
        public bool LapPhieu(string maphieu,string madl,string ngaythu,string sotien,string noidung)
        {
            string query = "INSERT INTO dbo.PHIEUTHUTIEN(MaPhieuThuTien, MaDaiLy, NgayThuTien, SoTienThu, NoiDung)" +
                               "VALUES('" + maphieu + "', '" + madl + "', '" + ngaythu + "', '" + sotien + "', N'" + noidung + "')";
            int result = Data_SQL.Instance.GetNonQuery(query);
            return result > 0;
        }
        public bool KiemTraTienThu(string ma, string tienthu)
        {
            string a = Data_SQL.Instance.ExecuteScalar("SELECT SoNo FROM dbo.DAILY WHERE MaDaiLy = '" + ma + "'").ToString();
            if (double.Parse(tienthu) > double.Parse(a))
                return true;
            return false;
        }
        public void updateTienNo(string tien)
        {
            Data_SQL.Instance.GetNonQuery("UPDATE dbo.DAILY SET SoNo = '" + tien + "'");
        }
      
    }
}
