using System;
using System.Drawing;
using System.Windows.Forms;

namespace NDP_ODEV2
{
    public partial class Form9 : Form
    {
        private const int cylinderRadius = 40;
        private const int cylinderHeight = 200; 
        private Point cylinderPosition = new Point(150, 150); 
        private Point mousePosition;

        public Form9()
        {
            InitializeComponent();
            
            this.MouseMove += Form9_MouseMove;
        }

        private void Form9_MouseMove(object sender, MouseEventArgs e)
        {
            
            mousePosition = e.Location;
            label2.Text = "X: " + e.X.ToString() + ", Y: " + e.Y.ToString();
            
            CheckCollision();
            
            this.Invalidate();

        }

        private void CheckCollision()
        {
            // Mouse konumu, silindirin içinde mi kontrol et
            if (IsPointInsideCylinder(mousePosition, cylinderPosition, cylinderRadius, cylinderHeight))
            {
                label1.Text = "Çarpışma Var";
            }
            else
            {
                label1.Text = "Çarpışma Yok";
            }
        }

        private bool IsPointInsideCylinder(Point point, Point cylinderPosition, int radius, int height)
        {
            // Mouse konumu silindirin içinde mi kontrol et
            double distanceSquared = Math.Pow(point.X - (cylinderPosition.X + radius), 2) + Math.Pow(point.Y - (cylinderPosition.Y + height / 2), 2);
            if (distanceSquared <= radius * radius)
            {
                return true;
            }

            // Mouse konumu sol veya sağ çizgilerin içinde mi kontrol et
            if (point.Y >= cylinderPosition.Y && point.Y <= cylinderPosition.Y + height &&
                (point.X >= cylinderPosition.X - radius && point.X <= cylinderPosition.X + radius))
            {
                return true;
            }

            return false;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
          
            DrawCylinder(e.Graphics, cylinderPosition, cylinderRadius, cylinderHeight);
     
            e.Graphics.FillEllipse(Brushes.Red, mousePosition.X - 5, mousePosition.Y - 5, 10, 10);
        }

        private void DrawCylinder(Graphics g, Point position, int radius, int height)
        {
         
            int centerX = position.X + radius;
            int centerY = position.Y + height / 2;

      
            g.FillEllipse(Brushes.Blue, position.X - radius, position.Y, radius * 2, radius * 2);

  
            g.FillEllipse(Brushes.Blue, position.X - radius, position.Y + height - radius * 2, radius * 2, radius * 2);

            g.DrawLine(Pens.Blue, position.X - radius, centerY, position.X - radius, position.Y + radius);
            g.DrawLine(Pens.Blue, position.X + radius, centerY, position.X + radius, position.Y + radius);
            g.DrawLine(Pens.Blue, 190, 250, 190, 312);
            g.DrawLine(Pens.Blue, 110, 190, 110, 312);
        }
    }
}
