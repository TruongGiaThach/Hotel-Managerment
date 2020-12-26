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
            if (data.Rows.Count == 0)
                throw new Exception("Không tìm thấy tên này...");
            foreach (DataRow i in data.Rows)
            {
                NhanVien item = new NhanVien(i);
                lists.Add(item);
            }
            return lists;
        }
        public NhanVien getNhanVienByID(string id)
        {
            if (id == null)
                return null;
            List<NhanVien> lists = new List<NhanVien>();
            string sqlQuery = "select * from NHANVIEN where ID = @id ";
            DataTable data = DataHelper.Instance.getDataTable(sqlQuery, new string[] { id });
            if (data.Rows.Count == 0)
                return null;
            foreach (DataRow i in data.Rows)
            {
                NhanVien item = new NhanVien(i);
                lists.Add(item);
            }
            return lists[0];
        }
        public NhanVien getByCMND(string cmnd)
        {
            List<NhanVien> lists = new List<NhanVien>();
            string sqlQuery = "select * from NHANVIEN where CMND = @cmnd ";
            DataTable data = DataHelper.Instance.getDataTable(sqlQuery, new string[] { cmnd });
            foreach (DataRow i in data.Rows)
            {
                NhanVien item = new NhanVien(i);
                lists.Add(item);
            }
            if (lists.Count != 0)
                return lists[0];
            else return null;
        }
        public NhanVien getByPhoneNumber(string phonennum)
        {
            List<NhanVien> lists = new List<NhanVien>();
            string sqlQuery = "select * from NHANVIEN where SDT = @num ";
            DataTable data = DataHelper.Instance.getDataTable(sqlQuery, new string[] { phonennum });
            if (data.Rows.Count == 0)
                throw new Exception("Không tìm thấy sdt phù hợp...");
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
        public bool themNhanVien(string name, string cmnd, string phoneNum, string gender , string begin, string last,long luong)
        {
            NhanVien nhanVien = NhanVien_DAL.Instance.getByCMND(cmnd);
            if (nhanVien != null)
                throw new Exception("Cmnd đã được sử dụng");
            //-----------
            string sqlQuery = "select * from MARKER where MARK_TABLE = 'NHANVIEN'";
            DataTable data = DataHelper.Instance.getDataTable(sqlQuery);
            DataRow dataRow;
            if (data.Rows.Count > 0)
                dataRow = data.Rows[0];
            else throw new Exception("Không thể thêm nhân viên");
            int i = Int32.Parse(dataRow["NUMBER"].ToString());
            i++;
            string id = "NV" + i.ToString();
            //--------------
            sqlQuery = "insert into NHANVIEN(ID, HOTEN, CMND, SDT, GIOITINH, NGBD, TGHOPDONG , LUONG) " +
                                "values( @id , @tendn , @cmnd , @phoneNum , @gender , @begin , @last , @luong )";
            string[] parameter = new string[]
                { id, name , cmnd , phoneNum, gender , begin, last , luong.ToString() };
            int result = DataHelper.Instance.ExecuteNonQuery(sqlQuery, parameter);

            if (result > 0)
            {
                sqlQuery = "update MARKER set NUMBER = @i where MARK_TABLE ='NHANVIEN'";
                DataHelper.Instance.ExecuteNonQuery(sqlQuery, new object[] { i });
                return true;
            }
            return false;
        }

        public bool updatePhoneNumber(string cmnd, string phoneNum)
        {
            string sqlQuery = "update NHANVIEN set SDT = @phone where CMND = @cmnd ";
            int result = DataHelper.Instance.ExecuteNonQuery(sqlQuery, new string[] { phoneNum,cmnd });
            return result > 0;
        }
        public bool updateName(string cmnd, string name)
        {
            string sqlQuery = string.Format("UPDATE NHANVIEN SET HOTEN = @name WHERE CMND = @cmnd ");
            int result = DataHelper.Instance.ExecuteNonQuery(sqlQuery, new string[] { name, cmnd });
            return result > 0;
        }
        public bool xoaTheoId(string id)
        {
            string sqlQuery = string.Format("delete from NHANVIEN where ID = @id ");
            int result = DataHelper.Instance.ExecuteNonQuery(sqlQuery, new string[] { id });
            return result > 0;
        }
        public int LayTongLuongNV(DateTime dateTime)
        {
            string sqlQuery = string.Format("select sum(LUONG) from NHANVIEN where datediff(day,NGBD, @date ) > 29");
            DataTable result = DataHelper.Instance.getDataTable(sqlQuery, new string[] { dateTime.ToString("MM-dd-yyyy") });
            int a;
            if (result.Rows[0].ItemArray[0].ToString() != "") a = int.Parse(result.Rows[0].ItemArray[0].ToString());
            else a = 0;
            return a;
        }
    }
}
