namespace QL_DaiLyXeMay.QLDL_GUI
{
    partial class ucTimDaiLy
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
            this.lbTimDaiLy = new System.Windows.Forms.Label();
            this.btnTim = new System.Windows.Forms.Button();
            this.txtThongTin = new System.Windows.Forms.TextBox();
            this.lblThongTin = new System.Windows.Forms.Label();
            this.dgvThongTinDaiLy = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinDaiLy)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTimDaiLy
            // 
            this.lbTimDaiLy.AutoSize = true;
            this.lbTimDaiLy.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.lbTimDaiLy.ForeColor = System.Drawing.Color.Transparent;
            this.lbTimDaiLy.Location = new System.Drawing.Point(323, 37);
            this.lbTimDaiLy.Name = "lbTimDaiLy";
            this.lbTimDaiLy.Size = new System.Drawing.Size(292, 58);
            this.lbTimDaiLy.TabIndex = 3;
            this.lbTimDaiLy.Text = "TÌM ĐẠI LÝ";
            // 
            // btnTim
            // 
            this.btnTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.Location = new System.Drawing.Point(621, 125);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(88, 30);
            this.btnTim.TabIndex = 4;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.BtnTim_Click);
            // 
            // txtThongTin
            // 
            this.txtThongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThongTin.Location = new System.Drawing.Point(324, 125);
            this.txtThongTin.Name = "txtThongTin";
            this.txtThongTin.Size = new System.Drawing.Size(291, 30);
            this.txtThongTin.TabIndex = 5;
            // 
            // lblThongTin
            // 
            this.lblThongTin.AutoSize = true;
            this.lblThongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongTin.Location = new System.Drawing.Point(224, 125);
            this.lblThongTin.Name = "lblThongTin";
            this.lblThongTin.Size = new System.Drawing.Size(94, 25);
            this.lblThongTin.TabIndex = 6;
            this.lblThongTin.Text = "Thông tin";
            // 
            // dgvThongTinDaiLy
            // 
            this.dgvThongTinDaiLy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongTinDaiLy.Location = new System.Drawing.Point(6, 171);
            this.dgvThongTinDaiLy.Name = "dgvThongTinDaiLy";
            this.dgvThongTinDaiLy.RowTemplate.Height = 24;
            this.dgvThongTinDaiLy.Size = new System.Drawing.Size(969, 466);
            this.dgvThongTinDaiLy.TabIndex = 7;
            // 
            // ucTimDaiLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.Controls.Add(this.dgvThongTinDaiLy);
            this.Controls.Add(this.lblThongTin);
            this.Controls.Add(this.txtThongTin);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.lbTimDaiLy);
            this.Name = "ucTimDaiLy";
            this.Size = new System.Drawing.Size(975, 640);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinDaiLy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTimDaiLy;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.TextBox txtThongTin;
        private System.Windows.Forms.Label lblThongTin;
        private System.Windows.Forms.DataGridView dgvThongTinDaiLy;
    }
}
