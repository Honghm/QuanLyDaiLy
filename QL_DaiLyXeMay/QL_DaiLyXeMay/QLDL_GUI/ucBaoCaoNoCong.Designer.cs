namespace QL_DaiLyXeMay.QLDL_GUI
{
    partial class ucBaoCaoNoCong
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
            this.grbChiTiet = new System.Windows.Forms.GroupBox();
            this.rpvBaoCaoDoanhSo = new Microsoft.Reporting.WinForms.ReportViewer();
            this.lblBaoCaoDoanhSo = new System.Windows.Forms.Label();
            this.lblThang = new System.Windows.Forms.Label();
            this.cbbThang = new System.Windows.Forms.ComboBox();
            this.btnTao = new System.Windows.Forms.Button();
            this.lblNam = new System.Windows.Forms.Label();
            this.txtNam = new System.Windows.Forms.TextBox();
            this.grbChiTiet.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbChiTiet
            // 
            this.grbChiTiet.Controls.Add(this.rpvBaoCaoDoanhSo);
            this.grbChiTiet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbChiTiet.Location = new System.Drawing.Point(3, 121);
            this.grbChiTiet.Name = "grbChiTiet";
            this.grbChiTiet.Size = new System.Drawing.Size(884, 508);
            this.grbChiTiet.TabIndex = 9;
            this.grbChiTiet.TabStop = false;
            this.grbChiTiet.Text = "Chi Tiết";
            // 
            // rpvBaoCaoDoanhSo
            // 
            this.rpvBaoCaoDoanhSo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpvBaoCaoDoanhSo.Location = new System.Drawing.Point(3, 26);
            this.rpvBaoCaoDoanhSo.Name = "ReportViewer";
            this.rpvBaoCaoDoanhSo.ServerReport.BearerToken = null;
            this.rpvBaoCaoDoanhSo.Size = new System.Drawing.Size(878, 479);
            this.rpvBaoCaoDoanhSo.TabIndex = 0;
            // 
            // lblBaoCaoDoanhSo
            // 
            this.lblBaoCaoDoanhSo.AutoSize = true;
            this.lblBaoCaoDoanhSo.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.lblBaoCaoDoanhSo.Location = new System.Drawing.Point(217, 13);
            this.lblBaoCaoDoanhSo.Name = "lblBaoCaoDoanhSo";
            this.lblBaoCaoDoanhSo.Size = new System.Drawing.Size(517, 58);
            this.lblBaoCaoDoanhSo.TabIndex = 8;
            this.lblBaoCaoDoanhSo.Text = "BÁO CÁO NỢ CÔNG";
            // 
            // lblThang
            // 
            this.lblThang.AutoSize = true;
            this.lblThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThang.Location = new System.Drawing.Point(259, 90);
            this.lblThang.Name = "lblThang";
            this.lblThang.Size = new System.Drawing.Size(69, 25);
            this.lblThang.TabIndex = 12;
            this.lblThang.Text = "Tháng";
            // 
            // cbbThang
            // 
            this.cbbThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbThang.FormattingEnabled = true;
            this.cbbThang.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbbThang.Location = new System.Drawing.Point(334, 87);
            this.cbbThang.Name = "cbbThang";
            this.cbbThang.Size = new System.Drawing.Size(46, 33);
            this.cbbThang.TabIndex = 11;
            this.cbbThang.SelectedIndexChanged += new System.EventHandler(this.CbbThang_SelectedIndexChanged);
            // 
            // btnTao
            // 
            this.btnTao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTao.Location = new System.Drawing.Point(559, 85);
            this.btnTao.Name = "btnTao";
            this.btnTao.Size = new System.Drawing.Size(84, 35);
            this.btnTao.TabIndex = 10;
            this.btnTao.Text = "Tạo";
            this.btnTao.UseVisualStyleBackColor = true;
            this.btnTao.Click += new System.EventHandler(this.BtnTao_Click);
            // 
            // lblNam
            // 
            this.lblNam.AutoSize = true;
            this.lblNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNam.Location = new System.Drawing.Point(386, 90);
            this.lblNam.Name = "lblNam";
            this.lblNam.Size = new System.Drawing.Size(53, 25);
            this.lblNam.TabIndex = 13;
            this.lblNam.Text = "Năm";
            // 
            // txtNam
            // 
            this.txtNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNam.Location = new System.Drawing.Point(445, 87);
            this.txtNam.Name = "txtNam";
            this.txtNam.Size = new System.Drawing.Size(91, 30);
            this.txtNam.TabIndex = 14;
            // 
            // ucBaoCaoNoCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.Controls.Add(this.txtNam);
            this.Controls.Add(this.lblNam);
            this.Controls.Add(this.grbChiTiet);
            this.Controls.Add(this.lblBaoCaoDoanhSo);
            this.Controls.Add(this.lblThang);
            this.Controls.Add(this.cbbThang);
            this.Controls.Add(this.btnTao);
            this.Name = "ucBaoCaoNoCong";
            this.Size = new System.Drawing.Size(890, 640);
            this.Load += new System.EventHandler(this.UcBaoCaoNoCong_Load);
            this.grbChiTiet.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbChiTiet;
        private Microsoft.Reporting.WinForms.ReportViewer rpvBaoCaoDoanhSo;
        private System.Windows.Forms.Label lblBaoCaoDoanhSo;
        private System.Windows.Forms.Label lblThang;
        private System.Windows.Forms.ComboBox cbbThang;
        private System.Windows.Forms.Button btnTao;
        private System.Windows.Forms.Label lblNam;
        private System.Windows.Forms.TextBox txtNam;
    }
}
