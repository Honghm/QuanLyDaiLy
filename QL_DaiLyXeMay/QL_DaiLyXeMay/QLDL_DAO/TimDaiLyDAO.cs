using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QL_DaiLyXeMay.QLDL_DAL;

namespace QL_DaiLyXeMay.QLDL_DAO
{
    class TimDaiLyDAO
    {
        public DataSet getData_DaiLy()
        {
            DataSet data = Data_SQL.Instance.getDataByStringQueue("SELECT MaDaiLy, TenDaiLy, TenLoaiDaiLy, DienThoai, Email,DiaChi, TenQuan, NgayTiepNhan, SoNo, GhiChu from QUAN, DAILY, LOAIDAILY where QUAN.MaQuan = DAILY.MaQuan and DAILY.MaLoaiDaiLy = LOAIDAILY.MaLoaiDaiLy");
            return data;
        }
        public DataSet getData_DaiLy(string _data)
        {
            DataSet data = Data_SQL.Instance.getDataByStringQueue("SELECT MaDaiLy, TenDaiLy, TenLoaiDaiLy, DienThoai, Email,DiaChi, TenQuan, NgayTiepNhan, SoNo, GhiChu from QUAN, DAILY, LOAIDAILY where QUAN.MaQuan = DAILY.MaQuan and DAILY.MaLoaiDaiLy = LOAIDAILY.MaLoaiDaiLy and (TenDaiLy like N'%" + _data + "%' or DAILY.MaDaiLy like '" + _data + "')");
            return data;
        }
    }
}
