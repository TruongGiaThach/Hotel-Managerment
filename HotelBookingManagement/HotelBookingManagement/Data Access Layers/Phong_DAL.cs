﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelBookingManagement.Data_Access_Layers
{
    class existenceRoom : Exception
    {
        public existenceRoom(string msg) : base(msg)
        {
        }
    }
    class Phong_DAL
    {
        private static Phong_DAL instance;

        public static Phong_DAL Instance
        {
            get { if (instance == null) instance = new Phong_DAL(); return Phong_DAL.instance; }
            private set => instance = value;
        }
        private Phong_DAL() { }
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
        public List<Phong> getByStatusAndType(string status, int type)
        {
            List<Phong> lists = new List<Phong>();
            string sqlQuery = "select * from PHONG where TRANGTHAI = @status and LOAI = @type ";
            DataTable data = DataHelper.Instance.getDataTable(sqlQuery, new string[] { status, type.ToString() });
            foreach (DataRow i in data.Rows)
            {
                Phong item = new Phong(i);
                lists.Add(item);
            };
            return lists;

        }
        public List<Phong> GetDsPhong()
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
        public bool themPhong(string id, int loai, int gia)
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
            int result = DataHelper.Instance.ExecuteNonQuery(sqlQuery, new string[] { status, id });
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