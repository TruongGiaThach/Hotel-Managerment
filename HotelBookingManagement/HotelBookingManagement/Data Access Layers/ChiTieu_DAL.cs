using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingManagement.Data_Access_Layers
{
    class ChiTieu_DAL
    {
        private static ChiTieu_DAL instance;
        public static ChiTieu_DAL Instance
        {
            get { if (instance == null) instance = new ChiTieu_DAL(); return ChiTieu_DAL.instance; }
            private set => instance = value;
        }
        public bool ThemChiTieu(string T_Dien, string T_Nuoc, string T_LuongNV, string T_BaoTri, string T_Khac,string TongChi, string Thang, string Nam)
        {
            string sqlQuery = "update CHITIEU set T_DIEN = @T_Dien , T_NUOC = @T_Nuoc , T_LUONGNV = @T_Luongnv , T_BAOTRI = @T_Baotri , T_KHAC = @T_Khac , TONGCHI = @Tongchi where THANG = @Thang and NAM = @Nam";
            string[] parameter = new string[]
                {T_Dien, T_Nuoc, T_LuongNV, T_BaoTri, T_Khac, TongChi, Thang, Nam};
            int result = DataHelper.Instance.ExecuteNonQuery(sqlQuery, parameter);
            if (result > 0) return true;
            return false;
        }
        public void CheckNgayThongKe(string Nam)
        {
            string sqlQuery = "select * from CHITIEU where NAM = @nam";
            var result = DataHelper.Instance.getDataTable(sqlQuery, new string[] { Nam });
            if (result != null)
            {
                if (result.Rows.Count == 0)
                {
                    for (int i = 1; i <= 12; ++i)
                    {
                        sqlQuery = "insert into CHITIEU(T_DIEN, T_NUOC, T_LUONGNV, T_BAOTRI, T_KHAC, TONGCHI, THANG, NAM) " + "values( @T_Dien , @T_Nuoc , @T_Luongnv , @T_Baotri , @T_Khac , @TongChi , @Thang , @Nam )";
                        string[] parameter = new string[]
                        { "0", "0", "0", "0", "0", "0", i.ToString(), Nam};
                        DataHelper.Instance.ExecuteNonQuery(sqlQuery, parameter);
                    }
                }
            }
        }

    }
}
