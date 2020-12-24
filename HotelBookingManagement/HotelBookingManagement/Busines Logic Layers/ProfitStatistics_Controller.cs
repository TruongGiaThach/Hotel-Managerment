using HotelBookingManagement.Data_Access_Layers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelBookingManagement.Busines_Logic_Layers
{
    public class ProfitStatistics_Controller
    {
        public static void ThemChiTieu(string T_Dien, string T_Nuoc, string TongTien, string T_BaoTri, string T_Khac, DateTime Date)
        {
            int Luong = NhanVien_DAL.Instance.LayTongLuongNV(Date);
            ChiTieu_DAL.Instance.CheckNgayThongKe(Date.Year.ToString());
            string result = ChiTieu_DAL.Instance.ThemChiTieu(T_Dien, T_Nuoc, Luong.ToString(), T_BaoTri, T_Khac, TongTien, Date.Month.ToString(), Date.Year.ToString()) ? "Thêm Chi Tiêu Thành Công" : "Thêm Chi Tiêu Không Thành Công";
            MessageBox.Show(result);
        }
    }
}
