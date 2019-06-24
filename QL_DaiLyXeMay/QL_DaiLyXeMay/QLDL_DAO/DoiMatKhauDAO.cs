using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QL_DaiLyXeMay.QLDL_DTO;
using QL_DaiLyXeMay.QLDL_DAL;
using System.Windows.Forms;

namespace QL_DaiLyXeMay.QLDL_DAO
{
    public class DoiMatKhauDAO
    {
        private static DoiMatKhauDAO instance;

        public static DoiMatKhauDAO Instance
        {
            get { if (instance == null) instance = new DoiMatKhauDAO(); return DoiMatKhauDAO.instance; }
            private set { DoiMatKhauDAO.instance = value; }
        }

        private DoiMatKhauDAO() { }
        public bool DoiMatKhau(string tentk, string mkmoi,string mkhientai, string nhaplaimk)
        {
            if (KiemTra.Instance.KiemTraTaiKhoan(tentk, mkhientai) == true)
            {
                if (string.Compare(mkmoi, nhaplaimk) == 0)
                {
                    int result = Data_SQL.Instance.GetNonQuery("UPDATE dbo.TAIKHOAN SET MatKhau = '" + mkmoi + "'");
                    return result > 0;
                }
            }
            return false;
            
        }
        
    }
}
