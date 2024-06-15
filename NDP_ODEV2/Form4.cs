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
    public partial class Form4 : Form
    {
        private Rectangle rect1;
        private Rectangle rect2;


        public Form4()
        {

            this.Text = "Dikdörtgen Çarpışma Uygulaması";
            this.Size = new Size(800, 600);

            rect1 = new Rectangle(100, 100, 100, 200);


            rect2 = new Rectangle(0, 0, 50, 150);


            label1 = new Label();
            label1.Location = new Point(10, 10); // Etiketin form üzerindeki konumu
            label1.Size = new Size(100, 20); // Etiketin boyutu
            this.Controls.Add(label1); // Etiket formun kontrollerine ekleniyor

            this.StartPosition = FormStartPosition.CenterScreen;
            this.MouseMove += Form4_MouseMove;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);


            e.Graphics.FillRectangle(Brushes.Blue, rect1);
            e.Graphics.FillRectangle(Brushes.Red, rect2);

            // Çarpışma kontrolü YAP EĞER ÇARPIŞMA VARSA ARKA PLANI YEŞİL YAP VE LABELDE ÇARPIŞMA VAR YAZ 
            //YOKSA ARKA PLANI BEYAZ YAP VE LABELDE ÇARPIŞMA YOK YAZ
            if (rect1.IntersectsWith(rect2))
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

        private void Form4_MouseMove(object sender, MouseEventArgs e)
        {

            rect2.Location = e.Location;
            
            Invalidate();
        }

    }

}
