using HotelBookingManagement.Busines_Logic_Layers.Data_Transfer_Objects;
using HotelBookingManagement.Data_Access_Layers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelBookingManagement
{
    public partial class Reservation_Form : Form
    {
        public Reservation_Form(ref List<Phong> Rooms)
        {
            InitializeComponent();
            this.Data = Rooms;
            Reservation_Form_Load(new object { }, new EventArgs { });
        }

        private void Reservation_Form_Load(object sender, EventArgs e)
        {
            InitRoomFinder();
        }

        private void radioButtons_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton Selected = sender as RadioButton;
            if (Selected.Checked)
            {
            }
        }

        private void HuyDatPhong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveDatPhong_Click(object sender, EventArgs e)
        {
            bool check_addCus = false;
            bool check_addOrder = false;
            string cmnd="";
            try
            {
                string ten = this.TenKhachHang.Text;
                string gioitinh = this.GioiTinh.SelectedItem.ToString();
                string sdt = this.Phone.Text;
                string email = this.Email.Text;
                cmnd = this.CMT.Text;
                check_addCus =  addCustomer_Controller.run(ten,gioitinh,sdt,email,cmnd);
                KhachHang khachHang = KhachHang_DAL.Instance.getByCMND(cmnd);
                //
                string loaiPhong = this.LoaiPhong.SelectedItem.ToString();
                DateTime ngbd = this.NgayDen.Value;
                DateTime ngkt = this.NgayDi.Value;
                var CheckButton = panel_Find_Room.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
                string RoomID = CheckButton.Text;
                check_addOrder =  DatPhong_DAL.Instance.themOrder(khachHang.ID, RoomID, ngbd.ToString(), ngkt.ToString(), "3", "Nothing");
                if (check_addOrder)
                {
                    (CheckButton.Tag as Phong).TrangThai = "dang cho";
                }

                MessageBox.Show("Thuê phòng thành công");
                this.Close();
            }catch(Exception ex)
            {
                if (check_addCus)
                    KhachHang_DAL.Instance.xoaTheoCMND(cmnd);

                MessageBox.Show(ex.Message);
            }
        }
    }
}
