using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_DaiLyXeMay.QLDL_DTO
{
    class TaiKhoanDTO
    {
        public TaiKhoanDTO(string tk, string loai, string tennv = null, string mk = null)
        {
            this.MatKhau = mk;
            this.TenTaiKhoan = tk;
            this.LoaiTaiKhoan = loai;
            this.TenNhanVien = tennv;

        }
        public TaiKhoanDTO(DataRow row)
        {
            this.MatKhau = row["MatKhau"].ToString();
            this.TenTaiKhoan = row["MaNhanVien"].ToString();
            this.LoaiTaiKhoan = row["LoaiTaiKhoan"].ToString();
            this.TenNhanVien = row["TenNhanVien"].ToString();
        }
        private string tenNhanVien;
        private string matKhau;
        private string tenTaiKhoan;
        private string loaiTaiKhoan;
        public string MatKhau { get => matKhau; set => matKhau = value; }
        public string TenTaiKhoan { get => tenTaiKhoan; set => tenTaiKhoan = value; }
        public string LoaiTaiKhoan { get => loaiTaiKhoan; set => loaiTaiKhoan = value; }
        public string TenNhanVien { get => tenNhanVien; set => tenNhanVien = value; }
    }
}
