using Project.dataComu;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class BookingForm : Form
    {
        private LoginForm loginForm;
        private TaiKhoan currentUser;
        public BookingForm(LoginForm form, TaiKhoan user)
        {
            InitializeComponent();
            InitalizePreviewPanel();
            this.loginForm = form;
            this.currentUser = user;
        }

        #region Rooms Preview Control
        private int MinIndex = 0;
        private int MoveIndex = 0;
        private int MaxIndex = 3;
        private void buttonMoveLeft_Click(object sender, EventArgs e)
        {
            if (MoveIndex == MinIndex && MinIndex != 0)
            {
                flowLayoutPanelPicturePreview.Controls.Clear();
                for (int i = MinIndex - 1; i < i+3 && i < ROOMS.Length; ++i)
                {

                    flowLayoutPanelPicturePreview.Controls.Add(ROOMS[i]);
                }
                MinIndex--;
                MaxIndex--;
                MoveIndex--;
                ROOMS[MoveIndex].Select();
            }
            else if (MoveIndex > MinIndex)
            {
                MoveIndex--;
                ROOMS[MoveIndex].Select();
            }
        }

        private void buttonMoveRight_Click(object sender, EventArgs e)
        {
            if (MoveIndex == MaxIndex && MaxIndex != ROOMS.Length - 1)
            {
                flowLayoutPanelPicturePreview.Controls.Clear();
                for (int i = MinIndex + 1; i < i+3 && i < ROOMS.Length; ++i)
                {
                    flowLayoutPanelPicturePreview.Controls.Add(ROOMS[i]);
                }
                MinIndex++;
                MaxIndex++;
                MoveIndex++;
                ROOMS[MoveIndex].Select();
            }
            else if (MoveIndex < MaxIndex)
            {
                MoveIndex++;
                ROOMS[MoveIndex].Select();
            }
        }

        #endregion

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lostCancelButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            this.loginForm.Show();
        }

        private void BookingForm_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            MaxIndex = this.flowLayoutPanelPicturePreview.Width / 128;
        }
        private bool themDangKi(string makh, string maphong, string ngnhanphong, string ngtraphong,
             string tgdoiphong, string ghichu)
       {
            return DSDangKi.Instance.themOrder( makh , maphong , ngnhanphong,ngtraphong,tgdoiphong,ghichu);
        }
        private void materialButtonReserver_Click(object sender, EventArgs e) // xac nhan
        {
            string ten,email,sodt,loaiphong;
            DateTime ngbd, ngkt;
            try
            {
                ten = this.textBoxName.Text;
                email = this.textBoxEmail.Text;
                sodt = this.textBoxPhoneNumber.Text;
                if (this.comboBoxRoomType.SelectedIndex == -1)
                {
                    throw new Exception("Bạn chưa chọn loại phòng...");
                }
                loaiphong = this.comboBoxRoomType.SelectedItem.ToString();
                ngbd = this.dateTimePickerFrom.Value;
                ngkt = this.dateTimePickerTo.Value;
                if (ngkt <= ngbd || ngbd < DateTime.Now)
                    throw new Exception("Vui lòng nhập lại ngày tháng...");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBoxRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
