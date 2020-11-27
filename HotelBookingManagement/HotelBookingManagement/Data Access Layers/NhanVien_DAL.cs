using HotelBookingManagement.Object;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingManagement.Data_Access_Layers
{
    class NhanVien_DAL
    {
        private static NhanVien_DAL instance;

        public static NhanVien_DAL Instance
        {
            get { if (instance == null) instance = new NhanVien_DAL(); return NhanVien_DAL.instance; }
            private set => instance = value;
        }
        private NhanVien_DAL() { }
        public List<NhanVien> getNhanVienByName(string name)
        {
            List<NhanVien> lists = new List<NhanVien>();
            string sqlQuery = "select * from NHANVIEN where HOTEN = @name ";
            DataTable data = DataHelper.Instance.getDataTable(sqlQuery, new string[] { name });
            foreach (DataRow i in data.Rows)
            {
                NhanVien item = new NhanVien(i);
                lists.Add(item);
            }
            return lists;
        }
        public NhanVien getByEmail(string email)
        {
            List<NhanVien> lists = new List<NhanVien>();
            string sqlQuery = "select * from NHANVIEN where EMAIL = @email ";
            DataTable data = DataHelper.Instance.getDataTable(sqlQuery, new string[] { email });
            if (data.Rows.Count == 0)
                throw new Exception("Không tìm thấy email...");
            foreach (DataRow i in data.Rows)
            {
                NhanVien item = new NhanVien(i);
                lists.Add(item);
            }
            return lists[0];
        }
        public NhanVien getByPhoneNumber(string phonennum)
        {
            List<NhanVien> lists = new List<NhanVien>();
            string sqlQuery = "select * from NHANVIEN where EMAIL = @num ";
            DataTable data = DataHelper.Instance.getDataTable(sqlQuery, new string[] { phonennum });
            foreach (DataRow i in data.Rows)
            {
                NhanVien item = new NhanVien(i);
                lists.Add(item);
            }
            return lists[0];
        }
        public List<NhanVien> GetNhanVien_DAL()
        {
            List<NhanVien> lists = new List<NhanVien>();
            string sqlQuery = "select * from NHANVIEN";
            DataTable data = DataHelper.Instance.getDataTable(sqlQuery);
            foreach (DataRow i in data.Rows)
            {
                NhanVien item = new NhanVien(i);
                lists.Add(item);
            }
            return lists;
        }
        public bool themNhanVien(string name, string email, string phoneNum, string address)
        {
            string sqlQuery = "select * from NHANVIEN where EMAIL = @email ";
            DataTable data = DataHelper.Instance.getDataTable(sqlQuery, new string[] { email });
            if (data.Rows.Count > 0)
                throw new Exception("Email đã được sử dụng!!");
            //-----------

            NhanVien tk = getByEmail("root@gmail.com");
            int i = Int32.Parse((tk.SoDT));
            i++;
            string id = "KH" + i.ToString();

            //--------------
            sqlQuery = "insert into NHANVIEN(ID, HOTEN, EMAIL, SODT, DIACHI) " +
                                "values( @id , @tendn , @email , @phoneNum , @address  )";
            string[] parameter = new string[]
                { id, name , email , phoneNum, address };
            int result = DataHelper.Instance.ExecuteNonQuery(sqlQuery, parameter);
            if (result == 1)
            {
                updatePhoneNumber("root@gmail.com", i.ToString());
                return true;
            }
            return false;
        }

        public bool updatePhoneNumber(string email, string phoneNum)
        {
            string sqlQuery = "exec kh_UpdatePhone @user , @phone ";
            int result = DataHelper.Instance.ExecuteNonQuery(sqlQuery, new string[] { email, phoneNum });
            return result > 0;
        }
        public bool updateName(string email, string name)
        {
            string sqlQuery = string.Format("UPDATE NHANVIEN SET HOTEN = @name WHERE EMAIL = @email ");
            int result = DataHelper.Instance.ExecuteNonQuery(sqlQuery, new string[] { name, email });
            return result > 0;
        }
    }
}
