using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QL_DaiLyXeMay.QLDL_DAO;
using QL_DaiLyXeMay.QLDL_DTO;

namespace QL_DaiLyXeMay
{
    public partial class ucPhieuXuatHang : UserControl
    {
        int dong;
        ucDangNhap DangNhap = new ucDangNhap();
        ucTrangChucNang TrangChucNang = new ucTrangChucNang();
        public ucPhieuXuatHang()
        {
            InitializeComponent();
           
            
        }
        public ucPhieuXuatHang(ucDangNhap dangnhap, ucTrangChucNang trangchucnang)
        {
            InitializeComponent();
            DangNhap = dangnhap;
            TrangChucNang = trangchucnang;
           
        }

        private void ucPhieuXuatHang_Load(object sender, EventArgs e)
        {
            LoadMatHang();
            txbNguoiLapPhieu.Text = DangNhap.txbTaiKhoan.Text;
            txbNgayLapPhieu.Text = dtpNgayLapPhieu.Value.ToString();
            txbConLai.Text = (double.Parse(txbTongTien.Text) * double.Parse(txbTraTruoc.Text)).ToString();
            cbbMaDaiLy.DataSource = PhieuXuatHangDAO.Instance.LoadDSDL();
            cbbMaDaiLy.DisplayMember = "MaDaiLy";
            
        }
        void LoadMatHang()
        {
            List<MatHangDTO> MatHang = MatHangDAO.Instance.GetListMatHang();
            MaMatHang.DataSource = MatHang;
            MaMatHang.DisplayMember = "MaMatHang";
            dtgvChiTietDonHang.Rows[0].Cells[0].Value = MatHang[0].MaMatHang.ToString();
            dtgvChiTietDonHang.Rows[0].Cells[1].Value = MatHang[0].TenMatHang.ToString();
            dtgvChiTietDonHang.Rows[0].Cells[2].Value = MatHang[0].DonViTinh.ToString();
            dtgvChiTietDonHang.Rows[0].Cells[4].Value = MatHang[0].DonGia.ToString();
        }


        private void btnLapPhieu_Click(object sender, EventArgs e)
        {
            if (PhieuXuatHangDAO.Instance.LapPhieu(txbMaPhieu.Text,cbbMaDaiLy.Text,txbTongTien.Text,txbTraTruoc.Text,txbNgayLapPhieu.Text,txbNguoiLapPhieu.Text,txbConLai.Text))
            {
                if(PhieuXuatHangDAO.Instance.ChiTietPhieu(txbMaPhieu.Text, dtgvChiTietDonHang.Rows[dong].Cells[0].Value.ToString(), dtgvChiTietDonHang.Rows[dong].Cells[3].Value.ToString(), dtgvChiTietDonHang.Rows[dong].Cells[5].Value.ToString()))
                {
                    if (MessageBox.Show("Lập phiếu thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation) == DialogResult.OK)
                    {
                        txbMaPhieu.Text = "";
                        cbbMaDaiLy.Text = "";
                        txbTongTien.Text = "0";
                        txbTraTruoc.Text = "0";
                        txbNgayLapPhieu.Text = "";
                        txbNguoiLapPhieu.Text = "";
                        PhieuXuatHangDAO.Instance.updateTienNo(txbConLai.Text);
                    }
                }
               
            }
            else
                MessageBox.Show("Lập phiếu không thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
       
        private void txbNgayLapPhieu_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void dtpNgayLapPhieu_ValueChanged(object sender, EventArgs e)
        {
            txbNgayLapPhieu.Text = dtpNgayLapPhieu.Value.ToString();
        }


        double tong = 0;
        private void dtgvChiTietDonHang_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            
            
            
        }

        private void dtgvChiTietDonHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dong = e.RowIndex;

        }

        private void dtgvChiTietDonHang_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable temp = MatHangDAO.Instance.LoadData(dtgvChiTietDonHang.Rows[dong].Cells[0].Value.ToString());
                dtgvChiTietDonHang.CurrentRow.Cells[1].Value = temp.Rows[0]["TenMatHang"].ToString();
                dtgvChiTietDonHang.CurrentRow.Cells[2].Value = temp.Rows[0]["DonViTinh"].ToString();
                dtgvChiTietDonHang.CurrentRow.Cells[4].Value = temp.Rows[0]["DonGia"].ToString();
                dtgvChiTietDonHang.Rows[dong].Cells[5].Value = ((double.Parse(dtgvChiTietDonHang.Rows[dong].Cells[3].Value.ToString())) * (double.Parse(dtgvChiTietDonHang.Rows[dong].Cells[4].Value.ToString()))).ToString();
                if (dtgvChiTietDonHang.Rows[dong].Cells[3].Value != "0" && dtgvChiTietDonHang.Rows[dong].Cells[4].Value != "0")
                {
                    tong = double.Parse(dtgvChiTietDonHang.Rows[dong].Cells[5].Value.ToString());
                }
                txbTongTien.Text = (double.Parse(txbTongTien.Text) + tong).ToString();
            }
            catch { }
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            TrangChucNang.pnChiTietChucNang.Controls.Clear();
        }
    }
}
