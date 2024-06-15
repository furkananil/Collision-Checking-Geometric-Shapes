using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NDP_ODEV2
{
    public partial class Form5 : Form
    {
        private Rectangle rectangle;
        private Point mouseLocation;
        private Point circleCenter;
        private int circleRadius = 50; 
        private bool collision = false;

        public Form5()
        {
            InitializeComponent();
            rectangle = new Rectangle(100, 100, 100, 100);
            circleCenter = new Point(ClientSize.Width / 2, ClientSize.Height / 2); 
            MouseMove += Form5_MouseMove;
            SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint, true);
            UpdateStyles();
        }

        private void Form5_MouseMove(object sender, MouseEventArgs e)
        {
            mouseLocation = e.Location;
            CheckCollision();
            Invalidate(); 
        }

        private void CheckCollision()
        {
            
            int deltaX = Math.Max(rectangle.Left, Math.Min(circleCenter.X, rectangle.Right)) - circleCenter.X;
            int deltaY = Math.Max(rectangle.Top, Math.Min(circleCenter.Y, rectangle.Bottom)) - circleCenter.Y;

            // Eğer ÇEMBER dikdörtgenin içindeyse veya kenarına değiyorsa çarpışma var
            if ((deltaX * deltaX + deltaY * deltaY) <= (circleRadius * circleRadius))
            {
                collision = true;
            }
            else
            {
                collision = false;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
         
            g.FillRectangle(Brushes.Blue, rectangle);
          
            g.FillEllipse(Brushes.Red, circleCenter.X - circleRadius, circleCenter.Y - circleRadius, circleRadius * 2, circleRadius * 2);
            // Çarpışma durumuna göre label'ı güncelliyoruz
            if (collision)
            {
                BackColor = Color.Green;
                label1.Text = "Çarpışma var";
                
            }
            else
            {
                BackColor = Color.White;
                label1.Text = "Çarpışma yok";
            }
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            circleCenter = e.Location;
            label2.Text = "X;"+e.X.ToString()+" Y;"+e.Y.ToString();
            Invalidate(); 
        }
    }
}
