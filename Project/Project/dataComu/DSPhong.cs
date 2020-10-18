using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.dataComu
{
    class existenceRoom : Exception
    {
        public existenceRoom(string msg) : base(msg)
        {
        }
    }
    class DSPhong
    {
        private static DSPhong instance;

        public static DSPhong Instance
        {
            get { if (instance == null) instance = new DSPhong(); return DSPhong.instance; }
            private set => instance = value;
        }
        private DSPhong() { }
        public Phong getPhongbyId(string id)
        {
            List<Phong> lists = new List<Phong>();
            string sqlQuery = "select * from PHONG where ID = @id ";
            DataTable data = DataHelper.Instance.getDataTable(sqlQuery, new string[] { id });
            foreach (DataRow i in data.Rows)
            {
                Phong item = new Phong(i);
                lists.Add(item);
            }
            return lists[0];
        }
        public List<Phong> getByStatus(string status)
        {
            List<Phong> lists = new List<Phong>();
            string sqlQuery = "select * from PHONG where TRANGTHAI = @status ";
            DataTable data = DataHelper.Instance.getDataTable(sqlQuery, new string[] { status });
            foreach (DataRow i in data.Rows)
            {
                Phong item = new Phong(i);
                lists.Add(item);
            };
            return lists;

        }
        public List<Phong> GetDSPhong()
        {
            List<Phong> lists = new List<Phong>();
            string sqlQuery = "select * from PHONG";
            DataTable data = DataHelper.Instance.getDataTable(sqlQuery);
            foreach (DataRow i in data.Rows)
            {
                Phong item = new Phong(i);
                lists.Add(item);
            }
            return lists;
        }
        public bool themPhong(string id,int loai, int gia)
        {
            string sqlQuery = "select * from PHONG where ID = @id ";
            DataTable data = DataHelper.Instance.getDataTable(sqlQuery, new string[] { id });
            if (data.Rows.Count > 0)
                throw new existenceRoom("Phòng đã tồn tại...");
            sqlQuery = "insert into PHONG(ID, LOAI, GIAPHONG, TRANGTHAI) " +
                                "values( @id , @loai , @gia , @trangthai )";
            string[] parameter = new string[]
                { id, loai.ToString() , gia.ToString(), "trong" };
            int result = DataHelper.Instance.ExecuteNonQuery(sqlQuery, parameter);
            if (result == 1) return true;
            return false;
        }
        public bool updatePrice(string id, string gia)
        {
            string sqlQuery = "exec room_Update @id , @gia ";
            int result = DataHelper.Instance.ExecuteNonQuery(sqlQuery, new string[] { id, gia });
            return result > 0;
        }
        public bool updateStatus(string id, string status)
        {
            string sqlQuery = "update PHONG set TRANGTHAI = @status where ID = @id ";
            int result = DataHelper.Instance.ExecuteNonQuery(sqlQuery, new string[] { status,id });
            return result > 0;
        }
        public bool xoaPhong(string id)
        {
            string sqlQuery = "delete from PHONG where ID = @id ";
            int result = DataHelper.Instance.ExecuteNonQuery(sqlQuery, new string[] { id });
            return result > 0;
        }
    }
}
