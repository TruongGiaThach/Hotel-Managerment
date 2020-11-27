
using System.Collections.Generic;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace HotelBookingManagement
{
    partial class Room_Show
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Room_Show));
            this.panel_RoomShow = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.imageList_RoomShow = new System.Windows.Forms.ImageList(this.components);
            this.panel_MenuBar = new System.Windows.Forms.Panel();
            this.buttonXoaPhong = new System.Windows.Forms.Button();
            this.buttonThemPhong = new System.Windows.Forms.Button();
            this.panel_RoomShow.SuspendLayout();
            this.panel_MenuBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_RoomShow
            // 
            this.panel_RoomShow.AutoScroll = true;
            this.panel_RoomShow.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel_RoomShow.Controls.Add(this.button1);
            this.panel_RoomShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_RoomShow.Location = new System.Drawing.Point(0, 78);
            this.panel_RoomShow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_RoomShow.Name = "panel_RoomShow";
            this.panel_RoomShow.Size = new System.Drawing.Size(1456, 282);
            this.panel_RoomShow.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1302, 242);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // imageList_RoomShow
            // 
            this.imageList_RoomShow.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList_RoomShow.ImageStream")));
            this.imageList_RoomShow.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList_RoomShow.Images.SetKeyName(0, "addRoom.png");
            this.imageList_RoomShow.Images.SetKeyName(1, "delRoom.png");
            // 
            // panel_MenuBar
            // 
            this.panel_MenuBar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel_MenuBar.Controls.Add(this.buttonXoaPhong);
            this.panel_MenuBar.Controls.Add(this.buttonThemPhong);
            this.panel_MenuBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_MenuBar.Location = new System.Drawing.Point(0, 0);
            this.panel_MenuBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_MenuBar.Name = "panel_MenuBar";
            this.panel_MenuBar.Size = new System.Drawing.Size(1456, 78);
            this.panel_MenuBar.TabIndex = 1;
            this.panel_MenuBar.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_MenuBar_Paint);
            // 
            // buttonXoaPhong
            // 
            this.buttonXoaPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonXoaPhong.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonXoaPhong.ImageIndex = 1;
            this.buttonXoaPhong.ImageList = this.imageList_RoomShow;
            this.buttonXoaPhong.Location = new System.Drawing.Point(353, 12);
            this.buttonXoaPhong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonXoaPhong.Name = "buttonXoaPhong";
            this.buttonXoaPhong.Size = new System.Drawing.Size(75, 64);
            this.buttonXoaPhong.TabIndex = 0;
            this.buttonXoaPhong.Text = "Xóa Phòng";
            this.buttonXoaPhong.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonXoaPhong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonXoaPhong.UseVisualStyleBackColor = true;
            this.buttonXoaPhong.Click += new System.EventHandler(this.buttonXoaPhong_Click);
            // 
            // buttonThemPhong
            // 
            this.buttonThemPhong.ImageIndex = 0;
            this.buttonThemPhong.ImageList = this.imageList_RoomShow;
            this.buttonThemPhong.Location = new System.Drawing.Point(273, 12);
            this.buttonThemPhong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonThemPhong.Name = "buttonThemPhong";
            this.buttonThemPhong.Size = new System.Drawing.Size(75, 64);
            this.buttonThemPhong.TabIndex = 0;
            this.buttonThemPhong.Text = "Thêm Phòng";
            this.buttonThemPhong.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonThemPhong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonThemPhong.UseVisualStyleBackColor = true;
            this.buttonThemPhong.Click += new System.EventHandler(this.buttonThemPhong_Click);
            // 
            // Room_Show
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1456, 360);
            this.Controls.Add(this.panel_RoomShow);
            this.Controls.Add(this.panel_MenuBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Room_Show";
            this.Text = "RoomShow";
            this.Load += new System.EventHandler(this.RoomShow_Load);
            this.panel_RoomShow.ResumeLayout(false);
            this.panel_MenuBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        #region bảng phòng
        private int MaxNumOfRoom = 4;
        public int NumOfRoom;
        private int margin = 10;
        List<System.Windows.Forms.Button> Rooms = new List<System.Windows.Forms.Button>();
        List<System.Windows.Forms.Button> SelectedButton = new List<Button>();
        private void InitRoom(DataTable Data)
        {
            SelectedButton.Clear();
            Rooms.Clear();
            this.panel_RoomShow.Controls.Clear();
            NumOfRoom = Data.Rows.Count;
            int drawPointX = this.margin;
            int drawPointY = this.margin;
            for (int i = 0; i < NumOfRoom; ++i)//create Rooms Buttom
            {
                bool trong;
                this.Rooms.Add(new System.Windows.Forms.Button());      //Add a Button in Rooms Button list
                //
                // set Button Properties
                //
                this.Rooms[i].ImageList = this.imageList_RoomShow;
                this.Rooms[i].Tag = false;
                if (Data.Rows[i].ItemArray[2].ToString().Contains("trong"))
                {
                    this.Rooms[i].ImageIndex = 2;
                    this.Rooms[i].BackColor = Color.White;
                    trong = true;
                }
                else
                {
                    this.Rooms[i].ImageIndex = 3;
                    this.Rooms[i].BackColor = Color.Silver;
                    trong = false;
                }
                this.Rooms[i].Name = Data.Rows[i].ItemArray[0].ToString();
                this.Rooms[i].Text = ((trong) ? "Trống" : "Đang Thuê") + "\n" + "Phòng " + Data.Rows[i].ItemArray[0].ToString();
                this.Rooms[i].Size = new System.Drawing.Size((this.panel_RoomShow.Width - ((MaxNumOfRoom + 1) * margin)) / MaxNumOfRoom, 100);
                if (i % MaxNumOfRoom != 0 || i == 0) drawPointX = ((i % MaxNumOfRoom) * Rooms[i].Width) + margin;
                else
                {
                    drawPointX = margin;
                    drawPointY += Rooms[i].Height + margin;
                }
                this.Rooms[i].TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
                this.Rooms[i].Location = new System.Drawing.Point(drawPointX, drawPointY);
                this.Rooms[i].Click += new EventHandler(RoomSelect); // set Click event for Button
                //this.Rooms[i].ContextMenuStrip;   // set ContexMenuStrip for Button
                this.panel_RoomShow.Controls.Add(Rooms[i]);
            }
        }
        #endregion

        private System.Windows.Forms.Panel panel_RoomShow;
        private ImageList imageList_RoomShow;
        private Panel panel_MenuBar;
        private Button buttonThemPhong;
        private Button buttonXoaPhong;
        private Button button1;
    }
}