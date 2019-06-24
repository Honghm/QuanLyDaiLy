using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QL_DaiLyXeMay.QLDL_DAO;
using QL_DaiLyXeMay.QLDL_DTO;

namespace QL_DaiLyXeMay.NhanVien
{
    public partial class ucTiepNhanDaiLy : UserControl
    {
        ucDangNhap DangNhap = new ucDangNhap();
        ucTrangChucNang TrangChucNang = new ucTrangChucNang();
        public ucTiepNhanDaiLy()
        {
            InitializeComponent();
        }
        public ucTiepNhanDaiLy(ucDangNhap dangnhap, ucTrangChucNang trangchucnang)
        {
            InitializeComponent();
            DangNhap = dangnhap;
            TrangChucNang = trangchucnang;
        }
        private void btnTaoHoSo_Click(object sender, EventArgs e)
        {
            if (txbMaHoSo.Text.Length == 0 || txbNgayTiepNhan.Text.Length == 0 || txbTenDaiLy.Text.Length == 0 || cbbLoaiHoSo.Text.Length == 0 || cbbQuan.Text.Length == 0 || txbTenDaiLy.Text.Length == 0 || txbSoDienThoai.Text.Length == 0 || txbMaNhanVien.Text.Length == 0)
            {
               
                MessageBox.Show("Tạo hồ sơ thất bại!\n\n Bạn đã bỏ trống trường có dấu (*)", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //Lấy mã loại đại lý từ tên loại đại lý
                string MaLoaiDaiLy = DanhSachDaiLyDAO.Instance.GetMaLoaiDL(cbbLoaiHoSo.Text);
                //Lấy mã quận từ tên quận
                string MaQuan = DanhSachDaiLyDAO.Instance.GetMaQuan(cbbQuan.Text);
                if (DanhSachDaiLyDAO.Instance.TaoMoiHoSo(txbTenDaiLy.Text, MaLoaiDaiLy, txbSoDienThoai.Text, txbEmail.Text, txbDiaChi.Text, MaQuan, txbNgayTiepNhan.Text, txbGhiChu.Text, txbMaNhanVien.Text, txbMaHoSo.Text))
                {
                    if (MessageBox.Show("Tạo hồ sơ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        txbMaHoSo.Text = null;
                        txbTenDaiLy.Text = null;
                        txbDiaChi.Text = null;
                        txbEmail.Text = null;
                        txbGhiChu.Text = null;
                        txbNgayTiepNhan.Text = null;
                        txbSoDienThoai.Text = null;
                        cbbLoaiHoSo.Text = null;
                        cbbQuan.Text = null;
                    }
                }
                else
                    MessageBox.Show("Tạo hồ sơ không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
               
        }

        private void ucTiepNhanDaiLy_Load(object sender, EventArgs e)
        {
            txbMaNhanVien.Text = DangNhap.txbTaiKhoan.Text;
            txbNgayTiepNhan.Text = dtpTiepNhanHoSo.Value.ToString();
        }
        
        private void dtpTiepNhanHoSo_ValueChanged(object sender, EventArgs e)
        {
            txbNgayTiepNhan.Text = dtpTiepNhanHoSo.Value.ToString();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            TrangChucNang.pnChiTietChucNang.Controls.Clear();
        }

        private void txbMaNhanVien_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
