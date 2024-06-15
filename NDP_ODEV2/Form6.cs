using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NDP_ODEV2
{
    public partial class Form6 : Form
    {
        private const int circleRadius = 50;
        private Point circle1Center = new Point(150, 150);
        private Point circle2Center = new Point(250, 250);
        private bool isCollision = false;

        public Form6()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.Paint += Form6_Paint;
            this.MouseMove += Form6_MouseMove;
        }

        private void Form6_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            // Çember 1
            Rectangle circle1Rect = new Rectangle(circle1Center.X - circleRadius, circle1Center.Y - circleRadius, 2 * circleRadius, 2 * circleRadius);
            g.FillEllipse(Brushes.Blue, circle1Rect);

            // Çember 2
            Rectangle circle2Rect = new Rectangle(circle2Center.X - circleRadius, circle2Center.Y - circleRadius, 2 * circleRadius, 2 * circleRadius);
            g.FillEllipse(Brushes.Red, circle2Rect);

            // Çarpışma kontrolü
            if (isCollision)
            {
                
                BackColor = Color.Green;
                label1.Text = "Çarpışma var";
            }
            else
            {
                BackColor= Color.White;
                label1.Text = "Çarpışma yok";
            }
        }

        private void Form6_MouseMove(object sender, MouseEventArgs e)
        {
           
            circle2Center = e.Location;
            label2.Text = "X;" + e.X.ToString() + " Y;" + e.Y.ToString();
            CheckCollision();

            this.Invalidate();
        }

        private void CheckCollision()
        {
            // Çarpışma kontrolü
            int distanceSquared = (circle2Center.X - circle1Center.X) * (circle2Center.X - circle1Center.X) +
                                  (circle2Center.Y - circle1Center.Y) * (circle2Center.Y - circle1Center.Y);
            int radiiSquared = (circleRadius + circleRadius) * (circleRadius + circleRadius);
            if (distanceSquared <= radiiSquared)
            {
                isCollision = true;
            }
            else
            {
                isCollision = false;
            }
        }
    }
}
