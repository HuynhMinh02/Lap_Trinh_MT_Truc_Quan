using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace SimpleClock
{
    public partial class Form1 : Form
    {
        Timer t = new Timer();

        int Width = 300, Height = 300, secondHand = 140, minuteHand = 110, hourHand = 80;

        int x, y;

        Bitmap bitmap;
        Graphics graphics;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bitmap = new Bitmap(Width + 1, Height + 1);

            //Tâm của các kim đồng hồ
            x = Width / 2;
            y = Height / 2;

            // màu sắc nền 
            this.BackColor = Color.Green;

            t.Interval = 1000;
            t.Tick += new EventHandler(this.t_Tick);
            t.Start();
        }

        private void t_Tick(object sender, EventArgs e)
        {
            graphics = Graphics.FromImage(bitmap);

            int ss = DateTime.Now.Second;
            int mm = DateTime.Now.Minute;
            int hh = DateTime.Now.Hour;

            int[] handCoord = new int[2];


            graphics.Clear(Color.White);


            graphics.DrawEllipse(new Pen(Color.Black, 1f), 0, 0, Width, Height);


            graphics.DrawString("12", new Font("Arial", 12), Brushes.Red, new PointF(140, 2));
            graphics.DrawString("3", new Font("Arial", 12), Brushes.Red, new PointF(286, 140));
            graphics.DrawString("6", new Font("Arial", 12), Brushes.Red, new PointF(142, 282));
            graphics.DrawString("9", new Font("Arial", 12), Brushes.Red, new PointF(0, 140));


            handCoord = msCoord(ss, secondHand);
            graphics.DrawLine(new Pen(Color.Red, 1f), new Point(x, y), new Point(handCoord[0], handCoord[1]));


            handCoord = msCoord(mm, minuteHand);
            graphics.DrawLine(new Pen(Color.Black, 2f), new Point(x, y), new Point(handCoord[0], handCoord[1]));


            handCoord = hrCoord(hh % 12, mm, hourHand);
            graphics.DrawLine(new Pen(Color.Gray, 3f), new Point(x, y), new Point(handCoord[0], handCoord[1]));


            pictureBox1.Image = bitmap;


            this.Text = "Clock -  " + hh + ":" + mm + ":" + ss;


            graphics.Dispose();

        }

        private int[] msCoord(int val, int hlen)
        {
            int[] coord = new int[2];
            val *= 6; // val = val * 6

            if (val >= 0 && val <= 180)
            {
                coord[0] = x + (int)(hlen * Math.Sin(Math.PI * val / 180));
                coord[1] = y - (int)(hlen * Math.Cos(Math.PI * val / 180));
            }
            else
            {
                coord[0] = x - (int)(hlen * -Math.Sin(Math.PI * val / 180));
                coord[1] = y - (int)(hlen * Math.Cos(Math.PI * val / 180));
            }
            return coord;
        }

        private int[] hrCoord(int hval, int mval, int hlen)
        {
            int[] coord = new int[2];

            int val = (int)((hval * 30) + (mval * 0.5));

            if (val >= 0 && val <= 180)
            {
                coord[0] = x + (int)(hlen * Math.Sin(Math.PI * val / 180));
                coord[1] = y - (int)(hlen * Math.Cos(Math.PI * val / 180));
            }
            else
            {
                coord[0] = x - (int)(hlen * -Math.Sin(Math.PI * val / 180));
                coord[1] = y - (int)(hlen * Math.Cos(Math.PI * val / 180));
            }
            return coord;
        }
    }
}