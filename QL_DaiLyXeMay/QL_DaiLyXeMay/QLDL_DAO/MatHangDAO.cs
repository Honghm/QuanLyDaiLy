using QL_DaiLyXeMay.QLDL_DAL;
using QL_DaiLyXeMay.QLDL_DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_DaiLyXeMay.QLDL_DAO
{
    public class MatHangDAO
    {
        private static MatHangDAO instance;

        public static MatHangDAO Instance
        {
            get { if (instance == null) instance = new MatHangDAO(); return MatHangDAO.instance; }
            private set { MatHangDAO.instance = value; }
        }
        private MatHangDAO() { }
        public List<MatHangDTO> GetListMatHang()
        {
            List<MatHangDTO> list = new List<MatHangDTO>();
            string query = "SELECT * FROM dbo.MATHANG";
            DataTable data = Data_SQL.Instance.GetQuery(query);
            foreach(DataRow item in data.Rows)
            {
                MatHangDTO mathang = new MatHangDTO(item);
                list.Add(mathang);
            }
            return list;
        }
        public DataTable LoadData(string ma)
        {
            DataTable temp = Data_SQL.Instance.GetQuery("SELECT * FROM dbo.MATHANG WHERE MaMatHang = '" + ma + "'");
            return temp;
        }
    }
}

