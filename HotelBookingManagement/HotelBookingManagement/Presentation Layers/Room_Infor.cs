using HotelBookingManagement.Busines_Logic_Layers.Data_Transfer_Objects;
using HotelBookingManagement.Data_Access_Layers;
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
    public partial class Room_Infor : Form     // add room  form
    {
        Form preForm = null;
        List<LoaiPhong> loaiPhongs;
        string id, gia,loai;
        string type;
        public Room_Infor(Form form, ref List<Phong> Data)
        {
            InitializeComponent();
            this.idTextbox.KeyPress += Normalisation.TextboxID_KeyPress;
            this.priceTextbox.KeyPress += Normalisation.TextboxOnlyDigit_KeyPress;
            this.preForm = form;
            this.Data = Data;
            this.id = string.Empty;
            this.type = "them";
            this.gia = string.Empty;
            loaiPhongs = LoaiPhong_DAL.Instance.getDS();
        }
        public Room_Infor(Form form, ref List<Phong> Data, string id, string loai, string gia)
        {
            InitializeComponent();
            this.preForm = form;
            this.Data = Data;
            this.id = id;
            this.loai = loai;
            this.gia = gia;
            this.type = "sua";
            loaiPhongs = LoaiPhong_DAL.Instance.getDS();
        }
        private bool addRoom(string id, string loai, string gia)
        {
            
            return Phong_DAL.Instance.themPhong(id,loai, Int32.Parse(gia.ToString()));
           
        }
        private bool updateRoom(string id,string loai, string gia)
        {
            return Phong_DAL.Instance.updateRoom(id, loai, gia);
        }
        private void RoomInfor_Load(object sender, EventArgs e)
        {
            this.comboBox1.Items.Clear();
            if (loaiPhongs.Count > 0)
                foreach (LoaiPhong loaiPhong in loaiPhongs)
                    this.comboBox1.Items.Add(loaiPhong.Ten);
            this.comboBox1.SelectedItem = this.comboBox1.Items[0];

            if (this.type == "sua")
            {
                this.idTextbox.Text = this.id;
                this.idTextbox.ReadOnly = true;
                this.comboBox1.SelectedItem = loai ;
                this.priceTextbox.Text = this.gia;
                this.addButton.Text = "Sửa";
                this.Text = "Sửa giá phòng";
                this.label4.Text = "Thông Tin Phòng";
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.priceTextbox.Text = loaiPhongs[this.comboBox1.SelectedIndex].Gia.ToString();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            

            try
            {
                if (loaiPhongs.Count == 0)
                    throw new Exception("Chưa có danh sách loại phòng");
                string id = this.idTextbox.Text;
                string loai = this.comboBox1.SelectedItem.ToString();
                string gia = this.priceTextbox.Text;
                if (type == "them")
                    if (addRoom(id, loai, gia))
                    {
                        MessageBox.Show("Thêm phòng thành công ><");
                        this.Data.Add(new Phong(id, loai, "trong", int.Parse(gia),0));
                        exitButton_Click(sender, e);
                    }
                if (type == "sua")
                    if (updateRoom(this.id,loai ,gia))
                    {
                        MessageBox.Show("Sửa phòng thành công ><");
                        foreach (Phong phong in this.Data)
                            if (phong.ID.Contains(this.id))
                            {
                                phong.LoaiPhong = loai;
                                phong.GiaPhong = Int32.Parse(gia);
                                break;
                            }
                        exitButton_Click(sender, e);
                    };

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                RoomInfor_Load(sender, e);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
            this.preForm.Show();
        }
    }
}
