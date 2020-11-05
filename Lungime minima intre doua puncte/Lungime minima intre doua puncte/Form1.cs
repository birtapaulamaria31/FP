using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lungime_minima_intre_doua_puncte
{
    public partial class Form1 : Form
    {
        Bitmap bmp;
        Graphics grp;
        static Random rnd = new Random();

        public class point
        {

            public float x, y;
            public point()
            {
                x = rnd.Next(800);
                y = rnd.Next(400);
            }

            public void draw(Graphics grp)
            {
                grp.DrawEllipse(new Pen(Color.Navy, 2), x, y, 2, 2);
            }
        }

        public float distanta(float x1, float y1, float x2, float y2)
        {
            float dist;
            dist = (float)Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)));
            return dist;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            grp = Graphics.FromImage(bmp);
            grp.Clear(Color.Coral);

            int n = 100, i, j, k;
            point aux;
            float distantaMinima, distantaCurenta;
            point[] t = new point[n];

            for (i = 0; i < n; i++)
                t[i] = new point();

            for (i = 0; i < n; i++)
                t[i].draw(grp);



            for (i = 0; i < n - 1; i++)
            {
                distantaMinima = distanta(t[i].x, t[i].y, t[i + 1].x, t[i + 1].y);
                k = i + 1;
                for (j = i + 1; j < n; j++)
                {
                    distantaCurenta = distanta(t[i].x, t[i].y, t[j].x, t[j].y);
                    if (distantaCurenta < distantaMinima)
                    {
                        distantaMinima = distantaCurenta;
                        k = j;
                    }
                }
                aux = t[i + 1];
                t[i + 1] = t[k];
                t[k] = aux;
                grp.DrawLine(Pens.Aqua, t[i].x, t[i].y, t[i + 1].x, t[i + 1].y);
            }

            pictureBox1.Image = bmp;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
