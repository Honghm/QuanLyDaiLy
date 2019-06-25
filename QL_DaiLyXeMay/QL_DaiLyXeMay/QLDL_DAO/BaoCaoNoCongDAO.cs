using QL_DaiLyXeMay.QLDL_DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_DaiLyXeMay.QLDL_DAO
{
    class BaoCaoNoCongDAO
    {
        public DataSet getDataSet(DateTime date)
        {
            // thiết lập kết nối
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Data_SQL.Instance.getConnectionString();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "BAOCAONOCONG";//tên store proceduce của báo cáo nợ công
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            cmd.Parameters.Add(new SqlParameter("@Thang", date));

            //khai báo dataset để lấy dữ liệu
            DataSet ds = new DataSet();
            SqlDataAdapter dap = new SqlDataAdapter(cmd);
            dap.Fill(ds);
            return ds;
        }
    }
}
