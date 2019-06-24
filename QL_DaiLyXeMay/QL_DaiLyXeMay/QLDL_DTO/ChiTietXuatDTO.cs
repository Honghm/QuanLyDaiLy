using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_DaiLyXeMay.QLDL_DTO
{
    public class ChiTietXuatDTO
    {
        public ChiTietXuatDTO(string ma,string ten,string dvt, string sl, string dongia, string thanhtien)
        {
            MaHang = ma;
            TenHang = ten;
            DonViTinh = dvt;
            SoLuong = sl;
            DonGia = dongia;
            ThanhTien = thanhtien;

        }
        public ChiTietXuatDTO(DataRow row)
        {
            MaHang = row["MaMatHang"].ToString();
            TenHang = row["TenMatHang"].ToString();
            DonViTinh = row["DonViTinh"].ToString();
            SoLuong = row["SoLuong"].ToString();
            DonGia = row["DonGia"].ToString();
            ThanhTien = row["ThanhTien"].ToString();
        }
        private string maHang;
        private string tenHang;
        private string donViTinh;
        private string soLuong;
        private string donGia;
        private string thanhTien;

        public string MaHang { get => maHang; set => maHang = value; }
        public string TenHang { get => tenHang; set => tenHang = value; }
        public string DonViTinh { get => donViTinh; set => donViTinh = value; }
        public string SoLuong { get => soLuong; set => soLuong = value; }
        public string DonGia { get => donGia; set => donGia = value; }
        public string ThanhTien { get => thanhTien; set => thanhTien = value; }
    }
}
