using HotelBookingManagement.Data_Access_Layers;
using HotelBookingManagement.Presentation_Layers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelBookingManagement.Busines_Logic_Layers
{
    public class CheckOut_Controller
    {
        public static void checkOut_openForm(List<Button> selectedButton, TaiKhoan tk)
        {
            try
            {
                int countSelectedRoom = selectedButton.Count;
                if (countSelectedRoom < 1)
                    throw new Exception("Cần chọn phòng để thực hiện");
                else if (countSelectedRoom > 1)
                    throw new Exception("Hãy chắc chắn chỉ có 1 phòng được chọn");
                Phong selectedRoom = selectedButton[0].Tag as Phong;
                if (!selectedRoom.TrangThai.Contains("da nhan"))
                    throw new Exception("Phòng đang được đặt hoặc còn trống, không thể thực hiện trả phòng");
                CheckOut_Form checkOut_Form = new CheckOut_Form(selectedRoom,tk);
                checkOut_Form.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public static bool _Execute(List<Phong> phongs,List<DangKi> dangKis,string tongTien,HoaDon hoaDon,string maNV)
        {
            bool b = false;
            try
            {
                foreach (Phong phong in phongs) 
                {
                    Phong_DAL.Instance.updateStatus(phong.ID, "trong");
                    Phong_DAL.Instance.updateDeposit(phong.ID, "0");
                    phong.TrangThai = "trong";
                    phong.TienCoc = 0;
                }
                foreach(DangKi dangKi in dangKis)
                {
                    DatPhong_DAL.Instance.updateStatus(dangKi.ID, "da thanh toan");
                    ThuChi_DAL.Instance.CheckNgayThongKe(dangKi.NgayTraPhong.Year.ToString());
                }
                HoaDon_DAL.Instance.updatePaid(hoaDon.ID, tongTien);
                HoaDon_DAL.Instance.updateStaffID(hoaDon.ID, maNV);
                HoaDon_DAL.Instance.updateInvoiceDate(hoaDon.ID, DateTime.Now.ToString());
                b = true;
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return b;
        }
    }
}
