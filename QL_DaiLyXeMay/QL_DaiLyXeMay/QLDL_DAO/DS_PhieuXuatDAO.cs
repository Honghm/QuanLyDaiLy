using QL_DaiLyXeMay.QLDL_DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_DaiLyXeMay.QLDL_DAO
{
    public class DS_PhieuXuatDAO
    {
        private static DS_PhieuXuatDAO instance;

        public static DS_PhieuXuatDAO Instance
        {
            get { if (instance == null) instance = new DS_PhieuXuatDAO(); return DS_PhieuXuatDAO.instance; }
            private set { DS_PhieuXuatDAO.instance = value; }
        }

        private DS_PhieuXuatDAO() { }
        public bool XoaPhieu(string ma)
        {
            int result = Data_SQL.Instance.GetNonQuery("DELETE dbo.CHITIETXUAT WHERE MaPhieuXuatHang = '" + ma + "'");
            int result1 = 0;
            if (result > 0)
            {
                result1 = Data_SQL.Instance.GetNonQuery("DELETE dbo.PHIEUXUATHANG WHERE MaPhieuXuatHang = '" + ma + "'");
            }

            return result1 > 0;
        }
       
        public DataTable LoadDSMaPhieu()
        {
            DataTable data = Data_SQL.Instance.GetQuery("SELECT MaPhieuXuatHang AS MaPhieuXuat FROM dbo.PHIEUXUATHANG");
            return data;
        }
        public DataTable LoadDataPhieu(string maphieu)
        {
            DataTable data = Data_SQL.Instance.GetQuery("SELECT MaDaiLy,MaNhanVien,TongTien,TraTruoc,TienConLai FROM dbo.PHIEUXUATHANG WHERE MaPhieuXuatHang = '"+ maphieu +"'");
            return data;
        }
        public DataTable LoadDSNgayLap()
        {
            DataTable data = Data_SQL.Instance.GetQuery("SELECT NgayLap FROM dbo.PHIEUXUATHANG");
            return data;
        }
        public DataTable LoadCTXH(string maphieu)
        {
            string query = "SELECT dbo.CHITIETXUAT.MaMatHang, TenMatHang, DonViTinh, SoLuong, DonGia, ThanhTien " +
                "FROM dbo.CHITIETXUAT,dbo.MATHANG " +
                "WHERE MaPhieuXuatHang = '" + maphieu + "'";
            DataTable data = Data_SQL.Instance.GetQuery(query);
            return data;
        }
    }
}
