using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace NDP_ODEV2
{
    public partial class Form13 : Form
    {
        private int planeY; 
        private int mouseSphereRadius = 50; 
        private int depthRadius = 50;
        private int mouseSphereX, mouseSphereY;
        private bool collisionDetected = false;

        public Form13()
        {
            InitializeComponent();
            DoubleBuffered = true;

          
            planeY = ClientSize.Height - 70;
       
            mouseSphereX = ClientSize.Width / 2;
            mouseSphereY = ClientSize.Height / 2;

        
            timer1.Start();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

     
            DrawPlane(e.Graphics, Brushes.Maroon, ClientSize.Width, planeY);

            DrawMouseSphere(e.Graphics, Brushes.Red, mouseSphereX, mouseSphereY, mouseSphereRadius);

            DrawDepthCircle(e.Graphics, Pens.Gray, mouseSphereX, mouseSphereY, depthRadius);

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
          
            mouseSphereX = e.X;
            mouseSphereY = e.Y;
            label2.Text =e.Location.ToString();
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

        private void DrawMouseSphere(Graphics g, Brush brush, int x, int y, int radius)
        {
        
            using (var gradientBrush = new LinearGradientBrush(new Point(x - radius, y - radius), new Point(x + radius, y + radius), Color.LightGray, Color.DarkGray))
            {
                g.FillEllipse(gradientBrush, x - radius, y - radius, 2 * radius, 2 * radius);
            }

        
            g.DrawEllipse(Pens.Black, x - radius, y - radius, 2 * radius, 2 * radius);
        }

        private void DrawDepthCircle(Graphics g, Pen pen, int x, int y, int radius)
        {
         
            g.DrawEllipse(pen, x - radius, y, 2 * radius, radius / 2);
        }

        private void CheckCollision()
        {
        
            int sphereCenterX = mouseSphereX;
            int sphereCenterY = mouseSphereY;

           
            int sphereTop = sphereCenterY - mouseSphereRadius;
            int sphereBottom = sphereCenterY + mouseSphereRadius;

           
            int planeTop = planeY;

            // Çarpışma kontrolü
            bool collisionY = sphereBottom > planeTop;

            if (collisionY)
                collisionDetected = true;
            else
                collisionDetected = false;
        }
    }
}
