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
    public partial class Form3 : Form
    {
        private Point nokta;
        private Point merkez;
        private int cemberYaricap = 50; 

        public Form3()
        {
            InitializeComponent();
            nokta = new Point(100, 100); 
            merkez = new Point(ClientSize.Width / 2, ClientSize.Height / 2); 
            DoubleBuffered = true; 
            MouseMove += Form3_MouseMove; 
        }

        private void Form3_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

           
            g.DrawEllipse(Pens.Black, merkez.X - cemberYaricap, merkez.Y - cemberYaricap, cemberYaricap * 2, cemberYaricap * 2);
            g.FillEllipse(Brushes.Blue, merkez.X - cemberYaricap, merkez.Y - cemberYaricap, cemberYaricap * 2, cemberYaricap * 2);
            g.FillEllipse(Brushes.Red, nokta.X - 2, nokta.Y - 2, 4, 4);

          //EĞER ÇARPIŞMA VARSA ARKA PLANI YEŞİL YAP VE LABELDE ÇARPIŞMA VAR YAZ 
          //YOKSA ARKA PLANI BEYAZ YAP VE LABELDE ÇARPIŞMA YOK YAZ
            if (CarpismaKontrolu())
            {
                BackColor = Color.Green;
                label1.Text = "ÇARPIŞMA VAR";
                g.DrawString("", Font, Brushes.Green, 10, 10);
            }

            else
            {
                BackColor = Color.White;
                label1.Text = "ÇARPIŞMA YOK";
                g.DrawString("", Font, Brushes.Red, 10, 10);
            }
        }

        private bool CarpismaKontrolu()
        {
           
            double uzaklik = Math.Sqrt(Math.Pow(nokta.X - merkez.X, 2) + Math.Pow(nokta.Y - merkez.Y, 2));
           
            return uzaklik <= cemberYaricap;
        }

        private void Form3_MouseMove(object sender, MouseEventArgs e)
        {
           
            nokta = e.Location;
            label2.Text = "X;"+e.X.ToString()+" Y;"+e.Y.ToString();
            Refresh();
        }

    }
}
