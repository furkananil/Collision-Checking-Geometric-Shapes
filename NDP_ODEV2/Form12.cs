using System;
using System.Drawing;
using System.Windows.Forms;

namespace NDP_ODEV2
{
    public partial class Form12 : Form
    {
        private int sphereX, sphereY;
        private int cylinderX, cylinderY;
        private int cylinderWidth, cylinderHeight;
        private int sphereRadius = 40;
        private bool collisionDetected = false;

        public Form12()
        {
            InitializeComponent();
            DoubleBuffered = true;

            sphereX = 150;
            sphereY = 150;
         
            cylinderX = 300;
            cylinderY = 100;
            cylinderWidth = 100;
            cylinderHeight = 200;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

     
            DrawSphere(e.Graphics, Brushes.Red, sphereX, sphereY, sphereRadius);
            DrawSphereDepth(e.Graphics, Pens.Gray, sphereX, sphereY, sphereRadius);
      
            DrawCylinder(e.Graphics, Brushes.Blue, cylinderX, cylinderY, cylinderWidth, cylinderHeight);

            // Çarpışma varsa etikete "Çarpışma Var" yazar, yoksa "Yok" yazar
            if (collisionDetected)
            {
                BackColor = Color.Green;
                label1.Text = "Çarpışma Var";
            }
            else
            {
                BackColor = Color.White;
                label1.Text = "Çarpışma Yok";
            }
        }

        private void DrawSphere(Graphics g, Brush brush, int x, int y, int radius)
        {
            g.FillEllipse(brush, x - radius, y - radius, 2 * radius, 2 * radius);
        }

        private void DrawSphereDepth(Graphics g, Pen pen, int x, int y, int radius)
        {
            
            int depthRadius = 20;
            g.DrawEllipse(pen, x - depthRadius, y - radius, 2 * depthRadius, 2 * radius);
        }

        private void DrawCylinder(Graphics g, Brush brush, int x, int y, int width, int height)
        {
          
            g.FillRectangle(brush, x + 10, y, width - 20, height);

           
            g.FillEllipse(brush, x, y, 20, height);
            g.FillEllipse(brush, x + width - 20, y, 20, height);

         
            g.DrawLine(Pens.Black, x + 10, y, x + 10, y + height);
            g.DrawLine(Pens.Black, x + width - 10, y, x + width - 10, y + height);
        }

        private void CheckCollision()
        {
          
            int sphereCenterX = sphereX;
            int sphereCenterY = sphereY;

          
            int sphereLeft = sphereCenterX - sphereRadius;
            int sphereRight = sphereCenterX + sphereRadius;
            int sphereTop = sphereCenterY - sphereRadius;
            int sphereBottom = sphereCenterY + sphereRadius;

         
            int cylinderLeft = cylinderX;
            int cylinderRight = cylinderX + cylinderWidth;
            int cylinderTop = cylinderY;
            int cylinderBottom = cylinderY + cylinderHeight;

         
            bool collisionX = sphereLeft < cylinderRight && sphereRight > cylinderLeft;
            bool collisionY = sphereTop < cylinderBottom && sphereBottom > cylinderTop;

            // ÇARPIŞMAX VE ÇARPIŞMAY TRUE DÖNERSE ÇARPIŞMA TRUE DÖNDÜR BUNUN AKSİ HER DURUMDA ÇARPIŞMA FALSE DÖNDÜR
            if (collisionX && collisionY)
                collisionDetected = true;
            else
                collisionDetected = false;

            Invalidate();
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
           
            sphereX = e.X;
            sphereY = e.Y;
            label2.Text =e.Location.ToString();
            
            CheckCollision();
        }
    }
}
