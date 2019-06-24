namespace QL_DaiLyXeMay.QLDL_GUI
{
    partial class ucDanhSachPhieuXuat
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtgvMaPhieuXuat = new System.Windows.Forms.DataGridView();
            this.dtgvChiTietPhieuXuat = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lbChiTietXuat = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.dtgvNgayLap = new System.Windows.Forms.DataGridView();
            this.txbConLai = new System.Windows.Forms.TextBox();
            this.txbTraTruoc = new System.Windows.Forms.TextBox();
            this.txbTongTien = new System.Windows.Forms.TextBox();
            this.lbConLai = new System.Windows.Forms.Label();
            this.lbTraTruoc = new System.Windows.Forms.Label();
            this.lbTongTien = new System.Windows.Forms.Label();
            this.lbMaDaiLy = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbMaDaiLy = new System.Windows.Forms.TextBox();
            this.txbNguoiLap = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMaPhieuXuat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChiTietPhieuXuat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvNgayLap)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvMaPhieuXuat
            // 
            this.dtgvMaPhieuXuat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvMaPhieuXuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvMaPhieuXuat.Location = new System.Drawing.Point(17, 112);
            this.dtgvMaPhieuXuat.Name = "dtgvMaPhieuXuat";
            this.dtgvMaPhieuXuat.RowTemplate.Height = 24;
            this.dtgvMaPhieuXuat.Size = new System.Drawing.Size(165, 525);
            this.dtgvMaPhieuXuat.TabIndex = 0;
            this.dtgvMaPhieuXuat.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgvMaPhieuXuat_CellMouseClick);
            // 
            // dtgvChiTietPhieuXuat
            // 
            this.dtgvChiTietPhieuXuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvChiTietPhieuXuat.Enabled = false;
            this.dtgvChiTietPhieuXuat.Location = new System.Drawing.Point(343, 177);
            this.dtgvChiTietPhieuXuat.Name = "dtgvChiTietPhieuXuat";
            this.dtgvChiTietPhieuXuat.RowTemplate.Height = 24;
            this.dtgvChiTietPhieuXuat.Size = new System.Drawing.Size(622, 215);
            this.dtgvChiTietPhieuXuat.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.label1.Location = new System.Drawing.Point(86, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(810, 58);
            this.label1.TabIndex = 2;
            this.label1.Text = "DANH SÁCH PHIẾU XUẤT HÀNG";
            // 
            // lbChiTietXuat
            // 
            this.lbChiTietXuat.AutoSize = true;
            this.lbChiTietXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChiTietXuat.Location = new System.Drawing.Point(339, 154);
            this.lbChiTietXuat.Name = "lbChiTietXuat";
            this.lbChiTietXuat.Size = new System.Drawing.Size(143, 20);
            this.lbChiTietXuat.TabIndex = 3;
            this.lbChiTietXuat.Text = "Chi tiết phiếu xuất";
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(375, 517);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(149, 39);
            this.btnXoa.TabIndex = 6;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(747, 517);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(149, 39);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // dtgvNgayLap
            // 
            this.dtgvNgayLap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvNgayLap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvNgayLap.Enabled = false;
            this.dtgvNgayLap.EnableHeadersVisualStyles = false;
            this.dtgvNgayLap.Location = new System.Drawing.Point(125, 112);
            this.dtgvNgayLap.Name = "dtgvNgayLap";
            this.dtgvNgayLap.ReadOnly = true;
            this.dtgvNgayLap.RowTemplate.Height = 24;
            this.dtgvNgayLap.Size = new System.Drawing.Size(204, 525);
            this.dtgvNgayLap.TabIndex = 8;
            this.dtgvNgayLap.TabStop = false;
            // 
            // txbConLai
            // 
            this.txbConLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbConLai.Location = new System.Drawing.Point(767, 426);
            this.txbConLai.Name = "txbConLai";
            this.txbConLai.ReadOnly = true;
            this.txbConLai.Size = new System.Drawing.Size(181, 26);
            this.txbConLai.TabIndex = 25;
            this.txbConLai.Text = "0";
            // 
            // txbTraTruoc
            // 
            this.txbTraTruoc.Enabled = false;
            this.txbTraTruoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTraTruoc.Location = new System.Drawing.Point(553, 426);
            this.txbTraTruoc.Name = "txbTraTruoc";
            this.txbTraTruoc.Size = new System.Drawing.Size(181, 26);
            this.txbTraTruoc.TabIndex = 24;
            this.txbTraTruoc.Text = "0";
            this.txbTraTruoc.TextChanged += new System.EventHandler(this.txbTraTruoc_TextChanged);
            // 
            // txbTongTien
            // 
            this.txbTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTongTien.Location = new System.Drawing.Point(343, 426);
            this.txbTongTien.Name = "txbTongTien";
            this.txbTongTien.ReadOnly = true;
            this.txbTongTien.Size = new System.Drawing.Size(181, 26);
            this.txbTongTien.TabIndex = 23;
            this.txbTongTien.Text = "0";
            // 
            // lbConLai
            // 
            this.lbConLai.AutoSize = true;
            this.lbConLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConLai.ForeColor = System.Drawing.Color.Transparent;
            this.lbConLai.Location = new System.Drawing.Point(764, 406);
            this.lbConLai.Name = "lbConLai";
            this.lbConLai.Size = new System.Drawing.Size(63, 17);
            this.lbConLai.TabIndex = 22;
            this.lbConLai.Text = "Còn lại:";
            // 
            // lbTraTruoc
            // 
            this.lbTraTruoc.AutoSize = true;
            this.lbTraTruoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTraTruoc.ForeColor = System.Drawing.Color.Transparent;
            this.lbTraTruoc.Location = new System.Drawing.Point(550, 406);
            this.lbTraTruoc.Name = "lbTraTruoc";
            this.lbTraTruoc.Size = new System.Drawing.Size(80, 17);
            this.lbTraTruoc.TabIndex = 21;
            this.lbTraTruoc.Text = "Trả trước:";
            // 
            // lbTongTien
            // 
            this.lbTongTien.AutoSize = true;
            this.lbTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTongTien.ForeColor = System.Drawing.Color.Transparent;
            this.lbTongTien.Location = new System.Drawing.Point(340, 406);
            this.lbTongTien.Name = "lbTongTien";
            this.lbTongTien.Size = new System.Drawing.Size(82, 17);
            this.lbTongTien.TabIndex = 20;
            this.lbTongTien.Text = "Tổng tiền:";
            // 
            // lbMaDaiLy
            // 
            this.lbMaDaiLy.AutoSize = true;
            this.lbMaDaiLy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaDaiLy.Location = new System.Drawing.Point(346, 112);
            this.lbMaDaiLy.Name = "lbMaDaiLy";
            this.lbMaDaiLy.Size = new System.Drawing.Size(76, 20);
            this.lbMaDaiLy.TabIndex = 26;
            this.lbMaDaiLy.Text = "Mã đại lý";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(655, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 27;
            this.label2.Text = "Người lập";
            // 
            // txbMaDaiLy
            // 
            this.txbMaDaiLy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbMaDaiLy.Location = new System.Drawing.Point(428, 106);
            this.txbMaDaiLy.Name = "txbMaDaiLy";
            this.txbMaDaiLy.ReadOnly = true;
            this.txbMaDaiLy.Size = new System.Drawing.Size(181, 26);
            this.txbMaDaiLy.TabIndex = 28;
            // 
            // txbNguoiLap
            // 
            this.txbNguoiLap.Enabled = false;
            this.txbNguoiLap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNguoiLap.Location = new System.Drawing.Point(747, 109);
            this.txbNguoiLap.Name = "txbNguoiLap";
            this.txbNguoiLap.Size = new System.Drawing.Size(181, 26);
            this.txbNguoiLap.TabIndex = 29;
            // 
            // ucDanhSachPhieuXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.Controls.Add(this.txbNguoiLap);
            this.Controls.Add(this.txbMaDaiLy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbMaDaiLy);
            this.Controls.Add(this.txbConLai);
            this.Controls.Add(this.txbTraTruoc);
            this.Controls.Add(this.txbTongTien);
            this.Controls.Add(this.lbConLai);
            this.Controls.Add(this.lbTraTruoc);
            this.Controls.Add(this.lbTongTien);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.lbChiTietXuat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgvChiTietPhieuXuat);
            this.Controls.Add(this.dtgvMaPhieuXuat);
            this.Controls.Add(this.dtgvNgayLap);
            this.Name = "ucDanhSachPhieuXuat";
            this.Size = new System.Drawing.Size(975, 640);
            this.Load += new System.EventHandler(this.ucDanhSachPhieuXuat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMaPhieuXuat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChiTietPhieuXuat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvNgayLap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvMaPhieuXuat;
        private System.Windows.Forms.DataGridView dtgvChiTietPhieuXuat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbChiTietXuat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridView dtgvNgayLap;
        private System.Windows.Forms.TextBox txbConLai;
        private System.Windows.Forms.TextBox txbTraTruoc;
        private System.Windows.Forms.TextBox txbTongTien;
        private System.Windows.Forms.Label lbConLai;
        private System.Windows.Forms.Label lbTraTruoc;
        private System.Windows.Forms.Label lbTongTien;
        private System.Windows.Forms.Label lbMaDaiLy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbMaDaiLy;
        private System.Windows.Forms.TextBox txbNguoiLap;
    }
}
