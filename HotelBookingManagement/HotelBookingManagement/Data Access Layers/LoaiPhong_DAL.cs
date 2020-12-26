using HotelBookingManagement.Busines_Logic_Layers.Data_Transfer_Objects;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingManagement.Data_Access_Layers
{
    class LoaiPhong_DAL
    {
        private static LoaiPhong_DAL instance;

        public static LoaiPhong_DAL Instance
        {
            get { if (instance == null) instance = new LoaiPhong_DAL(); return LoaiPhong_DAL.instance; }
            private set => instance = value;
        }
        public LoaiPhong_DAL() { }
        public List <LoaiPhong> getDS()
        {
            List<LoaiPhong> lists = new List<LoaiPhong>();
            string sqlQuery = "select * from LOAIPHONG";
            DataTable data = DataHelper.Instance.getDataTable(sqlQuery);
            foreach (DataRow i in data.Rows)
            {
                LoaiPhong item = new LoaiPhong(i);
                lists.Add(item);
            }
            return lists;
        }
        public bool themLoaiPhong( string ten, int gia)
        {
            string sqlQuery = "select * from MARKER where MARK_TABLE = 'LOAIPHONG'";
            DataTable data = DataHelper.Instance.getDataTable(sqlQuery);
            DataRow dataRow;
            if (data.Rows.Count > 0)
                    dataRow = data.Rows[0];
                else throw new Exception("Không thể thêm loại phòng");
            int i = Int32.Parse(dataRow["NUMBER"].ToString());
            i++;
            string id = i.ToString();
        //--------------------
            sqlQuery = "select * from LOAIPHONG where TENLP = @ten ";
            data = DataHelper.Instance.getDataTable(sqlQuery, new string[] { ten });
            if (data.Rows.Count > 0)
            {
                throw new existenceRoom("Đã có loại phòng này...");
                return false;
            }
            sqlQuery = "insert into LOAIPHONG(ID, TENLP , GIA) " +
                                "values( @id , @ten , @gia )";
            string[] parameter = new string[]
                { id, ten , gia.ToString()};
            int result = DataHelper.Instance.ExecuteNonQuery(sqlQuery, parameter);
            if (result > 0)
            {
                sqlQuery = "update MARKER set NUMBER = @i where MARK_TABLE ='LOAIPHONG'";
                DataHelper.Instance.ExecuteNonQuery(sqlQuery, new object[] { i });
                return true;
            }
            return false;
        }
        public bool xoaLoaiPhong(string ten)
        {

            string sqlQuery = "delete from LOAIPHONG where TENLP = @ten ";
            int result = DataHelper.Instance.ExecuteNonQuery(sqlQuery, new string[] { ten });
            return result > 0;
        }
        public bool updateRoomType(string ten,string gia)
        {
            string sqlQuery = "update LOAIPHONG set GIA = @gia where TENLP = @ten ";
            int result = DataHelper.Instance.ExecuteNonQuery(sqlQuery, new object[] { gia, ten });
            return result > 0;
        }
    }
}
