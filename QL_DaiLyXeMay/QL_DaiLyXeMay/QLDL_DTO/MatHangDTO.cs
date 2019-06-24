using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_DaiLyXeMay.QLDL_DTO
{
    public class MatHangDTO
    {
        public MatHangDTO(string ma, string ten, string dongia,string dvt)
        {
            this.MaMatHang = ma;
            this.TenMatHang = ten;
            this.DonGia = dongia;
            this.DonViTinh = dvt;
        }
        public MatHangDTO(DataRow row)
        {
            this.MaMatHang = row["MaMatHang"].ToString();
            this.TenMatHang = row["TenMatHang"].ToString();
            this.DonGia = row["DonGia"].ToString();
            this.DonViTinh = row["DonViTinh"].ToString();
        }
        private string maMatHang;
        private string tenMatHang;
        private string donGia;
        private string donViTinh;

        public string MaMatHang { get => maMatHang; set => maMatHang = value; }
        public string TenMatHang { get => tenMatHang; set => tenMatHang = value; }
        public string DonGia { get => donGia; set => donGia = value; }
        public string DonViTinh { get => donViTinh; set => donViTinh = value; }
    }
}
