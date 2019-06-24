using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using QL_DaiLyXeMay.QuanTriVien;
using System.Data.SqlClient;
using System.Data.Common;
using QL_DaiLyXeMay.QLDL_DAO;

namespace QL_DaiLyXeMay
{
    public partial class ucDangNhap : UserControl
    {
        frmTrangChu TrangChu = new frmTrangChu();
        
        public ucDangNhap()
        {
            InitializeComponent();
            
        }
        public ucDangNhap(frmTrangChu trangchu)
        {
            InitializeComponent();
            TrangChu = trangchu;
        }
        #region Event
        private void txbTaiKhoan_Click(object sender, EventArgs e)
        {
            txbTaiKhoan.ReadOnly = false;
            txbTaiKhoan.Text = "";
        }

        private void txbMatKhau_Click(object sender, EventArgs e)
        {
            txbMatKhau.ReadOnly = false;
            txbMatKhau.Multiline = false;
            txbMatKhau.Text = "";
            txbMatKhau.PasswordChar = '*';
        }
       
        private void lbDangNhap_Click(object sender, EventArgs e)
        {
            ChuyenHuong()
;
        }
        private void llbDoiMatKhau_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmDoiMatKhau DoiMatKhau = new frmDoiMatKhau(TrangChu);
            DoiMatKhau.Show();
            TrangChu.Hide();
            this.Hide();

        }

        private void txbTaiKhoan_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion

        #region Method
        //Chuyển hướng tài khoản
        private void ChuyenHuong()
        {
            if (KiemTra.Instance.KiemTraTaiKhoan(txbTaiKhoan.Text, txbMatKhau.Text) == true)
            {
                switch (KiemTra.Instance.KiemTraLoaiTaiKhoan(txbTaiKhoan.Text))
                {
                    case 0://NhanVien
                        ucTrangChucNang TrangNhanVien = new ucTrangChucNang(this);
                        TrangChu.pnTrangChu.Controls.Clear();
                        TrangChu.pnTrangChu.Controls.Add(TrangNhanVien);
                        break;
                    case 1://Quản lý

                        break;
                    case 2://Quản trị viên
                        ucQuanTriVien QuanTriVien = new ucQuanTriVien(TrangChu);
                        TrangChu.pnTrangChu.Controls.Clear();
                        TrangChu.pnTrangChu.Controls.Add(QuanTriVien);
                        break;
                }
            }
            else
                MessageBox.Show("Tài khoản không tồn tại yêu cầu nhập lại!", "THÔNG BÁO", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
        }
        #endregion



        
    }
}
