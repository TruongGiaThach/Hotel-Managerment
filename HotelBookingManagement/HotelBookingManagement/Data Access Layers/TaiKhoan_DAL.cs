using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelBookingManagement.Data_Access_Layers
{
    class TaiKhoan_DAL
    {

        private static TaiKhoan_DAL instance;

        public static TaiKhoan_DAL Instance
        {
            get { if (instance == null) instance = new TaiKhoan_DAL(); return TaiKhoan_DAL.instance; }
            private set => instance = value;
        }
        private TaiKhoan_DAL() { }
        public TaiKhoan getTaiKhoanbyName(string name)
        {
            List<TaiKhoan> lists = new List<TaiKhoan>();
            string sqlQuery = "select * from TAIKHOAN where TENDN = @name ";
            DataTable data = DataHelper.Instance.getDataTable(sqlQuery, new string[] { name });
            foreach (DataRow i in data.Rows)
            {
                TaiKhoan item = new TaiKhoan(i);
                lists.Add(item);
            }
            return lists[0];
        }
        public List<TaiKhoan> GetTaiKhoan_DAL()
        {
            List<TaiKhoan> lists = new List<TaiKhoan>();
            string sqlQuery = "select * from TAIKHOAN";
            DataTable data = DataHelper.Instance.getDataTable(sqlQuery);
            foreach (DataRow i in data.Rows)
            {
                TaiKhoan item = new TaiKhoan(i);
                lists.Add(item);
            }
            return lists;
        }
        public bool themTaiKhoan(string user, string pass, string staffID)
        {
            string sqlQuery = "select * from TAIKHOAN where TENDN = @user ";
            DataTable data = DataHelper.Instance.getDataTable(sqlQuery, new string[] { user });
            if (data.Rows.Count > 0)
                throw new Exception("Tài khoản đã tồn tại!!");
            //-----------
            TaiKhoan tk = getTaiKhoanbyName("root");
            int i = Int32.Parse((tk.PhanQuyen));
            i++;
            string id = "US" + i.ToString();
           
            //--------------
            sqlQuery = "insert into TAIKHOAN(ID, TENDN, MATKHAU , PHANQUYEN , MANV) " +
                                "values( @id , @tendn , @matkhau , @phanquyen , @manv )";
            string[] parameter = new string[]
                { id, user ,pass ,  "user" , staffID };
            int result = DataHelper.Instance.ExecuteNonQuery(sqlQuery, parameter);
            if (result == 1)
            {
                updatePhanQuyen("root", i.ToString());
                return true;
            }
            return false;
        }
        public bool dangNhap(string user, string pass)
        {
            string sqlQuery = "execute us_Login @user , @matkhau ";
            string[] parameter = new string[] { user, pass };
            DataTable result = DataHelper.Instance.getDataTable(sqlQuery, parameter);
            return result.Rows.Count > 0;
        }
        public bool updateTaiKhoan(string user, string pass, string newpass)
        {
            string sqlQuery = "exec us_UpdateTaiKhoan @user , @pass , @newpass ";
            int result = DataHelper.Instance.ExecuteNonQuery(sqlQuery, new string[] { user, pass, newpass });
            return result > 0;
        }
        public bool updatePhanQuyen(string user, string phanquyen)
        {
            string sqlQuery = string.Format("UPDATE TAIKHOAN SET PHANQUYEN = @phanquyen WHERE TENDN = @user ");
            int result = DataHelper.Instance.ExecuteNonQuery(sqlQuery, new string[] { phanquyen, user });

            return result > 0;
        }
        public bool xoaTaiKhoanID(string id)
        {
            string sqlQuery = "delete from TAIKHOAN where ID = @id ";
            int result = DataHelper.Instance.ExecuteNonQuery(sqlQuery, new string[] { id });
            return result > 0;
        }
    }
}
