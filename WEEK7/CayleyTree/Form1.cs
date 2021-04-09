using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CayleyTree
{
    public partial class Form1 : Form
    {
        private Graphics graphics;
        double th1 = 30 * Math.PI / 180;
        double th2 = 30 * Math.PI / 180;
        double per1 = 0.6;
        double per2 = 0.7;
        Pen pen = Pens.Blue;

        public Form1()
        {
            InitializeComponent();
        }

        private void draw_Click(object sender, EventArgs e)
        {
            if (graphics == null) graphics = draw_panel.CreateGraphics();
            graphics.Clear(BackColor);
            drawCayleyTree(depth.Value, draw_panel.Width / 2, draw_panel.Height, (double)length.Value, -Math.PI / 2);
        }

        private void drawCayleyTree(int n, double x0, double y0, double leng, double th)
        {
            if (n == 0)
            {
                return;
            }

            var x1 = x0 + leng * Math.Cos(th);
            var y1 = y0 + leng * Math.Sin(th);
            drawLine(x0, y0, x1, y1);

            if ((int)x0 == (int)x1 && (int)y0 == (int)y1)
            {
                return;
            }

            drawCayleyTree(n - 1, x1, y1, per1 * leng, th + th1);
            drawCayleyTree(n - 1, x1, y1, per2 * leng, th - th2);
        }

        private void drawLine(double x0, double y0, double x1, double y1)
        {
            graphics.DrawLine(pen, (int)x0, (int)y0, (int)x1, (int)y1);
        }

        private void rdepth_Scroll(object sender, EventArgs e)
        {
            per1 = (double)rdepth.Value / 10;
        }

        private void ldepth_Scroll(object sender, EventArgs e)
        {
            per2 = (double)ldepth.Value / 10;
        }

        private void rangle_Scroll(object sender, EventArgs e)
        {
            th1 = (int)rangle.Value * Math.PI / 180;
        }

        private void langle_Scroll(object sender, EventArgs e)
        {
            th2 = (int)langle.Value * Math.PI / 180;
        }

        private void color_SelectedIndexChanged(object sender, EventArgs e)
        {
            Pen[] pens = { Pens.Black, Pens.Red,Pens.Blue, };
            pen = pens[color.SelectedIndex];
        }
    }

       
     
        }
    





