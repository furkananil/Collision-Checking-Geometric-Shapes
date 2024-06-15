using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NDP_ODEV2
{
    public partial class Form2 : Form
    {


        Point point = new Point(50, 50);
        Rectangle rectangle = new Rectangle(100, 250, 75, 150);

        public Form2()
        {
            InitializeComponent();
            this.DoubleBuffered = true; 
        }

        private void Form2_MouseMove(object sender, MouseEventArgs e)
        {
            

            rectangle.Location = new Point(e.X, e.Y);
            label2.Text = Convert.ToString(e.X);
            label3.Text = Convert.ToString(e.Y);
            label6.Text = "50";
            label7.Text = "50";
            Invalidate(); 

            // Çarpışma kontrolü eğer nokta dikdörtgenin içerisindeyse arka planı yeşile çevirir ve labelda çarpışma var yazar
            //yoksa arka planı beyaza çevirir ve çarpışma yok yazar
            if (rectangle.Contains(point))
            {
                BackColor = Color.Green;
                label1.Text = "Çarpışma var";
            }
            else
            {
                BackColor = Color.White;
                label1.Text = "Çarpışma yok";
            }
        }

        private void Form2_Paint(object sender, PaintEventArgs e)
        {
            
            e.Graphics.FillEllipse(Brushes.Red, point.X - 2, point.Y - 2, 5, 5);
            e.Graphics.FillRectangle(Brushes.Blue, rectangle);

            
            e.Graphics.DrawRectangle(Pens.Blue, rectangle);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            rectangle.Location = new Point(rnd.Next(0, this.ClientSize.Width - rectangle.Width), rnd.Next(0, this.ClientSize.Height - rectangle.Height));
        }
    }
}
