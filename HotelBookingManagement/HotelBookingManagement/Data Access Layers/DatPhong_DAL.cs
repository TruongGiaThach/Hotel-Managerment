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
    class DatPhong_DAL
    {
        private static DatPhong_DAL instance;

        public static DatPhong_DAL Instance
        {
            get { if (instance == null) instance = new DatPhong_DAL(); return DatPhong_DAL.instance; }
            private set => instance = value;
        }
        private DatPhong_DAL() { }
        public DangKi getByID(string id)
        {
            List<DangKi> lists = new List<DangKi>();
            string sqlQuery = "select * from DANGKI where ID = @id ";
            DataTable data = DataHelper.Instance.getDataTable(sqlQuery, new string[] { id });
            foreach (DataRow i in data.Rows)
            {
                DangKi item = new DangKi(i);
                lists.Add(item);
            }
            if (lists.Count < 1)
                return null;
            return lists[0];
        }
        public List<DangKi> getByRoomAndStatus(string roomID,string status)
        {
            List<DangKi> lists = new List<DangKi>();
            string sqlQuery = "select * from DANGKI where MAPHONG = @roomID and TRANGTHAIDON = @status ";
            DataTable data = DataHelper.Instance.getDataTable(sqlQuery, new string[] { roomID,status });
            foreach (DataRow i in data.Rows)
            {
                DangKi item = new DangKi(i);
                lists.Add(item);
            }
            if (lists.Count < 1)
                return null;
            return lists;
        }
        public List<DangKi> getByMaKH(string maKH)
        {
            List<DangKi> lists = new List<DangKi>();
            string sqlQuery = "select * from DANGKI where MAKH = @maKH ";
            DataTable data = DataHelper.Instance.getDataTable(sqlQuery, new string[] { maKH });
            foreach (DataRow i in data.Rows)
            {
                DangKi item = new DangKi(i);
                lists.Add(item);
            }
            if (lists.Count > 0)
                return lists;
            else return null;
        }

        public List<DangKi> getByStatus(string status)
        {
            List<DangKi> lists = new List<DangKi>();
            string sqlQuery = "select * from DANGKI where TRANGTHAIDON = @status ";
            DataTable data = DataHelper.Instance.getDataTable(sqlQuery, new string[] { status });
            foreach (DataRow i in data.Rows)
            {
                DangKi item = new DangKi(i);
                lists.Add(item);
            }
            return lists;
        }
        public bool themOrder(string makh, string maphong, string ngnhanphong, string ngtraphong,
             string tgdoiphong, string ghichu)
        {
            //-----------
            DangKi tk = getByNote("root")[0];
            int i = tk.TgChoPhong;
            string id = "DK" + i.ToString();
            i++;
            string sqlQuery = "update DANGKI set TGDOIPHONG = @time where GHICHU = @status ";
            DataHelper.Instance.ExecuteNonQuery(sqlQuery, new string[] { i.ToString(), "root" });
            //--------------
            sqlQuery = "insert into DANGKI(ID, MAKH, MAPHONG, NGNHANPHONG, NGTRAPHONG, TRANGTHAIDON, TGDOIPHONG, GHICHU) " +
          "values( @id , @makh , @maphong , @ngnhanphong , @ngtraphong , @trangthai , @tgdoiphong , @ghichu )";
            string[] parameter = new string[]
                { id, makh , maphong, ngnhanphong, ngtraphong, "dang cho" ,tgdoiphong,ghichu};
            int result = 0;
            try
            {
                result = DataHelper.Instance.ExecuteNonQuery(sqlQuery, parameter);
            } catch(Exception e)
            {
                throw new Exception(e.Message);
            }
            if (result > 0)
            {
                Phong_DAL.Instance.updateStatus(maphong, "dang cho");
                return true;
            };

            return false;
        }
        public bool nhanPhong(string maDK,string maPhong)
        {
            DangKi dk = DatPhong_DAL.Instance.getByID(maDK);
            Phong phong = Phong_DAL.Instance.getPhongbyId(maPhong);
            if (dk == null)
                return false;

            string maHD = null;
            List<DangKi> listDKofcurrentCustomer = DatPhong_DAL.Instance.getByMaKH(dk.MaKH);
            if (listDKofcurrentCustomer != null)
            {
                foreach (DangKi dangki in listDKofcurrentCustomer)                
                    if (dangki.TrangThaiDon.Contains("da nhan"))
                    {
                        maHD = dangki.MaHD; 
                        break;
                    }                
            };
             
            if (maHD == null)
            {
                HoaDon_DAL.Instance.themHoaDon(ref maHD,dk.MaKH, "");
            }

            string sqlQuery = "Update DANGKI set MAHD = @maHD where ID = @id ";
            DataHelper.Instance.ExecuteNonQuery(sqlQuery, new object[] { maHD, maDK });
            //---------------------------------------
            Phong_DAL.Instance.updateStatus(maPhong, "da nhan");
            sqlQuery = "Update DANGKI set TRANGTHAIDON = 'da nhan' where ID = @id ";
            return DataHelper.Instance.ExecuteNonQuery(sqlQuery, new object[] { maDK }) > 0;

            
        }
        public bool xoaDangKi(string id)
        {
            string sqlQuery = "delete from DANGKI where ID = @id ";
            int result = DataHelper.Instance.ExecuteNonQuery(sqlQuery, new string[] { id });
            return result > 0;
        }
        public List<DangKi> getByNote(string status)
        {
            List<DangKi> lists = new List<DangKi>();
            string sqlQuery = "select * from DANGKI where GHICHU = @status ";
            DataTable data = DataHelper.Instance.getDataTable(sqlQuery, new string[] { status });
            foreach (DataRow i in data.Rows)
            {
                DangKi item = new DangKi(i);
                lists.Add(item);
            }
            return lists;
        }
    }
}
