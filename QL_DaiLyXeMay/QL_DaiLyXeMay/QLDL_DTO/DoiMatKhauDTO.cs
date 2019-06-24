using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_DaiLyXeMay.QLDL_DTO
{
    public class DoiMatKhauDTO
    {
        private string mK_Moi;
        private string mK_HienTai;
        private string taiKhoan;
        private string nhapLaiMK;
        public DoiMatKhauDTO(string mk_moi, string mk_hientai, string taikhoan, string nhaplaimk)
        {
            this.MK_HienTai = mk_hientai;
            this.MK_Moi = mk_moi;
            this.TaiKhoan = taikhoan;
            this.NhapLaiMK = nhaplaimk;

        }
        public string MK_Moi { get => mK_Moi; set => mK_Moi = value; }
        public string MK_HienTai { get => mK_HienTai; set => mK_HienTai = value; }
        public string TaiKhoan { get => taiKhoan; set => taiKhoan = value; }
        public string NhapLaiMK { get => nhapLaiMK; set => nhapLaiMK = value; }

        
    }
}
