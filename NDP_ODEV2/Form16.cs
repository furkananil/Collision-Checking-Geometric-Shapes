using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace NDP_ODEV2
{
    public partial class Form16 : Form
    {
        private int sphereX, sphereY; 
        private int sphereRadius = 40; 
        private int prismWidth = 80; 
        private int prismHeight = 100; 
        private int prismDepth = 40;
        private int prismX, prismY;
        private bool collisionDetected = false;

        public Form16()
        {
            InitializeComponent();
            DoubleBuffered = true;

     
            sphereX = ClientSize.Width / 2 - sphereRadius;
            sphereY = ClientSize.Height / 2 - sphereRadius;
       
            prismX = ClientSize.Width / 2 - prismWidth / 2;
            prismY = ClientSize.Height / 2 - prismHeight / 2;

         
            timer1.Start();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            DrawSphere(e.Graphics, Brushes.Red, sphereX, sphereY, sphereRadius);
            
            DrawPrism(e.Graphics, Brushes.Blue, prismX, prismY, prismWidth, prismHeight, prismDepth);

            int midX = sphereX + sphereRadius;
            int midY = sphereY + sphereRadius;
            int circleRadius = sphereRadius ;
            DrawHorizontalCircle(e.Graphics, Pens.Gray, midX, midY-20, circleRadius);

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

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
   
            sphereX = e.X - sphereRadius;
            sphereY = e.Y - sphereRadius;

           label2.Text=e.Location.ToString();
            CheckCollision();

            
            Invalidate();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            Invalidate();
        }

        private void DrawSphere(Graphics g, Brush brush, int x, int y, int radius)
        {
           
            Rectangle sphereRect = new Rectangle(x, y, 2 * radius, 2 * radius);
            using (var gradientBrush = new LinearGradientBrush(sphereRect, Color.LightGray, Color.DarkGray, LinearGradientMode.ForwardDiagonal))
            {
                g.FillEllipse(gradientBrush, x, y, 2 * radius, 2 * radius);
            }

            
            g.DrawEllipse(Pens.Black, x, y, 2 * radius, 2 * radius);
        }

        private void DrawPrism(Graphics g, Brush brush, int x, int y, int width, int height, int depth)
        {
           
            Point[] frontFace = { new Point(x, y), new Point(x + width, y), new Point(x + width + depth, y + depth), new Point(x + depth, y + depth) };
            g.FillPolygon(brush, frontFace);
            g.DrawPolygon(Pens.Black, frontFace);


            Point[] backFace = { new Point(x, y + height), new Point(x + width, y + height), new Point(x + width + depth, y + depth + height), new Point(x + depth, y + depth + height) };
            g.FillPolygon(brush, backFace);
            g.DrawPolygon(Pens.Black, backFace);

    
            g.DrawLine(Pens.Black, frontFace[0], backFace[0]);
            g.DrawLine(Pens.Black, frontFace[1], backFace[1]);
            g.DrawLine(Pens.Black, frontFace[2], backFace[2]);
            g.DrawLine(Pens.Black, frontFace[3], backFace[3]);
        }

        private void DrawHorizontalCircle(Graphics g, Pen pen, int x, int y, int radius)
        {
          
            g.DrawEllipse(pen, x - radius, y, 2 * radius, radius);
        }

        private void CheckCollision()
        {
       
            int sphereLeft = sphereX;
            int sphereRight = sphereX + 2 * sphereRadius;
            int sphereTop = sphereY;
            int sphereBottom = sphereY + 2 * sphereRadius;

            int prismLeft = prismX;
            int prismRight = prismX + prismWidth + prismDepth;
            int prismTop = prismY;
            int prismBottom = prismY + prismHeight + prismDepth;

            // Çarpışma kontrolü
            bool collisionX = sphereRight > prismLeft && sphereLeft < prismRight;
            bool collisionY = sphereBottom > prismTop && sphereTop < prismBottom;

            if (collisionX && collisionY)
                collisionDetected = true;
            else
                collisionDetected = false;
        }
    }
}
