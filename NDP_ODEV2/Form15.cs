using System;
using System.Drawing;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace NDP_ODEV2
{
    public partial class Form15 : Form
    {
        private int planeY; 
        private int eggWidth = 80; 
        private int eggHeight = 100; 
        private int eggX, eggY; 
        private bool collisionDetected = false;

        public Form15()
        {
            InitializeComponent();
            DoubleBuffered = true;

      
            planeY = ClientSize.Height - 70;
            
            eggX = ClientSize.Width / 2 - eggWidth / 2;
            eggY = ClientSize.Height / 2 - eggHeight / 2;

            
            timer1.Start();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

           
            DrawPlane(e.Graphics, Brushes.Maroon, ClientSize.Width, planeY);
           
            DrawEgg(e.Graphics, Brushes.Blue, eggX, eggY, eggWidth, eggHeight);

            // Çarpışma varsa etikete "Çarpışma Var" yazar, yoksa "Yok" yazar
            if (collisionDetected)
            {
                BackColor = Color.Green;
                label1.Text = "Çarpışma Var";
            }
            else
            {
                BackColor = Color.White;
                label1.Text = "ÇARPIŞMA Yok";
            }
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
           
            eggX = e.X - eggWidth / 2;
            eggY = e.Y - eggHeight / 2;
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

        private void DrawEgg(Graphics g, Brush brush, int x, int y, int width, int height)
        {
            
            g.FillEllipse(brush, x, y, width, height / 2);
           
            g.FillEllipse(brush, x, y + height / 2, width, height / 2);

     
            g.DrawArc(Pens.Black, x, y, width, height, 0, 360);
          
            g.DrawArc(Pens.Black, x, y , width, height, 90, 180);
        }

        private void CheckCollision()
        {
        
            int eggTop = eggY;
            int eggBottom = eggY + eggHeight;

          
            int planeTop = planeY;

            // Çarpışma kontrolü
            bool collisionY = eggBottom > planeTop;

            if (collisionY)
                collisionDetected = true;
            else
                collisionDetected = false;
        }
    }
}
