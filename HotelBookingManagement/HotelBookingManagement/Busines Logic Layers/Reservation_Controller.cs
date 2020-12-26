using HotelBookingManagement.Busines_Logic_Layers.Data_Transfer_Objects;
using HotelBookingManagement.Data_Access_Layers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingManagement.Busines_Logic_Layers
{
    class Reservation_Controller
    {
        public static bool execute(string ten,string gioitinh,string sdt,string email, string cmnd, string diachi, bool isHasCustomer,
            DateTime ngbd, DateTime ngkt, string RoomID,string dps,string node)
        {
            bool check_addCus = false;
            bool check_addOrder = false;
            if (isHasCustomer)
                check_addCus = true;
            else check_addCus = addCustomer_Controller.run(ten, gioitinh, sdt, email, cmnd, diachi);
            KhachHang khachHang = KhachHang_DAL.Instance.getByCMND(cmnd);
            node = (node.Length == 0) ? "Nothing" : node;
            //
            check_addOrder = DatPhong_DAL.Instance.themOrder(khachHang.ID, RoomID, ngbd.ToString(), ngkt.ToString(), "3",node,dps);
            return check_addOrder;
        }
    }
}
