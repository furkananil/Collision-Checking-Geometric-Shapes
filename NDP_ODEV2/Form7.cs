using System;
using System.Drawing;
using System.Windows.Forms;

namespace NDP_ODEV2
{
    public partial class Form7 : Form
    {
        private Point mouseLocation;
        private Point sphereCenter;
        private int sphereRadius = 50;
        private bool collision = false;
        private Label collisionLabel;

        public Form7()
        {
            InitializeComponent();
            sphereCenter = new Point(200, 200); 
            collisionLabel = new Label
            {
                Location = new Point(10, 10),
                Size = new Size(200, 20)
            };
            this.Controls.Add(collisionLabel);
            this.MouseMove += Form7_MouseMove;
        }

        private void Form7_MouseMove(object sender, MouseEventArgs e)
        {
            mouseLocation = e.Location;
            label2.Text = e.Location.ToString();
            CheckCollision();
            Invalidate();
        }

        private void CheckCollision()
        {
       
            double distance = Math.Sqrt(Math.Pow(mouseLocation.X - sphereCenter.X, 2) + Math.Pow(mouseLocation.Y - sphereCenter.Y, 2));
            collision = distance < sphereRadius; 
            //ÇARPIŞMA VARSA ARKAPLANI YEŞİL YAP VE LABELE ÇARPIŞMA VAR YAZ
            //YOKSA ARKAPLANI BEYAZ YAP VE LABELE ÇARPIŞMA YOK YAZ
            if(collision)

            {
                BackColor = Color.Green;
                label1.Text = "ÇARPIŞMA VAR";
            }
            else
            {
                BackColor   = Color.White;
                label1.Text = "ÇARPIŞMA YOK";
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            
            g.FillEllipse(Brushes.Blue, sphereCenter.X - sphereRadius, sphereCenter.Y - sphereRadius, sphereRadius * 2, sphereRadius * 2);
           
            g.FillRectangle(Brushes.Red, mouseLocation.X - 5, mouseLocation.Y - 5, 10, 10);
        }
    }
}
