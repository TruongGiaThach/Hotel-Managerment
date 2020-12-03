using HotelBookingManagement.Busines_Logic_Layers.Data_Transfer_Objects;
using HotelBookingManagement.Data_Access_Layers;
using HotelBookingManagement.Object;
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
        private bool isHasCustomer = false;
        public Reservation_Form(ref List<Phong> Rooms)
        {
            InitializeComponent();
            this.Data = Rooms;
            Reservation_Form_Load(new object { }, new EventArgs { });
        }

        private void Reservation_Form_Load(object sender, EventArgs e)
        {
            InitRoomFinder();
            var CheckButton = panel_Find_Room.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            if (CheckButton != null)
                this.LoaiPhong.Text = (CheckButton.Tag as Phong).LoaiPhong; 
        }

        private void radioButtons_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton Selected = sender as RadioButton;
            if (Selected.Checked)
            {
                if (Selected.Tag != null)
                    this.LoaiPhong.Text = (Selected.Tag as Phong).LoaiPhong;
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
                if (isHasCustomer)
                    check_addCus = true;
                else  check_addCus =  addCustomer_Controller.run(ten,gioitinh,sdt,email,cmnd);
                KhachHang khachHang = KhachHang_DAL.Instance.getByCMND(cmnd);
                //
                string loaiPhong = this.LoaiPhong.Text;
                DateTime ngbd = this.NgayDen.Value;
                DateTime ngkt = this.NgayDi.Value;
                var CheckButton = panel_Find_Room.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
                string RoomID = CheckButton.Text;
                check_addOrder =  DatPhong_DAL.Instance.themOrder(khachHang.ID, RoomID, ngbd.ToString(), ngkt.ToString(), "3", "Nothing");
                if (check_addOrder)
                {
                    (CheckButton.Tag as Phong).TrangThai = "dang cho";
                }

                MessageBox.Show("Thuê phòng thành công","Status");
                this.Close();
            }catch(Exception ex)
            {
                
                MessageBox.Show(ex.Message);
            }
        }

        private void CMT_TextChanged(object sender, EventArgs e)
        {
            KhachHang khachHangs = KhachHang_DAL.Instance.getByCMND(this.CMT.Text);
            if (khachHangs != null)
            {
                isHasCustomer = true;
                this.TenKhachHang.Text = khachHangs.HoTen;
                
                this.Phone.Text = khachHangs.SoDT;
                this.Email.Text = khachHangs.Email;
            }
        }
    }
}
