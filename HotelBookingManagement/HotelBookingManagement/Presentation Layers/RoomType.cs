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

namespace HotelBookingManagement.Presentation_Layers
{
    public partial class RoomType : Form
    {
        private Point selectedCell;
        private string ten;
        private string gia;
        private List<Phong> dsPhong;
        public RoomType(List<Phong> phongs)
        {
            InitializeComponent();
            this.dsPhong = phongs;
            selectedCell = new Point(0, 0);
            this.textBox1.KeyPress += Normalisation.TextboxLetterAndDigitSpace_KeyPress;
            this.textBox2.KeyPress += Normalisation.TextboxOnlyDigit_KeyPress;
        }

        private void RoomType_Load(object sender, EventArgs e)
        {
            string sqlQuery = "select TENLP as [Loại phòng], GIA as [Giá] from LOAIPHONG";
            this.dataGridView1.DataSource = DataHelper.Instance.getDataTable(sqlQuery);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                selectedCell.X = e.ColumnIndex;
                selectedCell.Y = e.RowIndex;
                ten = this.dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                gia = this.dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                this.textBox1.Text = ten;
                this.textBox2.Text = gia;
            }

        }

        private void button1_Click(object sender, EventArgs e) //them
        {
            string loai = this.textBox1.Text;
            int gia;
            try
            {
                if (loai == ten)
                    return;
                if (this.textBox2.Text.Length == 0)
                    throw new Exception("Cần nhập giá cho phòng");
                gia = Int32.Parse(this.textBox2.Text.Split('.')[0]);
                if (gia > 0)
                    if (LoaiPhong_DAL.Instance.themLoaiPhong(loai, gia)) 
                        RoomType_Load(sender,e);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e) //change
        {
            string loai = this.textBox1.Text;
            int gia;
            try
            {
                if (loai != ten)
                    return;
                if (this.textBox2.Text.Length == 0)
                    throw new Exception("Cần nhập giá cho phòng");
                gia = Int32.Parse(this.textBox2.Text.Split('.')[0]);
                if (gia > 0)
                    if (LoaiPhong_DAL.Instance.updateRoomType(loai, gia.ToString()))
                        RoomType_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button3_Click(object sender, EventArgs e)//delete
        {
            string loai = this.textBox1.Text;
            try
            {
                if (loai != ten)
                    return;
                foreach (Phong phong in dsPhong)
                    if (loai == phong.LoaiPhong)
                        throw new Exception("Còn phòng loại này đang được sử dụng, không thể xóa");
                if (LoaiPhong_DAL.Instance.xoaLoaiPhong(loai))
                        RoomType_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button4_Click(object sender, EventArgs e)//exit
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string tmp = this.textBox1.Text;
            if (this.ten != tmp)
            {
                this.button1.Enabled = true;
                this.button3.Enabled = false;
            }
            else
            {
                this.button1.Enabled = false;
                this.button3.Enabled = true;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
