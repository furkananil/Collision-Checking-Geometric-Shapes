using System;
using System.Drawing;
using System.Windows.Forms;

namespace NDP_ODEV2
{
    public partial class Form8 : Form
    {
        private Rectangle[] rects; 
        private Point mousePosition; 

        public Form8()
        {
            InitializeComponent();
            InitializePrism(); 
            this.Paint += Form8_Paint;
            this.MouseMove += Form8_MouseMove;
            this.DoubleBuffered = true;
        }

        private void InitializePrism()
        {
            
            rects = new Rectangle[]
            {
                new Rectangle(50, 50, 150, 100), 
                new Rectangle(75, 25, 150, 100) 
            };
        }

        private void Form8_Paint(object sender, PaintEventArgs e)
        {


            Graphics g = e.Graphics;
            g.Clear(Color.White);

            
            Point[] points = { new Point(74, 27), new Point(74, 50), new Point(50, 50) };
            g.FillPolygon(Brushes.LightBlue, points);
            g.DrawPolygon(Pens.Black, points);

            Point[] points0 = { new Point(200, 148), new Point(200, 125), new Point(224, 125) };
            g.FillPolygon(Brushes.LightBlue, points0);
            g.DrawPolygon(Pens.Black, points0);
          
            foreach (var rect in rects)
            {
                g.FillRectangle(Brushes.LightBlue, rect);
                g.DrawRectangle(Pens.Black, rect);
            }

      
            Point topLeft1 = new Point(rects[0].Left, rects[0].Top);
            Point topRight1 = new Point(rects[0].Right, rects[0].Top);
            Point bottomLeft1 = new Point(rects[0].Left, rects[0].Bottom);
            Point bottomRight1 = new Point(rects[0].Right, rects[0].Bottom);

            Point topLeft2 = new Point(rects[1].Left, rects[1].Top);
            Point topRight2 = new Point(rects[1].Right, rects[1].Top);
            Point bottomLeft2 = new Point(rects[1].Left, rects[1].Bottom);
            Point bottomRight2 = new Point(rects[1].Right, rects[1].Bottom);

            g.DrawLine(Pens.Black, topLeft1, topLeft2);
            g.DrawLine(Pens.Black, topRight1, topRight2);
            g.DrawLine(Pens.Black, bottomLeft1, bottomLeft2);
            g.DrawLine(Pens.Black, bottomRight1, bottomRight2);


            g.FillEllipse(Brushes.Red, mousePosition.X - 5, mousePosition.Y - 5, 10, 10);

            // Çarpışma kontrolü
            bool collision = IsCollision();
            if (collision)
            {
                BackColor = Color.Green;
                label1.Text = "Çarpışma Var";
            }
            else
            {
                label1.Text = "Çarpışma YOK";
                BackColor = Color.Red;
            }
        }

        private void Form8_MouseMove(object sender, MouseEventArgs e)
        {
          
            mousePosition = e.Location;
            label2.Text = "X: " + e.X.ToString() + ", Y: " + e.Y.ToString();
            Invalidate();
        }

        private bool IsCollision()
        {
            // Fare imleci prizma içinde mi kontrol et
            foreach (var rect in rects)
            {
                if (rect.Contains(mousePosition))
                    return true;
            }
            return false;
        }
    }
}