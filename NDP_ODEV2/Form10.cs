using System;
using System.Drawing;
using System.Windows.Forms;

namespace NDP_ODEV2
{
    public partial class Form10 : Form
    {
        private int silindir1X, silindir1Y;
        private int silindir2X, silindir2Y;
        private int silindirCapi = 80; 
        private bool carpismaVar = false;

        public Form10()
        {
            InitializeComponent();
            DoubleBuffered = true;

           
            silindir1X = 50;
            silindir1Y = ClientSize.Height / 2 - silindirCapi / 4;
           
            silindir2X = ClientSize.Width - 150;
            silindir2Y = ClientSize.Height / 2 - silindirCapi / 4;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

        
            DrawCylinder(e.Graphics, Brushes.Red, silindir1X, silindir1Y, silindirCapi);
            DrawCylinder(e.Graphics, Brushes.Blue, silindir2X, silindir2Y, silindirCapi);

            DrawConnectionLine(e.Graphics, Color.Black, silindir1X, silindir1Y + silindirCapi / 4, silindir1X, silindir1Y + 3 * silindirCapi / 4);
            DrawConnectionLine(e.Graphics, Color.Black, silindir1X + silindirCapi, silindir1Y + silindirCapi / 4, silindir1X + silindirCapi, silindir1Y + 3 * silindirCapi / 4);
            DrawConnectionLine(e.Graphics, Color.Black, silindir2X, silindir2Y + silindirCapi / 4, silindir2X, silindir2Y + 3 * silindirCapi / 4);
            DrawConnectionLine(e.Graphics, Color.Black, silindir2X + silindirCapi, silindir2Y + silindirCapi / 4, silindir2X + silindirCapi, silindir2Y + 3 * silindirCapi / 4);

            // Çarpışma varsa etikete "Çarpışma Var" yazar, yoksa "Yok" yazar
            if (carpismaVar)
            {
                BackColor   = Color.Green;
                label1.Text = "ÇARPIŞMA VAR";
            }
            else
            {
                BackColor= Color.White;
                label1.Text = "ÇARPIŞMA YOK";
            }
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            label2.Text = e.Location.ToString();
            silindir2X = e.X - silindirCapi / 2;
            silindir2Y = e.Y - silindirCapi / 4;

            // Çarpışma kontrolü
            double distanceBetweenCenters = Math.Sqrt(Math.Pow(silindir1X + silindirCapi / 2 - silindir2X - silindirCapi / 2, 2) +
                                              Math.Pow(silindir1Y + silindirCapi / 2 - silindir2Y - silindirCapi / 2, 2));
            if (distanceBetweenCenters < silindirCapi)
                carpismaVar = true;
            else
                carpismaVar = false;

      
            Invalidate();
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
       
            silindir1Y = ClientSize.Height / 2 - silindirCapi / 4;
            silindir2Y = ClientSize.Height / 2 - silindirCapi / 4;

            // Çarpışma kontrolü
            double distanceBetweenCenters = Math.Sqrt(Math.Pow(silindir1X + silindirCapi / 2 - silindir2X - silindirCapi / 2, 2) +
                                              Math.Pow(silindir1Y + silindirCapi / 2 - silindir2Y - silindirCapi / 2, 2));
            if (distanceBetweenCenters < silindirCapi)
            {
                
                carpismaVar = true;
            }
            else
            {
              
                
                carpismaVar = false;
            }

         
            Invalidate();
        }

     
        private void DrawCylinder(Graphics g, Brush brush, int x, int y, int cap)
        {
            g.FillEllipse(brush, x, y, cap, cap / 2);
            g.FillEllipse(brush, x, y + cap / 2, cap, cap / 2);
        }

 
        private void DrawConnectionLine(Graphics g, Color color, int x1, int y1, int x2, int y2)
        {
            using (Pen pen = new Pen(color, 2))
            {
                g.DrawLine(pen, x1 , y1 , x2 , y2 );
            }
        }
    }
}
