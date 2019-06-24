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

namespace QL_DaiLyXeMay
{
    public partial class ucDanhSachDaiLy : UserControl
    {
        ucTrangChucNang TrangChucNang = new ucTrangChucNang();
        ucDangNhap DangNhap = new ucDangNhap();
        public ucDanhSachDaiLy()
        {
            InitializeComponent();
        }
        public ucDanhSachDaiLy(ucTrangChucNang trangchucnang, ucDangNhap dangnhap)
        {
            InitializeComponent();
            TrangChucNang = trangchucnang;
            DangNhap = dangnhap;
        }
       
        private void ucDanhSachDaiLy_Load(object sender, EventArgs e)
        {
            dtgvDanhSachDaiLy.DataSource = DanhSachDaiLyDAO.Instance.LoadData();
            dtgvDanhSachDaiLy.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            txbDiaChi.ReadOnly = true;
            txbEMail.ReadOnly = true;
            txbGhiChu.ReadOnly = true;
            txbMaHoSo.ReadOnly = true;
            txbMaNhanVien.ReadOnly = true;
            txbNgayTiepNhan.ReadOnly = true;
            txbSoDienThoai.ReadOnly = true;
            txbTenDaiLy.ReadOnly = true;
            txbTienNo.ReadOnly = true;
            cbbLoaiDaiLy.Enabled = false;
            cbbQuan.Enabled = false;
            if(KiemTra.Instance.KiemTraLoaiTaiKhoan(DangNhap.txbTaiKhoan.Text)==1)
            {
                btnXoa.Enabled = true;
            }
            else
                btnXoa.Enabled = false; 
        }
        
        private void dtgvDanhSachDaiLy_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                string NameHeader = dtgvDanhSachDaiLy.Columns[e.ColumnIndex].HeaderText.ToString();//Lấy tên header của ô được trỏ tới
                string dataCell = dtgvDanhSachDaiLy.CurrentCell.Value.ToString(); //Lấy dữ liệu tại ô được click

                dtgvTemp.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dtgvTemp.DataSource = DanhSachDaiLyDAO.Instance.GetData(NameHeader, dataCell);
                txbMaHoSo.Text = dtgvTemp.CurrentRow.Cells[0].Value.ToString();
                txbTenDaiLy.Text = dtgvTemp.CurrentRow.Cells[1].Value.ToString();

                txbSoDienThoai.Text = dtgvTemp.CurrentRow.Cells[3].Value.ToString();
                txbEMail.Text = dtgvTemp.CurrentRow.Cells[4].Value.ToString();
                txbDiaChi.Text = dtgvTemp.CurrentRow.Cells[5].Value.ToString();

                txbNgayTiepNhan.Text = dtgvTemp.CurrentRow.Cells[7].Value.ToString();
                txbTienNo.Text = dtgvTemp.CurrentRow.Cells[8].Value.ToString();
                txbGhiChu.Text = dtgvTemp.CurrentRow.Cells[9].Value.ToString();
                txbMaNhanVien.Text = dtgvTemp.CurrentRow.Cells[10].Value.ToString();

                //Lấy tên loại đại lý từ mã đại lý
                cbbLoaiDaiLy.Text = DanhSachDaiLyDAO.Instance.GetTenLoaiDaiLy(txbMaHoSo.Text);
                //Lấy tên quận từ mã quận
                cbbQuan.Text = DanhSachDaiLyDAO.Instance.GetTenQuan(txbMaHoSo.Text);
            }
            catch { }
            
        }

        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            txbDiaChi.ReadOnly = false;
            txbEMail.ReadOnly = false;
            txbGhiChu.ReadOnly = false;
            txbMaHoSo.ReadOnly = false;
            txbMaNhanVien.ReadOnly = false;
            txbNgayTiepNhan.ReadOnly = false;
            txbSoDienThoai.ReadOnly = false;
            txbTenDaiLy.ReadOnly = false;
            txbTienNo.ReadOnly = false;
            cbbLoaiDaiLy.Enabled = true;
            cbbQuan.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            //Lấy mã loại đại lý từ tên loại đại lý
            string MaLoaiDaiLy = DanhSachDaiLyDAO.Instance.GetMaLoaiDL(cbbLoaiDaiLy.Text);
            //Lấy mã quận từ tên quận
            string MaQuan = DanhSachDaiLyDAO.Instance.GetMaQuan(cbbQuan.Text);
           if(DanhSachDaiLyDAO.Instance.Update(txbTenDaiLy.Text,MaLoaiDaiLy,txbSoDienThoai.Text,
               txbEMail.Text,txbDiaChi.Text,MaQuan,txbNgayTiepNhan.Text,txbTienNo.Text,txbGhiChu.Text,txbMaNhanVien.Text,txbMaHoSo.Text))
            if(MessageBox.Show("chỉnh sửa thành công","THÔNG BÁO",MessageBoxButtons.OK,MessageBoxIcon.Information)==DialogResult.OK)
            {
                txbDiaChi.ReadOnly = true;
                txbEMail.ReadOnly = true;
                txbGhiChu.ReadOnly = true;
                txbMaHoSo.ReadOnly = true;
                txbMaNhanVien.ReadOnly = true;
                txbNgayTiepNhan.ReadOnly = true;
                txbSoDienThoai.ReadOnly = true;
                txbTenDaiLy.ReadOnly = true;
                txbTienNo.ReadOnly = true;
                cbbLoaiDaiLy.Enabled = false;
                cbbQuan.Enabled = false;
                dtgvDanhSachDaiLy.DataSource = DanhSachDaiLyDAO.Instance.LoadData();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (KiemTra.Instance.KiemTraLoaiTaiKhoan(DangNhap.txbTaiKhoan.Text) == 1)
            {
                if (MessageBox.Show("Bạn chắc chắn muốn xóa đại lý này?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (DanhSachDaiLyDAO.Instance.Xoa(txbMaHoSo.Text))
                    {
                        if (MessageBox.Show("Xóa thành công", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                        {
                            dtgvDanhSachDaiLy.DataSource = DanhSachDaiLyDAO.Instance.LoadData();
                        }
                    }
                    else
                        MessageBox.Show("Xóa không thành công", "THÔNG BÁO", MessageBoxButtons.OK);
                }
            }
            else
                MessageBox.Show("Bạn không có quyền truy cập chức năng này!!", "Cảnh báo");
           
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            TrangChucNang.pnChiTietChucNang.Controls.Clear();
        }
    }
}
