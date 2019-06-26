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

namespace QL_DaiLyXeMay.NhanVien
{
    public partial class ucPhieuThuTien : UserControl
    {
        ucDangNhap DangNhap = new ucDangNhap();
        ucTrangChucNang TrangChucNang = new ucTrangChucNang();
        public ucPhieuThuTien()
        {
            InitializeComponent();
        }
        public ucPhieuThuTien(ucDangNhap dangnhap, ucTrangChucNang trangchucnang)
        {
            InitializeComponent();
            DangNhap = dangnhap;
            TrangChucNang = trangchucnang;
        }

        private void ucPhieuThuTien_Load(object sender, EventArgs e)
        {
            cbbMaDaiLy.DataSource = PhieuThuTienDAO.Instance.LoadMaDaiLy();
            cbbMaDaiLy.DisplayMember = "MaDaiLy";
            txbNgayLap.Text = dtpNgayLapPhieu.Text;
            txbNguoiLapPhieu.Text = DangNhap.txbTaiKhoan.Text;

        }

        private void cbbMaDaiLy_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable data = PhieuThuTienDAO.Instance.LoadDataDaiLy(cbbMaDaiLy.Text);
                txbDiaChi.Text = data.Rows[0]["DiaChi"].ToString();
                txbDienThoai.Text = data.Rows[0]["DienThoai"].ToString();
            }
            catch { }
            
        }

        private void dtpNgayLapPhieu_ValueChanged(object sender, EventArgs e)
        {
            txbNgayLap.Text = dtpNgayLapPhieu.Text;
        }

        private void btnLapPhieu_Click(object sender, EventArgs e)
        {
            if(PhieuThuTienDAO.Instance.LapPhieu(txbMaPhieu.Text,cbbMaDaiLy.Text,txbNgayLap.Text,txbSoTienThu.Text,txbNoiDungThuTien.Text))
            {
                if(MessageBox.Show("Lập phiếu thành công","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Exclamation)==DialogResult.OK)
                {
                    txbMaPhieu.Text = "";
                    txbNgayLap.Text = "";
                    txbDiaChi.Text = "";
                    txbDienThoai.Text = "";
                    txbSoTienThu.Text = "";
                    txbNoiDungThuTien.Text = "";
                    cbbMaDaiLy.Text = "";
                    PhieuThuTienDAO.Instance.updateTienNo(txbSoTienThu.Text);
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            TrangChucNang.pnChiTietChucNang.Controls.Clear();
        }

        private void txbSoTienThu_TextChanged(object sender, EventArgs e)
        {
            if (PhieuThuTienDAO.Instance.KiemTraTienThu(cbbMaDaiLy.Text, txbSoTienThu.Text) == false)
                lbNote.Visible = true;
        }
    }
}
