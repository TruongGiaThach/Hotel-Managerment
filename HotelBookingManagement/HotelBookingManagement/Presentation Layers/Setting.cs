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
    public partial class Setting : Form
    {
        private Manager_Form manager_Form;
        private Login_Form login;
        public Setting(Manager_Form m,Login_Form l)
        {
            InitializeComponent();
            this.manager_Form = m;
            this.login = l;
        }

        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)

        {

            Graphics g = e.Graphics;

            Brush _textBrush;
            _textBrush = Brushes.Black;


            // Get the item from the collection.

            TabPage _tabPage = tabControl1.TabPages[e.Index];



            // Get the real bounds for the tab rectangle.

            Rectangle _tabBounds = tabControl1.GetTabRect(e.Index);



           



            // Use our own font.

            Font _tabFont = new Font("Microsoft Sans Serif", (float)16.0, FontStyle.Bold, GraphicsUnit.Pixel);



            // Draw string. Center the text.

            StringFormat _stringFlags = new StringFormat();

            _stringFlags.Alignment = StringAlignment.Center;

            _stringFlags.LineAlignment = StringAlignment.Center;

            g.DrawString(_tabPage.Text, _tabFont, _textBrush, _tabBounds, new StringFormat(_stringFlags));



        }

      

        private void button2_Click(object sender, EventArgs e)
        {
            manager_Form.logout(sender,e);
        }

        private void Setting_Load(object sender, EventArgs e)
        {
            NhanVien nhanVien = NhanVien_DAL.Instance.getNhanVienByID(manager_Form.currentUser.MaNV);
            this.textBox1.Text = nhanVien.HoTen;
            this.textBox2.Text = nhanVien.SoDT;
            this.textBox3.Text = nhanVien.Cmnd;
            this.textBox4.Text = manager_Form.currentUser.tenDN;
            this.textBox5.Text = manager_Form.currentUser.PhanQuyen;
        }
    }
}