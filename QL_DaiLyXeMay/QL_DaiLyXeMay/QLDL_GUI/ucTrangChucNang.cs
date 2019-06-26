﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QL_DaiLyXeMay.QLDL_GUI;
using QL_DaiLyXeMay.NhanVien;
using QL_DaiLyXeMay.QuanLy;
using QL_DaiLyXeMay.QLDL_DAO;

namespace QL_DaiLyXeMay
{
    public partial class ucTrangChucNang : UserControl
    {
        ucDangNhap DangNhap = new ucDangNhap();
        public ucTrangChucNang()
        {
            InitializeComponent();
        }
        public ucTrangChucNang(ucDangNhap dangnhap)
        {
            InitializeComponent();
            DangNhap = dangnhap;
           
        }
        #region Chức năng Quản Lý
        //lbQuanLy
        private void lbQuanLy_Click(object sender, EventArgs e)
        {
            if (pnQuanLy.Visible == false)
                pnQuanLy.Visible = true;
            else
                pnQuanLy.Visible = false;
        }

        //lbTiepNhanDaiLy
        private void lbTiepNhanDaiLy_Click(object sender, EventArgs e)
        {
            ucTiepNhanDaiLy TaoHoSo = new ucTiepNhanDaiLy(DangNhap,this);
            pnChiTietChucNang.Controls.Clear();
            pnChiTietChucNang.Controls.Add(TaoHoSo);
            
        }

        //lbDanhSachDaiLy
        private void lbDanhSachDaiLy_Click(object sender, EventArgs e)
        {
            ucDanhSachDaiLy DanhSachDaiLy = new ucDanhSachDaiLy(this,DangNhap);
            pnChiTietChucNang.Controls.Clear();
            pnChiTietChucNang.Controls.Add(DanhSachDaiLy);
        }

        #endregion

        #region Chức năng Lập phiếu
        //lbLapPhieu
        private void lbLapPhieu_Click(object sender, EventArgs e)
        {
            if (pnLapPhieu.Visible == false)
                pnLapPhieu.Visible = true;
            else
                pnLapPhieu.Visible = false;
        }

        private void lbPhieuXuatHang_Click(object sender, EventArgs e)
        {
            ucPhieuXuatHang PhieuXuatHang = new ucPhieuXuatHang(DangNhap,this);
            pnChiTietChucNang.Controls.Clear();
            pnChiTietChucNang.Controls.Add(PhieuXuatHang);
        }

        private void lbPhieuThuTien_Click(object sender, EventArgs e)
        {
            ucPhieuThuTien PhieuThuTien = new ucPhieuThuTien(DangNhap,this);
            pnChiTietChucNang.Controls.Clear();
            pnChiTietChucNang.Controls.Add(PhieuThuTien);
        }
        private void lbDS_PhieuXuat_Click(object sender, EventArgs e)
        {
            if (KiemTra.Instance.KiemTraLoaiTaiKhoan(DangNhap.txbTaiKhoan.Text) == 1)
            {
                ucDanhSachPhieuXuat DSPhieuXuat = new ucDanhSachPhieuXuat();
                pnChiTietChucNang.Controls.Clear();
                pnChiTietChucNang.Controls.Add(DSPhieuXuat);
            }
            else
                MessageBox.Show("Bạn không có quyền truy cập chức năng này!!", "Cảnh báo");
            
        }
        #endregion

        #region Chức năng Lập Báo cáo

        private void lbLapBaoCao_Click(object sender, EventArgs e)
        {
            if (pnLapBaoCao.Visible == false)
                pnLapBaoCao.Visible = true;
            else
                pnLapBaoCao.Visible = false;
        }

        private void lbLapBaoCaoThang_Click(object sender, EventArgs e)
        {
            ucBaoCaoDoanhSo BaoCaoDoanhSo = new ucBaoCaoDoanhSo();
            pnChiTietChucNang.Controls.Clear();
            pnChiTietChucNang.Controls.Add(BaoCaoDoanhSo);
        }

        private void lbLapBaoCaoCongNo_Click(object sender, EventArgs e)
        {
            ucBaoCaoNoCong BaoCaoNoCong = new ucBaoCaoNoCong();
            pnChiTietChucNang.Controls.Clear();
            pnChiTietChucNang.Controls.Add(BaoCaoNoCong);
        }

        #endregion

 
        //Chức năng thay đổi quy định
        private void lbThayDoiQuyDinh_Click(object sender, EventArgs e)
        {
            ucThayDoiQuyDinh ThayDoiQuyDinh = new ucThayDoiQuyDinh();
            pnChiTietChucNang.Controls.Clear();
            pnChiTietChucNang.Controls.Add(ThayDoiQuyDinh);
        }
        
        #region Xử lý sự kiện chuột của các label
        #region lbQuanLy
        private void lbQuanLy_MouseLeave(object sender, EventArgs e)
        {
            lbQuanLy.ForeColor = Color.White;
        }

        private void lbQuanLy_MouseMove(object sender, MouseEventArgs e)
        {
            lbQuanLy.ForeColor = Color.Red;
        }
        #endregion

        #region lbTiepNhanDaiLy
        private void lbTiepNhanDaiLy_MouseLeave(object sender, EventArgs e)
        {
            lbTiepNhanDaiLy.ForeColor = Color.White;
        }

        private void lbTiepNhanDaiLy_MouseMove(object sender, MouseEventArgs e)
        {
            lbTiepNhanDaiLy.ForeColor = Color.Red;
        }
        #endregion

        #region lbDanhSachDaiLy
        private void lbDanhSachDaiLy_MouseLeave(object sender, EventArgs e)
        {
            lbDanhSachDaiLy.ForeColor = Color.White;
        }

        private void lbDanhSachDaiLy_MouseMove(object sender, MouseEventArgs e)
        {
            lbDanhSachDaiLy.ForeColor = Color.Red;
        }
        #endregion

        #region lbLapPhieu
        private void lbLapPhieu_MouseLeave(object sender, EventArgs e)
        {
            lbLapPhieu.ForeColor = Color.White;
        }

        private void lbLapPhieu_MouseMove(object sender, MouseEventArgs e)
        {
            lbLapPhieu.ForeColor = Color.Red;
        }

        #endregion

        #region lbPhieuXuatHang
        private void lbPhieuXuatHang_MouseLeave(object sender, EventArgs e)
        {
            lbPhieuXuatHang.ForeColor = Color.White;
        }

        private void lbPhieuXuatHang_MouseMove(object sender, MouseEventArgs e)
        {
            lbPhieuXuatHang.ForeColor = Color.Red;
        }
        #endregion

        #region lbPhieuThuTien
        private void lbPhieuThuTien_MouseLeave(object sender, EventArgs e)
        {
            lbPhieuThuTien.ForeColor = Color.White;
        }

        private void lbPhieuThuTien_MouseMove(object sender, MouseEventArgs e)
        {
            lbPhieuThuTien.ForeColor = Color.Red;
        }
        private void lbDS_PhieuXuat_MouseLeave(object sender, EventArgs e)
        {
            lbDS_PhieuXuat.ForeColor = Color.White;
        }

        private void lbDS_PhieuXuat_MouseMove(object sender, MouseEventArgs e)
        {
            lbDS_PhieuXuat.ForeColor = Color.Red;
        }
        #endregion

        #region lbLapBaoCao
        private void lbLapBaoCao_MouseLeave(object sender, EventArgs e)
        {
            lbLapBaoCao.ForeColor = Color.White;
        }

        private void lbLapBaoCao_MouseMove(object sender, MouseEventArgs e)
        {
            lbLapBaoCao.ForeColor = Color.Red;
        }

        #endregion

        #region lbLapBaoCaoThang
        private void lbLapBaoCaoThang_MouseLeave(object sender, EventArgs e)
        {
            lbLapBaoCaoThang.ForeColor = Color.White;
        }

        private void lbLapBaoCaoThang_MouseMove(object sender, MouseEventArgs e)
        {
            lbLapBaoCaoThang.ForeColor = Color.Red;
        }

        #endregion

        #region lbLapBaoCaoNoCong
        private void lbLapBaoCaoCongNo_MouseLeave(object sender, EventArgs e)
        {
            lbLapBaoCaoCongNo.ForeColor = Color.White;
        }

        private void lbLapBaoCaoCongNo_MouseMove(object sender, MouseEventArgs e)
        {
            lbLapBaoCaoCongNo.ForeColor = Color.Red;
        }

        #endregion

        #region lbThayDoiQuyDinh
        private void lbThayDoiQuyDinh_MouseLeave(object sender, EventArgs e)
        {
            lbThayDoiQuyDinh.ForeColor = Color.White;
        }

        private void lbThayDoiQuyDinh_MouseMove(object sender, MouseEventArgs e)
        {
            lbThayDoiQuyDinh.ForeColor = Color.Red;
        }







        #endregion

        #endregion

        private void LbTimKiem_Click(object sender, EventArgs e)
        {
            ucTimDaiLy timDaiLy = new ucTimDaiLy();
            pnChiTietChucNang.Controls.Clear();
            pnChiTietChucNang.Controls.Add(timDaiLy);
        }
    }
}
