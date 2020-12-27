using HotelBookingManagement.Busines_Logic_Layers;
using HotelBookingManagement.Busines_Logic_Layers.Data_Transfer_Objects;
using HotelBookingManagement.Data_Access_Layers;
using HotelBookingManagement.Object;
using HotelBookingManagement.Presentation_Layers;
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
            this.TienCoc.KeyPress+= Normalisation.TextboxOnlyDigit_KeyPress;
            this.TenKhachHang.KeyPress += Normalisation.TextboxOnlyLetter_KeyPress;
            //this.DiaChiNg.KeyPress += Normalisation.TextboxLetterAndDigitSpace_KeyPress;
            this.Phone.KeyPress += Normalisation.TextboxOnlyDigit_KeyPress;
            this.CMT.KeyPress += Normalisation.TextboxOnlyDigit_KeyPress;
            this.QuocTich.KeyPress += Normalisation.TextboxOnlyLetter_KeyPress;
            this.GhiChu.KeyPress += Normalisation.TextboxLetterAndDigitSpace_KeyPress;
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
        private bool datPhong()
        {
            try
            {
                string cmnd = "";
                string ten =(this.TenKhachHang.Text);
                string gioitinh = this.GioiTinh.SelectedItem.ToString();
                string sdt = (this.Phone.Text);
                string email = this.Email.Text;
                string diachi = this.DiaChiNg.Text;
                cmnd =(this.CMT.Text);
                string dps = this.TienCoc.Text;
                if (ten.Length == 0 || sdt.Length == 0 || cmnd.Length == 0)
                    throw new Exception("Tên, số điện thoại, cmnd là bắt buộc");
                //----------
                var CheckButton = panel_Find_Room.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
                string loaiPhong = this.LoaiPhong.Text;
                DateTime ngbd = this.NgayDen.Value;
                DateTime ngkt = this.NgayDi.Value;
                if (ngbd >= ngkt)
                    throw new Exception("Ngày đi phải sau ngày đến.");
                string RoomID = CheckButton.Text;
                string node = string.Format(this.GhiChu.Text);
                //----------
                return Reservation_Controller.execute(ten, gioitinh, sdt, email, cmnd, isHasCustomer, ngbd, ngkt, RoomID,dps,node,diachi);
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return false;
            }
        }
        private void SaveDatPhong_Click(object sender, EventArgs e) // dat va nhan phong
        {
            
            var CheckButton = panel_Find_Room.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            if (datPhong())
            {
                string RoomID = CheckButton.Text;
                (CheckButton.Tag as Phong).TrangThai = "dang cho";
                (CheckButton.Tag as Phong).TienCoc = Int32.Parse(TienCoc.Text);
                List<DangKi> dangKis = DatPhong_DAL.Instance.getByRoomAndStatus(RoomID, "dang cho");
                string maDK = "";
                if (dangKis != null)
                    maDK = dangKis[0].ID;
                DatPhong_DAL.Instance.nhanPhong(maDK, RoomID);
                MessageBox.Show("Thuê phòng thành công", "Status"); 
                this.Close();
            }
            else MessageBox.Show("Thuê phòng không thành công", "Status");
          
           
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

        private void button1_Click(object sender, EventArgs e) // dat phong
        {
            var CheckButton = panel_Find_Room.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            if (datPhong())
            {
                (CheckButton.Tag as Phong).TrangThai = "dang cho";
                (CheckButton.Tag as Phong).TienCoc = Int32.Parse(TienCoc.Text);
                MessageBox.Show("Đặt phòng thành công", "Status");
                this.Close();
            }
            else MessageBox.Show("Đặt phòng không thành công", "Status");
            
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }
    }
}
