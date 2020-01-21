using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OmaLaboritoo
{
    public partial class Form1 : Form
    {
        Rectangle a = new Rectangle(10, 10, 130, 130);
        Rectangle b = new Rectangle(150, 10, 130, 130);
        Rectangle c = new Rectangle(290, 10, 130, 130);
        Rectangle d = new Rectangle(10, 150, 130, 130);
        Rectangle f = new Rectangle(150, 150, 130, 130);
        Rectangle g = new Rectangle(290, 150, 130, 130);
        Rectangle h = new Rectangle(10, 290, 130, 130);
        Rectangle k = new Rectangle(150, 290, 130, 130);
        Rectangle l = new Rectangle(290, 290, 130, 130);
        Rectangle m = new Rectangle(10, 430, 130, 130);
        Rectangle n = new Rectangle(150, 430, 130, 130);
        Rectangle o = new Rectangle(290, 430, 130, 130);


        public bool RectangleClicked { get; private set; }
        public bool RectangleClicked1 { get; private set; }
        public bool RectangleClicked2 { get; private set; }
        public bool RectangleClicked3 { get; private set; }
        public bool RectangleClicked4 { get; private set; }
        public bool RectangleClicked5 { get; private set; }
        public bool RectangleClicked6 { get; private set; }
        public bool RectangleClicked7 { get; private set; }
        public bool RectangleClicked8 { get; private set; }
        public bool RectangleClicked9 { get; private set; }
        public bool RectangleClicked10 { get; private set; }
        public bool RectangleClicked11 { get; private set; }
        public int RectangleX { get; private set; }
        public int RectangleY { get; private set; }
        public int RectangleA { get; private set; }
        public int RectangleB { get; private set; }
        public int RectangleC { get; private set; }
        public int RectangleD { get; private set; }
        public int RectangleE { get; private set; }
        public int RectangleF { get; private set; }
        public int RectangleG { get; private set; }
        public int RectangleH { get; private set; }
        public int RectangleJ { get; private set; }
        public int RectangleP{ get; private set; }
        public int RectangleO { get; private set; }
        public int RectangleK { get; private set; }
        public int RectangleL { get; private set; }
        public int RectangleM { get; private set; }
        public int RectangleN { get; private set; }
        public int RectangleU { get; private set; }
        public int RectangleR { get; private set; }
        public int RectangleS { get; private set; }
        public int RectangleV { get; private set; }
        public int RectangleI { get; private set; }
        public int RectangleW { get; private set; }
        public int RectangleT { get; private set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void PictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (RectangleClicked)
            {
                a.X = e.X - RectangleX;
                a.Y = e.Y - RectangleY;
            }
            if (RectangleClicked1)
            {
                b.X = e.X - RectangleA;
                b.Y = e.Y - RectangleB;
            }
            if (RectangleClicked2)
            {
                c.X = e.X - RectangleC;
                c.Y = e.Y - RectangleD;
            }
            if (RectangleClicked3)
            {
                d.X = e.X - RectangleE;
                d.Y = e.Y - RectangleF;
            }
            if (RectangleClicked4)
            {
                f.X = e.X - RectangleG;
                f.Y = e.Y - RectangleH;
            }
            if (RectangleClicked5)
            {
                g.X = e.X - RectangleJ;
                g.Y = e.Y - RectangleP;
            }
            if (RectangleClicked6)
            {
                h.X = e.X - RectangleO;
                h.Y = e.Y - RectangleK;
            }
            if (RectangleClicked7)
            {
                k.X = e.X - RectangleL;
                k.Y = e.Y - RectangleM;
            }
            if (RectangleClicked8)
            {
                l.X = e.X - RectangleN;
                l.Y = e.Y - RectangleU;
            }
            if (RectangleClicked9)
            {
                m.X = e.X - RectangleR;
                m.Y = e.Y - RectangleS;
            }
            if (RectangleClicked10)
            {
                n.X = e.X - RectangleV;
                n.Y = e.Y - RectangleI;
            }
            if (RectangleClicked11)
            {
                o.X = e.X - RectangleW;
                o.Y = e.Y - RectangleT;
            }
            pictureBox1.Invalidate();
        }

        private void PictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            RectangleClicked = false;
            RectangleClicked1 = false;
            RectangleClicked2 = false;
            RectangleClicked3 = false;
            RectangleClicked4 = false;
            RectangleClicked5 = false;
            RectangleClicked6 = false;
            RectangleClicked7 = false;
            RectangleClicked8 = false;
            RectangleClicked9 = false;
            RectangleClicked10 = false;
            RectangleClicked11 = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.LightGray, a);
            e.Graphics.FillRectangle(Brushes.LightGray, b);
            e.Graphics.FillRectangle(Brushes.LightGray, c);
            e.Graphics.FillRectangle(Brushes.LightGray, d);
            e.Graphics.FillRectangle(Brushes.LightGray, f);
            e.Graphics.FillRectangle(Brushes.LightGray, g);
            e.Graphics.FillRectangle(Brushes.LightGray, h);
            e.Graphics.FillRectangle(Brushes.LightGray, k);
            e.Graphics.FillRectangle(Brushes.LightGray, l);
            e.Graphics.FillRectangle(Brushes.LightGray, m);
            e.Graphics.FillRectangle(Brushes.LightGray, n);
            e.Graphics.FillRectangle(Brushes.LightGray, o);
        }

        private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if ((e.X < a.X + a.Width) && (e.X > a.X))
            {
                if ((e.Y < a.Y + a.Width) && (e.Y > a.Y))
                {
                    RectangleClicked = true;

                    RectangleX = e.X - a.X;
                    RectangleY = e.Y - a.Y;
                }
            }
            if ((e.X < b.X + b.Width) && (e.X > b.X))
            {
                if ((e.Y < b.Y + b.Width) && (e.Y > b.Y))
                {
                    RectangleClicked1 = true;

                    RectangleA = e.X - b.X;
                    RectangleB = e.Y - b.Y;
                }
            }
            if ((e.X < c.X + c.Width) && (e.X > c.X))
            {
                if ((e.Y < c.Y + c.Width) && (e.Y > c.Y))
                {
                    RectangleClicked2 = true;

                    RectangleC = e.X - c.X;
                    RectangleD = e.Y - c.Y;
                }
            }
            if ((e.X < d.X + d.Width) && (e.X > d.X))
            {
                if ((e.Y < d.Y + d.Width) && (e.Y > d.Y))
                {
                    RectangleClicked3 = true;

                    RectangleE = e.X - d.X;
                    RectangleF = e.Y - d.Y;
                }
            }
        }
    }
}
