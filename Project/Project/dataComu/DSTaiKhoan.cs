using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class DSTaiKhoan
    {

        private static DSTaiKhoan instance;

        public static DSTaiKhoan Instance 
        { 
            get { if (instance == null) instance = new DSTaiKhoan(); return DSTaiKhoan.instance; } 
            private set => instance = value; 
        }
        private DSTaiKhoan() { }
        public bool them(TaiKhoan taiKhoan) // chua check
        {
            String sqlQuery = "insert into TAIKHOAN(ID, TENDN, MATKHAU, PHANQUYEN) " +
                                "values( @id , @tendn , @matkhau , @phanquyen )";
            string[] parameter = new string[]
                { taiKhoan.ID, taiKhoan.tenDN, taiKhoan.MatKhau, taiKhoan.PhanQuyen };
        
            return true;
        }
        public bool dangNhap(string user, string pass)
        {
            string sqlQuery = "execute us_Login @user , @matkhau ";
            string[] parameter = new string[] { user, pass };
            DataTable result = DataHelper.Instance.getDataTable(sqlQuery, parameter);
            return result.Rows.Count > 0;
        }
    }
}
