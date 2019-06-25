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
using Microsoft.Reporting.WinForms;
using QL_DaiLyXeMay.QLDL_DAO;
//using QL_DaiLyXeMay.QLDL_DAL;

namespace QL_DaiLyXeMay.QLDL_GUI
{
    public partial class ucBaoCaoDoanhSo : UserControl
    {
        public ucBaoCaoDoanhSo()
        {
            InitializeComponent();
        }

        private void BtnTao_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            int year = int.Parse(txtNam.Text);
            int month = int.Parse(cbbThang.Text);
            date = date.AddYears(year - date.Year);
            date = date.AddMonths(month - date.Month);

            BaoCaoDoanhSoDAO bc = new BaoCaoDoanhSoDAO();
            DataSet ds = bc.getDataSet(date);
            //Thiet lập báo cáo
            rpvBaoCaoDoanhSo.ProcessingMode = ProcessingMode.Local;
            rpvBaoCaoDoanhSo.LocalReport.ReportPath = "QLDL_GUI\\rptBaoCaoDoanhSo.rdlc";

            ReportDataSource rds = new ReportDataSource();
            rds.Name = "dsBaoCaoDoanhSo";
            rds.Value = ds.Tables[0];
            //Gắn report datasource lên mẫu báo cáo
            rpvBaoCaoDoanhSo.LocalReport.DataSources.Clear();
            rpvBaoCaoDoanhSo.LocalReport.DataSources.Add(rds);
            rpvBaoCaoDoanhSo.RefreshReport();
        }

        private void UcBaoCaoDoanhSo_Load(object sender, EventArgs e)
        {
            cbbThang.Text = DateTime.Now.Month.ToString();
            txtNam.Text = DateTime.Now.Year.ToString();
            this.rpvBaoCaoDoanhSo.RefreshReport();
        }

    }
}
