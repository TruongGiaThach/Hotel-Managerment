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
            if (lists.Count != 0)
                return lists[0];
            else return null;
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
            if (lists.Count == 0) return null;
            return lists;
        }
        public bool themTaiKhoan(string user, string pass, string staffID)
        {
            TaiKhoan taiKhoan = TaiKhoan_DAL.Instance.getTaiKhoanbyName(user);
            if (taiKhoan != null)
                throw new Exception("Tài khoản đã tồn tại!!");
            //-----------
            string sqlQuery = "select * from MARKER where MARK_TABLE = 'TAIKHOAN'";
            DataTable data = DataHelper.Instance.getDataTable(sqlQuery);
            DataRow dataRow;
            if (data.Rows.Count > 0)
                dataRow = data.Rows[0];
            else throw new Exception("Không thể thêm tài khoản");
            int i = Int32.Parse(dataRow["NUMBER"].ToString());
            i++;
            string id = "US" + i.ToString();

            //--------------
            sqlQuery = "insert into TAIKHOAN(ID, TENDN, MATKHAU , PHANQUYEN , MANV) " +
                                "values( @id , @tendn , @matkhau , @phanquyen , @manv )";
            string[] parameter = new string[]
                { id, user ,pass ,  "user" , staffID };
            int result = DataHelper.Instance.ExecuteNonQuery(sqlQuery, parameter);
            if (result > 0)
            {
                sqlQuery = "update MARKER set NUMBER = @i where MARK_TABLE ='TAIKHOAN'";
                DataHelper.Instance.ExecuteNonQuery(sqlQuery, new object[] { i });
                return true;
            }
            return false;
        }
        public bool isOnline(string user)
        {
            TaiKhoan tk = getTaiKhoanbyName(user);
            if (tk != null)
                return tk.TrangThai;
            return false;
        }
        public bool updateStatus(string user,bool status)
        {
            string sqlQuery = "Update TAIKHOAN set TRANGTHAI = @status where TENDN = @user ";
            return DataHelper.Instance.ExecuteNonQuery(sqlQuery, new object[] { status.ToString(), user }) > 0;
        }
        public bool dangNhap(string user, string pass)
        {
         
            string sqlQuery = "execute us_Login @user , @matkhau ";
            string[] parameter = new string[] { user, pass };
            DataTable result = DataHelper.Instance.getDataTable(sqlQuery, parameter);
            return result.Rows.Count > 0;
        }
        public bool updateTaiKhoan(string user, string newpass)
        {
            string sqlQuery = "Update TAIKHOAN set MATKHAU = @MatKhau where TENDN = @user ";
            int result = DataHelper.Instance.ExecuteNonQuery(sqlQuery, new string[] { user, newpass });
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
        public bool CheckMatKhau(string user, string MK)
        {
            if (MK != null)
            {
                string sqlQuery = string.Format("select MATKHAU from TAIKHOAN where TENDN = @user");
                DataTable result = DataHelper.Instance.getDataTable(sqlQuery, new string[] { user });
                if (result.Rows[0].ToString() == MK) return true;
            }
            return false;
        }
    }
}
