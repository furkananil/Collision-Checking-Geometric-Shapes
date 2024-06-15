using System;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Windows.Forms;

namespace NDP_ODEV2
{
    public partial class Form14 : Form
    {
        private int planeY; 
        private int prismWidth = 80; 
        private int prismHeight = 100; 
        private int prismDepth = 40;
        private int prismX, prismY;
        private bool collisionDetected = false;
       
        public Form14()
        {
            InitializeComponent();
            DoubleBuffered = true;

          
            planeY = ClientSize.Height - 80;

            prismX = ClientSize.Width / 2 - prismWidth / 2;
            prismY = ClientSize.Height / 2 - prismHeight / 2;

            
            timer1.Start();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);


            DrawPlane(e.Graphics, Brushes.Maroon, ClientSize.Width, planeY);
            
            DrawPrism(e.Graphics, Brushes.Blue, prismX, prismY, prismWidth, prismHeight, prismDepth);

            // Çarpışma varsa etikete "Çarpışma Var" yazar, yoksa "Yok" yazar
            if (collisionDetected)
            {
                BackColor   = Color.Green;
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
       
            prismX = e.X - prismWidth / 2;
            prismY = e.Y - prismHeight / 2;
            label2.Text = e.Location.ToString();
          
            CheckCollision();

            Invalidate();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
            Invalidate();
        }

        private void DrawPlane(Graphics g, Brush brush, int width, int y)
        {
            g.FillRectangle(brush, 0, y, width, ClientSize.Height - y);
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

        private void CheckCollision()
        {
          
            int prismLeft = prismX;
            int prismRight = prismX + prismWidth + prismDepth;
            int prismTop = prismY;
            int prismBottom = prismY + prismHeight + prismDepth;

          
            int planeTop = planeY;

            // Çarpışma kontrolü
            bool collisionY = prismBottom > planeTop;

            if (collisionY)
                collisionDetected = true;
            else
                collisionDetected = false;
        }
    }
}
