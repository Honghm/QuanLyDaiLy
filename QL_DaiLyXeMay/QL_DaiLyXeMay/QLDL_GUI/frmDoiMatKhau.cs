using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QL_DaiLyXeMay.QLDL_DTO;
using QL_DaiLyXeMay.QLDL_DAO;

namespace QL_DaiLyXeMay
{
    public partial class frmDoiMatKhau : Form
    {
        frmTrangChu TrangChu = new frmTrangChu();
        public frmDoiMatKhau(frmTrangChu trangchu)
        {
            InitializeComponent();
            TrangChu = trangchu;

        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            ucDangNhap DangNhap = new ucDangNhap(TrangChu);
            if (txbTaiKhoan.Text != "" || txbMatKhauHienTai.Text != "" || txbMatKhauMoi.Text != "" || txbNhapLaiMatKhau.Text != "")
            {
                if (DoiMatKhauDAO.Instance.DoiMatKhau(txbTaiKhoan.Text,txbMatKhauMoi.Text, txbMatKhauHienTai.Text,txbNhapLaiMatKhau.Text))
                {
                    if (MessageBox.Show("Cập nhật mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK) == DialogResult.OK)
                    {
                        TrangChu.Show();
                        TrangChu.pnTrangChu.Controls.Clear();
                        TrangChu.pnTrangChu.Controls.Add(DangNhap);
                        this.Close();
                    }
                }
                else if (MessageBox.Show("Cập nhật mật khẩu thất bại!", "Thông báo", MessageBoxButtons.OK) == DialogResult.OK)
                {
                    txbTaiKhoan.Text = "";
                    txbMatKhauHienTai.Text = "";
                    txbMatKhauMoi.Text = "";
                    txbNhapLaiMatKhau.Text = "";
                }

            }
            
        }
       
        private void btnThoat_Click(object sender, EventArgs e)
        {
            ucDangNhap DangNhap = new ucDangNhap(TrangChu);
            TrangChu.Show();
            this.Close();
            TrangChu.pnTrangChu.Controls.Clear();
            TrangChu.pnTrangChu.Controls.Add(DangNhap);
        }
    }
}
