using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public bool themOrder(string makh ,string maphong,string ngnhanphong,string ngtraphong,
             string tgdoiphong,string ghichu)
        {
            string id = "";
            string sqlQuery = "insert into DANGKI(ID, MAKH, MAPHONG, NGNHANPHONG, NGTRAPHONG, TRANGTHAIDON, TGDOIPHONG, GHICHU) " +
          "values( @id , @makh , @maphong , @ngnhanphong , @ngtraphong , @trangthai , @tgdoiphong , @ghichu )";
            string[] parameter = new string[]
                { id, makh , maphong, ngnhanphong, ngtraphong, "dang cho" ,tgdoiphong,ghichu};
            int result = DataHelper.Instance.ExecuteNonQuery(sqlQuery, parameter);
            if (result == 1) return true;
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
