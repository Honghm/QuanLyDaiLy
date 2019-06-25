using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_DaiLyXeMay.QLDL_DAL
{
    public class Data_SQL
    {
        /// <summary>
        /// sử dụng Singleton để tránh trường hợp nhiều yêu cầu kết nối cùng lúc
        /// </summary>
        private static Data_SQL instance;

        public static Data_SQL Instance
        {
            get { if (instance == null) instance = new Data_SQL(); return Data_SQL.instance; }
            private set { Data_SQL.instance = value; }
        }

        private Data_SQL() { }

        private string connectionSTR = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ZBook\Documents\GitHub\QuanLyDaiLy\QL_DaiLyXeMay\QL_DaiLyXeMay\QLDL_DAL\dataQuanLyDaiLy.mdf;Integrated Security=True";
        public string getConnectionString()
        {
            return connectionSTR;
        }
        public DataTable GetQuery(string query, object[] parameter = null) //truy vấn
        {
            DataTable data = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(data);

                connection.Close();
            }

            return data;
        }

        public int GetNonQuery(string query, object[] parameter = null) //đếm số dòng thực thi thành công khi thêm sửa xóa
        {
            int data = 0;

            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                data = command.ExecuteNonQuery();

                connection.Close();
            }

            return data;
        }

        public object ExecuteScalar(string query, object[] parameter = null) // Lấy dự liệu của ô đầu tiên trong bảng
        {
            object data = 0;

            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                data = command.ExecuteScalar();

                connection.Close();
            }

            return data;
        }

       
        public Object get_Data_of_SomeThing(string CauLenh) //Lấy thông tin từ mã số
        {
            object get_Data;
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(CauLenh, connection);
                get_Data = command.ExecuteScalar();
                connection.Close();
            }
            return get_Data;
        }
        public DataSet getDataByStringQueue(string _queue)
        {
            // thiết lập kết nối
            SqlConnection con = new SqlConnection();
            con.ConnectionString = connectionSTR;
            con.Open();
            DataSet ds = new DataSet();
            SqlDataAdapter dap = new SqlDataAdapter(_queue, con);
            dap.Fill(ds);
            con.Close();
            return ds;
        }
    }
}
