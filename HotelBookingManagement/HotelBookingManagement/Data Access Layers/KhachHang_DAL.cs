using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelBookingManagement.Data_Access_Layers
{
    class KhachHang_DAL
    {
        private static KhachHang_DAL instance;

        public static KhachHang_DAL Instance
        {
            get { if (instance == null) instance = new KhachHang_DAL(); return KhachHang_DAL.instance; }
            private set => instance = value;
        }
        private KhachHang_DAL() { }
        public List<KhachHang> getKhachHangByName(string name)
        {
            List<KhachHang> lists = new List<KhachHang>();
            string sqlQuery = "select * from KHACHHANG where HOTEN = @name ";
            DataTable data = DataHelper.Instance.getDataTable(sqlQuery, new string[] { name });
            foreach (DataRow i in data.Rows)
            {
                KhachHang item = new KhachHang(i);
                lists.Add(item);
            }
            return lists;
        }
        public KhachHang getByEmail(string email)
        {
            List<KhachHang> lists = new List<KhachHang>();
            string sqlQuery = "select * from KHACHHANG where EMAIL = @email ";
            DataTable data = DataHelper.Instance.getDataTable(sqlQuery, new string[] { email });
            if (data.Rows.Count == 0)
                throw new Exception("Không tìm thấy email...");
            foreach (DataRow i in data.Rows)
            {
                KhachHang item = new KhachHang(i);
                lists.Add(item);
            }
            return lists[0];
        }
        public KhachHang getByPhoneNumber(string phonennum)
        {
            List<KhachHang> lists = new List<KhachHang>();
            string sqlQuery = "select * from KHACHHANG where EMAIL = @num ";
            DataTable data = DataHelper.Instance.getDataTable(sqlQuery, new string[] { phonennum });
            foreach (DataRow i in data.Rows)
            {
                KhachHang item = new KhachHang(i);
                lists.Add(item);
            }
            return lists[0];
        }
        public KhachHang getByCMND(string cmnd)
        {
            List<KhachHang> lists = new List<KhachHang>();
            string sqlQuery = "select * from KHACHHANG where CMND = @cmnd ";
            DataTable data = DataHelper.Instance.getDataTable(sqlQuery, new string[] { cmnd });
            foreach (DataRow i in data.Rows)
            {
                KhachHang item = new KhachHang(i);
                lists.Add(item);
            }
            if (lists.Count != 0)
                return lists[0];
            else return null;
        }
        public List<KhachHang> GetKhachHang_DAL()
        {
            List<KhachHang> lists = new List<KhachHang>();
            string sqlQuery = "select * from KHACHHANG";
            DataTable data = DataHelper.Instance.getDataTable(sqlQuery);
            foreach (DataRow i in data.Rows)
            {
                KhachHang item = new KhachHang(i);
                lists.Add(item);
            }
            return lists;
        }
        public bool themKhachHang(string name, string email, string phoneNum, string address,string cmnd)
        {
            string sqlQuery = "select * from KHACHHANG where CMND = @cmnd ";
            DataTable data = DataHelper.Instance.getDataTable(sqlQuery, new string[] { cmnd });
            if (data.Rows.Count > 0)
                throw new Exception("CMND đã được sử dụng!!");
            //-----------

            KhachHang tk = getByEmail("root@gmail.com");
            int i = Int32.Parse((tk.SoDT));
            i++;
            string id = "KH" + i.ToString();

            //--------------
            sqlQuery = "insert into KhachHang(ID, HOTEN, EMAIL, SODT, DIACHI, CMND) " +
                                "values( @id , @tendn , @email , @phoneNum , @address , @cmnd  )";
            string[] parameter = new string[]
                { id, name , email , phoneNum, address , cmnd };
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
            string sqlQuery = "UPDATE KHACHHANG SET SODT = @phoneNum WHERE EMAIL = @email";
            int result = DataHelper.Instance.ExecuteNonQuery(sqlQuery, new string[] { phoneNum,email });
            return result > 0;
        }
        public bool updateName(string email, string name)
        {
            string sqlQuery = string.Format("UPDATE KHACHHANG SET HOTEN = @name WHERE EMAIL = @email ");
            int result = DataHelper.Instance.ExecuteNonQuery(sqlQuery, new string[] { name, email });
            return result > 0;
        }
        public bool xoaTheoCMND(string cmnd)
        {
            string sqlQuery = string.Format("delete from KHACHHANG CMND  = @cmnd ");
            int result = DataHelper.Instance.ExecuteNonQuery(sqlQuery, new string[] { cmnd });
            return result > 0;
        }
    }
}
