using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelBookingManagement.Data_Access_Layers
{
 
    class HoaDon_DAL
    {
        private static HoaDon_DAL instance;

        public static HoaDon_DAL Instance
        {
            get { if (instance == null) instance = new HoaDon_DAL(); return HoaDon_DAL.instance; }
            private set => instance = value;
        }
        public HoaDon_DAL() { }
        public HoaDon getById(string id)
        {
            List<HoaDon> lists = new List<HoaDon>();
            string sqlQuery = "select * from HOADON where ID = @id ";
            DataTable data = DataHelper.Instance.getDataTable(sqlQuery, new string[] { id });
            foreach (DataRow i in data.Rows)
            {
                HoaDon item = new HoaDon(i);
                lists.Add(item);
            }
            if (lists.Count < 1)
                return null;
            return lists[0];
        }
        public List<HoaDon> getByMaKhachHang(string id)
        {
            List<HoaDon> lists = new List<HoaDon>();
            string sqlQuery = "select * from HOADON where MAKH = @makh ";
            DataTable data = DataHelper.Instance.getDataTable(sqlQuery, new string[] { id });
            foreach (DataRow i in data.Rows)
            {
                HoaDon item = new HoaDon(i);
                lists.Add(item);
            }
            return lists;
        }
        public List<HoaDon> GetDsHoaDon()
        {
            List<HoaDon> lists = new List<HoaDon>();
            string sqlQuery = "select * from HOADON";
            DataTable data = DataHelper.Instance.getDataTable(sqlQuery);
            foreach (DataRow i in data.Rows)
            {
                HoaDon item = new HoaDon(i);
                lists.Add(item);
            }
            return lists;
        }
        public bool themHoaDon(string maKH, string maNV)
        {
            string sqlQuery = "select * from MARKER where MARK_TABLE = 'HOADON'";
            DataTable data = DataHelper.Instance.getDataTable(sqlQuery);
            DataRow dataRow = data.Rows[0];
            int i = Int32.Parse(dataRow["NUMBER"].ToString());
            i++;
            string id = "HD" + i.ToString();
            //--------------
            sqlQuery = "insert into HOADON(ID,MAKH,MANV,TRIGIA) " +
                                "values( @id , @makh , @manv , @trigia )";
            string[] parameter = new string[]
                { id,maKH,maNV , "0" };
            int result = DataHelper.Instance.ExecuteNonQuery(sqlQuery, parameter);
            //--------------
            if (result > 1)
            {
                sqlQuery = "update MAKER set NUMBER = @i where MARK_TABLE ='HOADON'";
                DataHelper.Instance.ExecuteNonQuery(sqlQuery,new object[] { i});
                return true;
            }
            return false;
        }
        public bool xoaHoaDon(string id)
        {
            string sqlQuery = "delete from HOADON where ID = @id ";
            int result = DataHelper.Instance.ExecuteNonQuery(sqlQuery, new string[] { id });
            return result > 0;
        }
    }
}
