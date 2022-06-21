using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Paint
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Width = 1000;
            this.Height = 700;
            bm = new Bitmap(pic.Width, pic.Height);
            g = Graphics.FromImage(bm);
            g.Clear(Color.White);
            pic.Image = bm;
            
            connect();
        }

        Bitmap bm;
        Graphics g;
        bool paint = false;
        Point px, py;
        Pen p = new Pen(Color.Black, 1);
        Pen eraser = new Pen(Color.White, 50);
        int index;
        int x, y, sX, sY, cX, cY;
        ColorDialog cd = new ColorDialog();
        Color new_color;
      
        private void pic_MouseDown(object sender, MouseEventArgs e)
        {
            paint = true;
            py = e.Location;
            cX = e.X;
            cY = e.Y;
        }

        private void btnRectangle_Click(object sender, EventArgs e)
        {
            index = 4;
        }

        private void btnLine_Click(object sender, EventArgs e)
        {
            index = 5;
        }

        private void pic_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            if (paint)
            {
                if (index == 3)
                {
                    g.DrawEllipse(p, cX, cY, sX, sY);
                }
                if (index == 4)
                {
                    g.DrawRectangle(p, cX, cY, sX, sY);
                }
                if (index == 5)
                {
                    g.DrawLine(p, cX, cY, x, y);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);     
            pic.Image = bm;
            index = 0;
            send();
        }

        private void pic_MouseMove(object sender, MouseEventArgs e)
        {
            if (paint)
            {
                if (index == 1)
                {
                    px = e.Location;
                    g.DrawLine(p, px, py);
                    py = px;
                }
                if (index == 2)
                {
                    px = e.Location;
                    g.DrawLine(eraser, px, py);
                    py = px;
                }   
                send();
            }
            pic.Refresh();
            x = e.X;
            y = e.Y;
            sX = e.X - cX;
            sY = e.Y - cY;
        }

        private void colorpicker_MouseClick(object sender, MouseEventArgs e)
        {
            Point point = set_point(colorpicker, e.Location);
            btnPicColor.BackColor = ((Bitmap)colorpicker.Image).GetPixel(point.X, point.Y);
            new_color = btnPicColor.BackColor;
            p.Color = btnPicColor.BackColor;
        }

        private void pic_MouseUp(object sender, MouseEventArgs e)
        {
            paint = false;
            sX = x - cX;
            sY = y - cY;

            if (index == 3)
            {
                g.DrawEllipse(p, cX, cY, sX, sY);
            }
            if (index == 4)
            {
                g.DrawRectangle(p, cX, cY, sX, sY);
            }
            if (index == 5)
            {
                g.DrawLine(p, cX, cY, x, y);
            }
            send();
        }

        private void btnPencil_Click(object sender, EventArgs e)
        {
            index = 1;
        }

        private void pic_MouseClick(object sender, MouseEventArgs e)
        {
            if (index == 7)
            {
                Point point = set_point(pic, e.Location);
                Fill(bm, point.X, point.Y, new_color);
            }
        }

        private void btnFill_Click(object sender, EventArgs e)
        {
            index = 7;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog();
            sfd.Filter = "Image(*.jpg)|*.jpg|(*.*|*.*";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Bitmap btm = bm.Clone(new Rectangle(0, 0, pic.Width, pic.Height), bm.PixelFormat);
                btm.Save(sfd.FileName,ImageFormat.Jpeg);
            }
        }

        private void btnEraser_Click(object sender, EventArgs e)
        {
            index = 2;
        }

        private void btnEsclipse_Click(object sender, EventArgs e)
        {
            index = 3;
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            cd.ShowDialog();
            new_color = cd.Color;
            btnPicColor.BackColor = new_color;
            p.Color = new_color;
        }

        static Point set_point(PictureBox pb, Point pt) {
            float pX = 1f * pb.Image.Width / pb.Width;
            float pY = 1f * pb.Image.Height / pb.Height;
            return new Point((int)(pt.X * pX), (int)(pt.Y * pY));
        }

        private void validate(Bitmap bm, Stack<Point> sp, int x, int y, Color old_color, Color new_color) {
            Color cx = bm.GetPixel(x, y);
            if (cx == old_color)
            {
                sp.Push(new Point(x, y));
                bm.SetPixel(x, y, new_color);
            }
        }

        public void Fill(Bitmap bm, int x, int y, Color new_clr) {
            Color old_color = bm.GetPixel(x, y);
            Stack<Point> pixel = new Stack<Point>();
            pixel.Push(new Point(x, y));
            bm.SetPixel(x, y, new_clr);
            if (old_color == new_clr) return;

            while (pixel.Count > 0)
            {
                Point pt = (Point)pixel.Pop();
                if (pt.X > 0 && pt.Y > 0 && pt.X < bm.Width - 1 && pt.Y < bm.Height - 1)
                {
                    validate(bm, pixel, pt.X - 1, pt.Y, old_color, new_clr);
                    validate(bm, pixel, pt.X, pt.Y - 1, old_color, new_clr);
                    validate(bm, pixel, pt.X + 1, pt.Y, old_color, new_clr);
                    validate(bm, pixel, pt.X, pt.Y + 1, old_color, new_clr);
                }
            }
        }

        ///////////////////////////////////////////////////////////////////
        
        IPEndPoint IP;
        Socket client;

        void connect()
        {
            // 26.109.181.236
            // 26.128.57.154
            IP = new IPEndPoint(IPAddress.Parse("26.109.181.236"), 14000);
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);

            try
            {
                client.Connect(IP);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "day la loi ket noi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Thread listen = new Thread(receive);
            listen.IsBackground = true;
            listen.Start();
        }

        void close()
        {
            client.Close();
        }

        void send()
        {
            client.Send(serialize(bm));
        }

        void receive()
        {
            try
            {
                while (true)
                {
                    byte[] data = new byte[1024 * 50000];
                    client.Receive(data);
                   
                    Bitmap img = (Bitmap)deseriablize(data);
                    updateImg(img);
                }
            }
            catch
            {
                // close();
            }
        }

        void updateImg(Bitmap img)
        {
            bm = img;
            g = Graphics.FromImage(bm);
            this.pic.Image = bm;
        }

        byte[] serialize(object obj)
        {
            MemoryStream stream = new MemoryStream();
            BinaryFormatter formatter = new BinaryFormatter();

            formatter.Serialize(stream, obj);
            return stream.ToArray();
        }

        object deseriablize(byte[] data)
        {
            MemoryStream stream = new MemoryStream(data);
            BinaryFormatter formatter = new BinaryFormatter();

            return formatter.Deserialize(stream);
        }
    }
}
