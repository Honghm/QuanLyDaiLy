using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QL_DaiLyXeMay.QLDL_DAO;

namespace QL_DaiLyXeMay.QLDL_GUI
{
    public partial class ucTimDaiLy : UserControl
    {
        public ucTimDaiLy()
        {
            InitializeComponent();
            TimDaiLyDAO tdl = new TimDaiLyDAO();
            DataSet ds = tdl.getData_DaiLy();
            dgvThongTinDaiLy.DataSource = ds.Tables[0];
        }

        private void BtnTim_Click(object sender, EventArgs e)
        {
            TimDaiLyDAO tdl = new TimDaiLyDAO();
            DataSet ds = tdl.getData_DaiLy(txtThongTin.Text);
            dgvThongTinDaiLy.DataSource = ds.Tables[0];
        }
    }
}
