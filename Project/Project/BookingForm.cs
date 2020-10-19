using Project.dataComu;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
        private bool themDangKi(string ten, string sdt, string email,string ngbd, string ngkt, string loai)
        {

            if (string.IsNullOrWhiteSpace(ten) || string.IsNullOrWhiteSpace(email))
            {
                throw new Exception("Please Fill All The Fields");
            };
            long sodt = Int64.Parse(sdt);
            if (!email.Contains('@'))
                throw new Exception("Email sai format.....");
            int i;
            if (loai == null || loai == " ")
                i = 0;
            else i = Int32.Parse(loai);
            List<Phong> phong = DSPhong.Instance.getByStatusAndType("trong", i);
            string maphong = "";
            if (phong.Count != 0)
                maphong = phong[0].ID;
            else throw new Exception("Đã hết loại phòng được chọn ..");

            DSKhachHang.Instance.themKhachHang(ten, email, sdt, "");
            string makh = DSKhachHang.Instance.getByEmail(email).ID;
            return DSDangKi.Instance.themOrder( makh , maphong , ngbd ,ngkt ,"","");
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
                CultureInfo enUs = new CultureInfo("en-US");
                if (themDangKi(ten, sodt, email, ngbd.ToString("d",enUs), ngkt.ToString("d", enUs), loaiphong))
                {
                    MessageBox.Show("Đã đặt phòng thành công ><");
                    this.BookingForm_Load(sender,e);
                }
            }
            catch(FormatException fe)
            {
                MessageBox.Show("Số điện thoại nhâp sai...");
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
