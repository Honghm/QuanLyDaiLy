using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QL_DaiLyXeMay.QLDL_DAL;
using QL_DaiLyXeMay.QLDL_DAO;

namespace QL_DaiLyXeMay.QLDL_GUI
{
    public partial class ucDanhSachPhieuXuat : UserControl
    {
        ucTrangChucNang TrangChucNang = new ucTrangChucNang();
        public ucDanhSachPhieuXuat()
        {
            InitializeComponent();

        }
        public ucDanhSachPhieuXuat(ucTrangChucNang trangchucnang)
        {
            InitializeComponent();
            TrangChucNang = trangchucnang;
        }
        string dataCell;
        private void ucDanhSachPhieuXuat_Load(object sender, EventArgs e)
        {
            dtgvMaPhieuXuat.DataSource = DS_PhieuXuatDAO.Instance.LoadDSMaPhieu();
            dtgvNgayLap.DataSource = DS_PhieuXuatDAO.Instance.LoadDSNgayLap();
            dtgvChiTietPhieuXuat.Enabled = false;
        }

        private void dtgvMaPhieuXuat_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dataCell = dtgvMaPhieuXuat.CurrentCell.Value.ToString();
            dtgvChiTietPhieuXuat.DataSource = DS_PhieuXuatDAO.Instance.LoadCTXH(dataCell);
            DataTable data = DS_PhieuXuatDAO.Instance.LoadDataPhieu(dataCell);
            txbMaDaiLy.Text = data.Rows[0]["MaDaiLy"].ToString();
            txbNguoiLap.Text = data.Rows[0]["MaNhanVien"].ToString();
            txbTongTien.Text = data.Rows[0]["TongTien"].ToString();
            txbTraTruoc.Text = data.Rows[0]["TraTruoc"].ToString();
            txbConLai.Text = data.Rows[0]["TienConLai"].ToString();
        }

        private void txbTraTruoc_TextChanged(object sender, EventArgs e)
        {
            txbConLai.Text = (double.Parse(txbTongTien.Text) - double.Parse(txbTraTruoc.Text)).ToString();
        }

        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            txbMaDaiLy.Enabled = true;
            txbNguoiLap.Enabled = true;
            txbTongTien.Enabled = true;
            txbTraTruoc.Enabled = true;
            txbConLai.Enabled = true;
            dtgvChiTietPhieuXuat.Enabled = true;
           
        }
        
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn xóa phiếu này?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (DS_PhieuXuatDAO.Instance.XoaPhieu(dataCell))
                {
                    if (MessageBox.Show("Xóa thành công", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        dtgvChiTietPhieuXuat.Controls.Clear();
                        dtgvMaPhieuXuat.DataSource = DS_PhieuXuatDAO.Instance.LoadDSMaPhieu();
                        dtgvNgayLap.DataSource = DS_PhieuXuatDAO.Instance.LoadDSNgayLap();
                    }
                }
                else
                    MessageBox.Show("Xóa không thành công", "THÔNG BÁO", MessageBoxButtons.OK);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            TrangChucNang.pnChiTietChucNang.Controls.Clear();
        }
    }
}
