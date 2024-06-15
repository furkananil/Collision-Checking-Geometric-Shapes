using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace NDP_ODEV2
{
    public partial class Form11 : Form
    {
        private int sphere1X, sphere1Y;
        private int sphere2X, sphere2Y;
        private int sphereRadius = 40;
        private bool collisionDetected = false;

        public Form11()
        {
            InitializeComponent();
            DoubleBuffered = true;

          
            sphere1X = 100;
            sphere1Y = 150;
        
            sphere2X = 400;
            sphere2Y = 150;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

           
            DrawSphere(e.Graphics, Brushes.Red, sphere1X, sphere1Y, sphereRadius);
            DrawSphere(e.Graphics, Brushes.Blue, sphere2X, sphere2Y, sphereRadius);

   
            DrawCircle(e.Graphics, Pens.Gray, sphere1X, sphere1Y, sphereRadius);
            DrawCircle(e.Graphics, Pens.Gray, sphere2X, sphere2Y, sphereRadius);

            // Çarpışma varsa etikete "Çarpışma Var" yazar, yoksa "Yok" yazar
            if (collisionDetected)
            {
                BackColor = Color.Green;
                label1.Text = "ÇARPIŞMA VAR";
            }
            else
            {
                BackColor = Color.White;
                label1.Text = "ÇARPIŞMA YOK";
            }
        }

        private void DrawSphere(Graphics g, Brush brush, int x, int y, int radius)
        {
          
            using (var gradientBrush = new LinearGradientBrush(new Point(x - radius, y - radius), new Point(x + radius, y + radius), Color.LightGray, Color.DarkGray))
            {
                g.FillEllipse(gradientBrush, x - radius, y - radius, 2 * radius, 2 * radius);
            }

          
            g.DrawEllipse(Pens.Black, x - radius, y - radius, 2 * radius, 2 * radius);
        }

        private void DrawCircle(Graphics g, Pen pen, int x, int y, int radius)
        {
            
            g.DrawEllipse(pen, x - radius, y - radius / 2, 2 * radius, radius);
        }

        private void CheckCollision()
        {
          
            double distance = Math.Sqrt(Math.Pow(sphere1X - sphere2X, 2) + Math.Pow(sphere1Y - sphere2Y, 2));

            // Çarpışma kontrolü
            if (distance < 2 * sphereRadius)
                collisionDetected = true;
            else
                collisionDetected = false;

        
            Invalidate();
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            
            sphere2X = e.X;
            sphere2Y = e.Y;
            label2.Text =e.Location.ToString();
        
            CheckCollision();
        }
    }
}
