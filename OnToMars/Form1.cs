using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnToMars
{
    public partial class Form1 : Form
    {

        int brzinarakete;
        int brzinapadanja;
        bool levo;
        bool desno;
        int Poeni;
        Random r = new Random();
        public Form1()
        {
            InitializeComponent();
            Start();
        }

        private void Start()
        {
            btStart.Enabled = false;
            levo = false;
            desno = false;
            Poeni = 0;
            brzinapadanja = 15;
            brzinarakete = 10;
            pbRaketa.Left = 440;
            pbRaketa.Top = 630;
            pbMeteor.Left = r.Next(100, 333);
            pbMeteor.Top = r.Next(0, 30);
            pbMeteor2.Left = r.Next(333, 667);
            pbMeteor2.Top = r.Next(0, 30);
            pbMeteor3.Left = r.Next(667, 790);
            pbMeteor3.Top = r.Next(0, 30);
            pbMars.Left = 570;
            pbMars.Top = 0;
            timer1.Start();
        }

        private void Kraj()
        {
            timer1.Stop();
            btStart.Enabled = true;
            MessageBox.Show("Kraj igre, pokusajte ponovo!");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Poeni++;
            lbPoeni.Text = Convert.ToString(Poeni);
            pbMeteor.Top += brzinapadanja;
            pbMeteor2.Top += brzinapadanja;
            pbMeteor3.Top += brzinapadanja;
            pbMars.Visible = false;

            if (Poeni >= 300)
            {
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
            }

            if (Poeni >= 100)
            {
                if (brzinapadanja < 20)
                {
                    brzinapadanja = 20;
                }
                if (brzinarakete < 20)
                {
                    brzinarakete = 18;
                }
            }
            if (Poeni >= 300)
            {
                if (brzinapadanja < 40)
                {
                    brzinapadanja = 40;
                }
                if (brzinarakete < 35)
                {
                    brzinarakete = 25;
                }
            }
            if (Poeni >= 500)
            {
                if (brzinapadanja < 60)
                {
                    brzinapadanja = 60;
                }
                if (brzinarakete < 40)
                {
                    brzinarakete = 40;
                }
            }

            if (Poeni>=700)
            {
                timer1.Stop();
                pbMars.Visible = true;
                btStart.Enabled = true;
                MessageBox.Show("Nakon dugog putovanja nasa raketa je konacno stigla na svoje odrediste, crvenu planetu Mars!");
                MessageBox.Show("Igra je gotova, ako zelite da igrate igru ponovo pritisnite dugme Start.");
            }

            if(desno && pbRaketa.Left <= 800)
            {
                pbRaketa.Left += brzinarakete;
            }
            if(levo && pbRaketa.Left >= 100)
            {
                pbRaketa.Left -= brzinarakete;
            }
            

            if(pbMeteor.Top > 730)
            {
                pbMeteor.Left = r.Next(100, 333);
                pbMeteor.Top = r.Next(-110, 20);
            }
            if(pbMeteor2.Top > 730)
            {
                pbMeteor2.Left = r.Next(333, 667);
                pbMeteor2.Top = r.Next(-110, 20);
            }
            if(pbMeteor3.Top > 730)
            {
                pbMeteor3.Left = r.Next(667, 790);
                pbMeteor3.Top = r.Next(-110,20);
            }
            

            if(pbRaketa.Bounds.IntersectsWith(pbMeteor.Bounds))
            {
                Kraj();
            }
            if(pbRaketa.Bounds.IntersectsWith(pbMeteor2.Bounds))
            {
                Kraj();
            }
            if(pbRaketa.Bounds.IntersectsWith(pbMeteor3.Bounds))
            {
                Kraj();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Right)
            {
                desno = true;
            }
            if(e.KeyCode==Keys.Left)
            {
                levo = true;
            }
            if(e.KeyCode==Keys.Up)
            {
                brzinapadanja += 3;
                brzinarakete += 1;
            }
            if(e.KeyCode==Keys.Down)
            {
                if(brzinapadanja>=4)
                {
                    brzinapadanja -= 2;
                }
                if(brzinarakete>=4)
                {
                    brzinarakete -= 1;
                }
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Right)
            {
                desno = false;
            }
            if(e.KeyCode == Keys.Left)
            {
                levo = false;
            }
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            Start();
        }
    }
}
