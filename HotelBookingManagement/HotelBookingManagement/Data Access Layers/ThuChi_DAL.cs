using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingManagement.Data_Access_Layers
{
    class ThuChi_DAL
    {
        private static ThuChi_DAL instance;
        public static ThuChi_DAL Instance
        {
            get { if (instance == null) instance = new ThuChi_DAL(); return ThuChi_DAL.instance; }
            private set => instance = value;
        }
        public ThuChi_DAL() { }
        public void CheckNgayThongKe(string Thang, string Nam)
        {
            string sqlQuery = "select * from THUCHI where THANG = @thang and NAM = @nam";
            var result = DataHelper.Instance.getDataTable(sqlQuery, new string[] { Thang, Nam });
            if (result != null)
            {
                if (result.Rows.Count == 0)
                {
                    sqlQuery = "insert into THUCHI(T_Thu, T_Chi, T_LOINHUAN, THANG, NAM) " + "values( @Thu , @Chi , @LoiNhuan , @Thang , @Nam )";
                    string[] parameter = new string[]
                    { "0", "0", "0" ,Thang, Nam};
                    DataHelper.Instance.ExecuteNonQuery(sqlQuery, parameter);
                }
            }
        }
        public DataSet getChartData(string Nam = null)
        {
            if(Nam == null)
            {
                //Xuat Theo Nam
                string sqlQuery = "select NAM as Nam, sum(T_THU) as Tien_Thu, sum(T_CHI) as Tien_Chi, sum(T_LOINHUAN) as Loi_Nhuan " + " from THUCHI " + " group by NAM " + " order by NAM asc ";
                DataTable result = DataHelper.Instance.getDataTable(sqlQuery, new string[] {});
                return result.DataSet;
            }
            else
            {
                //Xuat theo Thang
                string sqlQuery = "select THANG as Thang, sum(T_THU) as Tien_Thu, sum(T_CHI) as Tien_Chi, sum(T_LOINHUAN) as Loi_Nhuan " 
                        + "from THUCHI " + "where NAM = @Nam " + "group by THANG " + "order by THANG asc";
                var result = DataHelper.Instance.getBudgetDataTable(sqlQuery, new string[] { Nam });
                return result;
            }
        }
    }
}
