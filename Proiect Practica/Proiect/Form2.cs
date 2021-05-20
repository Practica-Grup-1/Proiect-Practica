using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect
{
    public partial class Form2 : Form
    {
        float[] x, y;
        int nrobs;
        public FormAngajat parinte;
        public Form2()
        {
            InitializeComponent();
        }

        private void panel1_Resize(object sender, EventArgs e)
        {
            
            panel1.Invalidate();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
            Graphics g = e.Graphics;

            Rectangle zonaClient = e.ClipRectangle;
            Brush fundal = new SolidBrush(Color.White);

            g.FillRectangle(fundal, zonaClient);

            zonaClient.X += 40; zonaClient.Y += 40;
            zonaClient.Width -= 80; zonaClient.Height -= 80;

            Pen creionRosu = new Pen(Color.Red, 8);
            g.DrawRectangle(creionRosu, zonaClient);

            int vl = zonaClient.Left, vb = zonaClient.Bottom,
                vr = zonaClient.Right, vt = zonaClient.Top;

            float rap_dist_lat = 0.6f;
            float max;
            int lat, dist;
            string denx = "";

            SolidBrush[] pensule = new SolidBrush[]
                {
                    new SolidBrush (Color.RoyalBlue),
                    new SolidBrush (Color.Yellow),
                    new SolidBrush(Color.LightGreen),
                    new SolidBrush(Color.DarkCyan),
                    new SolidBrush (Color.Moccasin),
                    new SolidBrush(Color.DarkOrange)
                };

            SolidBrush pensulaCurenta;
            Pen creionCurent;

            max = x[0];
            int i;
            for (i = 1; i < nrobs; i++)
                if (max < x[i]) max = x[i];

            lat = (vr - vl) / (int)((nrobs + 1) * rap_dist_lat + nrobs);

            dist = (int)(lat * rap_dist_lat);

           

            creionCurent = new Pen(Color.Magenta);
            g.DrawLine(creionCurent, vl, vt, vl, vb);
            g.DrawLine(creionCurent, vl, vb, vr, vb);

            creionCurent = new Pen(Color.BlanchedAlmond);
            for (i = 0; i < nrobs; i++)
            {
                pensulaCurenta = pensule[(i % 6)];
                PointF pnt = new PointF(vl + dist + i * (lat + dist), (vb - x[i] * (vb - vt) / max));
                SizeF sz = new SizeF(lat, x[i] * (vb - vt) / max);
                g.FillRectangle(pensulaCurenta, new RectangleF(pnt, sz));

 
                 denx = y[i].ToString();
                g.DrawString(denx, Font, pensulaCurenta, vl + dist + i * (lat + dist) + lat / 3, vb + 5);
            }

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            InitializeComponent();
            this.ResizeRedraw = true;
            
            nrobs = 3;
            x = new float[] { 3,6,9 };
            y = new float[] { parinte.salmin, parinte.salmediu , parinte.salmax  };
        }



    }
}
