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

        private void BookingForm_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            MinIndex = 0;
            MoveIndex = 0;
            MaxIndex = this.flowLayoutPanelPicturePreview.Width / 128;
        }

        #region Rooms Preview Control

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



    }
}
