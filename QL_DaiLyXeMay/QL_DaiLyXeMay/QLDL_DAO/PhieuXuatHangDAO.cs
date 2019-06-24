using QL_DaiLyXeMay.QLDL_DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QL_DaiLyXeMay.QLDL_DTO;

namespace QL_DaiLyXeMay.QLDL_DAO
{
    public class PhieuXuatHangDAO
    {
        private static PhieuXuatHangDAO instance;

        public static PhieuXuatHangDAO Instance
        {
            get { if (instance == null) instance = new PhieuXuatHangDAO(); return PhieuXuatHangDAO.instance; }
            private set { PhieuXuatHangDAO.instance = value; }
        }

        private PhieuXuatHangDAO() { }
        public List<ChiTietXuatDTO> GetListChiTietHang(string maphieu)
        {
            List<ChiTietXuatDTO> list = new List<ChiTietXuatDTO>();
            string query = "SELECT dbo.CHITIETXUAT.MaMatHang, TenMatHang, DonViTinh, SoLuong, DonGia, ThanhTien " +
                "FROM dbo.CHITIETXUAT,dbo.MATHANG " +
                "WHERE MaPhieuXuatHang = '" + maphieu + "'";
            DataTable data = Data_SQL.Instance.GetQuery(query);
            foreach (DataRow item in data.Rows)
            {
                ChiTietXuatDTO CTXH = new ChiTietXuatDTO(item);
                list.Add(CTXH);
            }
            return list;
        }
      
       
        public DataTable LoadDSDL()
        {
            DataTable data = Data_SQL.Instance.GetQuery("SELECT MaDaiLy FROM dbo.DAILY");
            return data;
        }
        public DataTable GetDataPhieuXuat(string dataCell)
        {
            DataTable temp;
            temp = Data_SQL.Instance.GetQuery("select * from dbo.PHIEUXUATHANG where MaPhieuXuatHang = N'" + dataCell + "'");
            return temp;
        }
       
        public bool LapPhieu(string maphieu,string madl,string tonggiatri,string tratruoc, string ngaylap, string manv, string tiencon)
        {
            string query = "INSERT INTO dbo.PHIEUXUATHANG( MaPhieuXuatHang ,MaDaiLy ,TraTruoc ,NgayLap ,MaNhanVien ,TienConLai,TongTien)" +
                            " VALUES('" + maphieu + "', '" + madl + "', '" + tratruoc + "', '" 
                            + ngaylap+ "', '" + manv + "', '" + tiencon + "', '" + tonggiatri + "')";
            int result = QLDL_DAL.Data_SQL.Instance.GetNonQuery(query);
            return result > 0;
        }
        
        public bool ChiTietPhieu(string maphieu,string mamh,string sl,string thanhtien)
        {
            string query = "INSERT INTO dbo.CHITIETXUAT(MaPhieuXuatHang ,MaMatHang ,SoLuong ,ThanhTien)" +
                            " VALUES('" + maphieu + "', '" + mamh + "', '" + sl + "', '"+ thanhtien + "')";
            int result = QLDL_DAL.Data_SQL.Instance.GetNonQuery(query);
            return result > 0;
        }
    }
}
