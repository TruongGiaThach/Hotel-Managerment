using HotelBookingManagement.Data_Access_Layers;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelBookingManagement.Presentation_Layers
{

    public partial class PrintBill : Form
    {
        List<Phong> dsPhong;
        List<DangKi> dsDangKi;
        string tongTien;
        HoaDon hoadon;
        string ghichu; string chiphithem;
        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        public static extern long BitBlt(IntPtr hdcDest, int nXDest, int nYDest, int nWidth, int nHeight, IntPtr hdcSrc, int nXSrc, int nYSrc, int dwRop);
        private Bitmap memoryImage;
        public PrintBill(List<Phong> phongs,List<DangKi> dangKis,string tongTien,HoaDon hd,string ghichu,string chiphithem)
        {
            InitializeComponent();
            this.dsDangKi = dangKis;
            this.dsPhong = phongs;
            this.tongTien = tongTien;
            this.hoadon = hd;
            this.ghichu = ghichu;
            this.chiphithem = chiphithem;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CaptureScreen();
            PrinterSettings ps = new PrinterSettings();
            ps.Copies = 2;
            IEnumerable < PaperSize > paperSizes = ps.PaperSizes.Cast<PaperSize>();
            PaperSize sizeA5 = paperSizes.First<PaperSize>(size => size.Kind == PaperKind.A5);
            printDocument1.DefaultPageSettings.PaperSize = sizeA5;
            printPreviewDialog1.ShowDialog();
            Close();
        }

        private void CaptureScreen()
        {
            Graphics myGraphics = Parent_panel.CreateGraphics();
            Size s = Parent_panel.Size;
            memoryImage = new Bitmap(s.Width, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            IntPtr dc1 = myGraphics.GetHdc();
            IntPtr dc2 = memoryGraphics.GetHdc();
            BitBlt(dc2, 0, 0, Parent_panel.ClientRectangle.Width, Parent_panel.ClientRectangle.Height, dc1, 0, 0, 13369376);
            myGraphics.ReleaseHdc(dc1);
            memoryGraphics.ReleaseHdc(dc2);
            
        }
        private void PrintFrom_Resize(object sender,EventArgs e)
        {
            listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.columnHeader1.Width = Convert.ToInt32((double)listView1.Width * 0.1743);
            this.columnHeader2.Width = Convert.ToInt32((double)listView1.Width * 0.1465);
            this.columnHeader3.Width = Convert.ToInt32((double)listView1.Width * 0.2218);
            this.columnHeader4.Width = Convert.ToInt32((double)listView1.Width * 0.2273);
            this.columnHeader5.Width = Convert.ToInt32((double)listView1.Width * 0.2273);
        }
        private void PrintBill_Load(object sender, EventArgs e)
        {
            PrintFrom_Resize(sender, e);
            calculateRoomCost();
            this.label13.Text = DateTime.Now.ToString("dd/MM/yyyy");
            this.label14.Text = DateTime.Now.ToString("dd/MM/yyyy");
            this.label4.Text = "Sky Hotel";
            this.label6.Text = "Địa chỉ";
            KhachHang kh = new KhachHang();
            if (hoadon != null)
                kh = KhachHang_DAL.Instance.getByID(hoadon.MaKH);
            this.label5.Text = kh.HoTen;
            this.label7.Text = kh.DiaChi;
            this.label22.Text = this.ghichu;
            this.label23.Text = this.chiphithem;
            this.label21.Text = this.tongTien;
            this.label24.Text = this.hoadon.ID;
        }
        private int calculateRoomCost()
        {
            if (dsDangKi == null) return 0;
            int sum = 0;
            foreach (DangKi dangKi in this.dsDangKi)
            {
                Phong phong = Phong_DAL.Instance.getPhongbyId(dangKi.MaPhong);
                int soNgay = (int)Math.Ceiling((dangKi.NgayTraPhong - dangKi.NgayNhanPhong).TotalDays);
                int gia = soNgay * phong.GiaPhong;
                sum += gia;
                this.listView1.Items.Add(new ListViewItem (new string[] { phong.ID, soNgay.ToString(), 
                    dangKi.NgayNhanPhong.ToString("dd/MM/yyyy"), phong.GiaPhong.ToString(), gia.ToString() }));
            }
            return sum;
        }
    }
}
