using System;
using System.Drawing;
using System.Windows.Forms;

namespace NDP_ODEV2
{
    public partial class Form17 : Form
    {
        private int prismWidth = 80; 
        private int prismHeight = 100; 
        private int prismDepth = 40;
        private int prism1X, prism1Y; 
        private int prism2X = 400, prism2Y = 150; 
        private bool collisionDetected = false;

        public Form17()
        {
            InitializeComponent();
            DoubleBuffered = true;

            prism1X = 100;
            prism1Y = 150;

            timer1.Start();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            
            DrawPrism(e.Graphics, Brushes.Blue, prism1X, prism1Y, prismWidth, prismHeight, prismDepth);
           
            DrawPrism(e.Graphics, Brushes.Green, prism2X, prism2Y, prismWidth, prismHeight, prismDepth);

            // Çarpışma varsa etikete "Çarpışma Var" yazar ve arka planı yeşil yapar, yoksa "Yok" yazar ve arka planı beyaz yapar
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

        private void timer1_Tick(object sender, EventArgs e)
        {
          
            Invalidate();
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
        
            int prism1Left = prism1X;
            int prism1Right = prism1X + prismWidth + prismDepth;
            int prism1Top = prism1Y;
            int prism1Bottom = prism1Y + prismHeight + prismDepth;

            int prism2Left = prism2X;
            int prism2Right = prism2X + prismWidth + prismDepth;
            int prism2Top = prism2Y;
            int prism2Bottom = prism2Y + prismHeight + prismDepth;

           
            bool collisionX = prism1Right > prism2Left && prism1Left < prism2Right;
            bool collisionY = prism1Bottom > prism2Top && prism1Top < prism2Bottom;
            
            //eğer çarpışmax ve çarpışmay true ise çarpışma true döner ve yukarıdaki if i tetikleyip labela çarpışma var yazdırır
            if (collisionX && collisionY)
                collisionDetected = true;
            else
                collisionDetected = false;
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
          
            prism1X = e.X - prismWidth / 2;
            prism1Y = e.Y - prismHeight / 2;
            label2.Text=e.Location.ToString();
            CheckCollision();

            Invalidate();
        }
    }
}
