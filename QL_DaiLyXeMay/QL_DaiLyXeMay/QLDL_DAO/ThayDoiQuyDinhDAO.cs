using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_DaiLyXeMay.QLDL_DAO
{
    public class ThayDoiQuyDinhDAO
    {
        private static ThayDoiQuyDinhDAO instance;
        public static ThayDoiQuyDinhDAO Instance
        {
            get { if (instance == null) instance = new ThayDoiQuyDinhDAO(); return ThayDoiQuyDinhDAO.instance; }
            private set { ThayDoiQuyDinhDAO.instance = value; }
        }

        private ThayDoiQuyDinhDAO() { }

    }
}
