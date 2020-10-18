using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.dataComu
{
    class DSDangKi
    {
        private static DSDangKi instance;

        public static DSDangKi Instance
        {
            get { if (instance == null) instance = new DSDangKi(); return DSDangKi.instance; }
            private set => instance = value;
        }
        private DSDangKi() { }
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
        public bool themOrder(string makh , string maphong, string ngnhanphong,string ngtraphong,
             string tgdoiphong,string ghichu)
        {
            //-----------
            DangKi tk = getByStatus("root")[0];
            int i = tk.TgChoPhong;
            string id = "DK" + i.ToString();
            i++;
            string sqlQuery = "update DANGKI set TGDOIPHONG = @time where TRANGTHAIDON = @status ";
            DataHelper.Instance.ExecuteNonQuery(sqlQuery, new string[] { i.ToString(), "root" });
            //--------------
            sqlQuery = "insert into DANGKI(ID, MAKH, MAPHONG, NGNHANPHONG, NGTRAPHONG, TRANGTHAIDON, TGDOIPHONG, GHICHU) " +
          "values( @id , @makh , @maphong , @ngnhanphong , @ngtraphong , @trangthai , @tgdoiphong , @ghichu )";
            string[] parameter = new string[]
                { id, makh , maphong, ngnhanphong, ngtraphong, "dang cho" ,tgdoiphong,ghichu};
            int result = DataHelper.Instance.ExecuteNonQuery(sqlQuery, parameter);
            if (result == 1) 
            {
                DSPhong.Instance.updateStatus(maphong, "dang cho");
                return true; 
            };

            return false;
        }
       
        public bool xoaDangKi(string id)
        {
            string sqlQuery = "delete from DANGKI where ID = @id ";
            int result = DataHelper.Instance.ExecuteNonQuery(sqlQuery, new string[] { id });
            return result > 0;
        }
    }
}
