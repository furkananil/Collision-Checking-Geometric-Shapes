/****************************************************************************
**					SAKARYA ÜNÝVERSÝTESÝ
**			         BÝLGÝSAYAR VE BÝLÝÞÝM BÝLÝMLERÝ FAKÜLTESÝ
**				    BÝLGÝSAYAR MÜHENDÝSLÝÐÝ BÖLÜMÜ
**				          NESNEYE DAYALI PROGRAMLAMA DERSÝ
**	
**				ÖDEV NUMARASI…...:ÖDEV-2
**				ÖÐRENCÝ ADI...............:FURKAN ANIL ÖZDEMÝR
**				ÖÐRENCÝ NUMARASI.:B231210063
**				DERS GRUBU…………:B GRUBU
****************************************************************************/

namespace NDP_ODEV2
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
       
        private void CizButton_Click(object sender, EventArgs e)
        {
            //FORM 1DE CHECK EDÝLEN RADÝO BUTTONA GÖRE DÝÐER FORMLARIN AÇILMA ÝÞLEMÝ
            if (NoktaDortgenButton.Checked)
            {
                Form2 form2 = new Form2();

                form2.Show(); 
            }
            else if (NoktaCemberButton.Checked)
            {
                Form3 form3 = new Form3();
                form3.Show();
            }
            else if (DikdortgenButton.Checked)
            {
                Form4 form4 = new Form4();
                form4.Show();
            }
            else if (DikdortgenCemberButton.Checked)
            {
                Form5 form5 = new Form5();
                form5.Show();
            }
            else if (CemberButton.Checked)
            {
                Form6 form6 = new Form6();
                form6.Show();
            }
            else if (NoktaKureButton.Checked)
            {
                Form7 form7 = new Form7();
                form7.Show();
            }
            else if (NoktaPrizmaButton.Checked)
            {
                Form8 form8 = new Form8();
                form8.Show();
            }
            else if (NoktaSilindirButton.Checked)
            {
                Form9 form9 = new Form9();
                form9.Show();
            }
            else if (SilindirButton.Checked)
            {
                Form10 form10 = new Form10();
                form10.Show();
            }
            else if (KureButton.Checked)
            {
                Form11 form11 = new Form11();
                form11.Show();
            }
            else if (KureSilindirButton.Checked)
            {
                Form12 form12 = new Form12();
                form12.Show();
            }
            else if (YuzeyKureButton.Checked)
            {
                Form13 form13 = new Form13();
                form13.Show();
            }
            else if (YuzeyPrizmaButton.Checked)
            {
                Form14 form14 = new Form14();
                form14.Show();
            }
            else if (YuzeySilindirButton.Checked)
            {
                Form15 form15 = new Form15();
                form15.Show();
            }
            else if (KurePrizmaButton.Checked)
            {
                Form16 form16 = new Form16();
                form16.Show();
            }
            else if (DikdortgenPrizmaButton.Checked)
            {
                Form17 form17 = new Form17();
                form17.Show();
            }

        }

        private void NoktaDortgenButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void NoktaCemberButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void DikdortgenButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void DikdortgenCemberButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CemberButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void NoktaKureButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void NoktaPrizmaButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void NoktaSilindirButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void SilindirButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void KureButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void KureSilindirButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void YuzeyKureButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void YuzeyPrizmaButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void YuzeySilindirButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void KurePrizmaButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void DikdortgenPrizmaButton_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
