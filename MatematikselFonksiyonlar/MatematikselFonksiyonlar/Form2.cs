using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace MatematikselFonksiyonlar
{
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void Anasayfa_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Giris fr = new Giris();
            fr.Show();
            this.Hide();
            fr.Close();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            FileStream dosyaAdi;
            StreamWriter stryaz;
            dosyaAdi = new FileStream(@"C:\Users\asus\Desktop\cikti.txt", FileMode.Append);
            stryaz = new StreamWriter(dosyaAdi);

            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox13.Text);

            if (a < b)
            {

                for (int i = 2; i <= b; i++)
                {
                    if (a % i == 0 && b % i == 0)
                    {
                        textBox2.Text = "" + i;
                    }
                }
            }
            else
            {
                for (int i = 2; i <= a; i++)
                {
                    if (a % i == 0 && b % i == 0)
                    {
                        textBox2.Text = "" + i;
                    }
                }
            }
            stryaz.WriteLine("EBOB Bul : " + textBox1.Text + " " + textBox13.Text);
            stryaz.WriteLine("" + textBox2.Text);
            stryaz.Close();
            Console.ReadLine();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FileStream dosyaAdi;
            StreamWriter stryaz;
            dosyaAdi = new FileStream(@"C:\Users\asus\Desktop\cikti.txt", FileMode.Append);
            stryaz = new StreamWriter(dosyaAdi);

            int a = Convert.ToInt32(textBox4.Text);
            int b = Convert.ToInt32(textBox14.Text);
            int ebob = 1;
            int ekok;

            if (a < b)
            {

                for (int i = 2; i <= b; i++)
                {
                    if (a % i == 0 && b % i == 0)
                    {
                        ebob = i;
                    }
                }
            }
            else
            {
                for (int i = 2; i <= a; i++)
                {
                    if (a % i == 0 && b % i == 0)
                    {
                        ebob = i;
                    }
                }
            }
            ekok = (a * b) / ebob;
            textBox3.Text = Convert.ToString(ekok);
            stryaz.WriteLine("EKOK Bul : " + textBox4.Text + " " + textBox14.Text);
            stryaz.WriteLine("" + textBox3.Text);
            stryaz.Close();
            Console.ReadLine();
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }


        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            FileStream dosyaAdi;
            StreamWriter stryaz;
            dosyaAdi = new FileStream(@"C:\Users\asus\Desktop\cikti.txt", FileMode.Append);
            stryaz = new StreamWriter(dosyaAdi);

            int a = Convert.ToInt32(textBox6.Text);
            int i, b = 0;

            for (i = 1; i < a; i++)
            {
                if (a % i == 0)
                {
                    b = b + i;
                }
            }
            textBox5.Text = Convert.ToString(b);
            stryaz.WriteLine("Tum Carpanlarin Toplamini Bul : " + textBox6.Text);
            stryaz.WriteLine("" + textBox5.Text);
            stryaz.Close();
            Console.ReadLine();

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            FileStream dosyaAdi;
            StreamWriter stryaz;
            dosyaAdi = new FileStream(@"C:\Users\asus\Desktop\cikti.txt", FileMode.Append);
            stryaz = new StreamWriter(dosyaAdi);

            double a = Convert.ToInt32(textBox8.Text);
            double b = Convert.ToInt32(textBox11.Text);
            double j = 1, rj;
            double gecici=0;

            if (b < 0)
            {
                b = -1 * b;
                gecici = 1;
            }

            for (double i = 0; i < b; i++)
            {
                j = j * a;
            }

            if (gecici == 1)
            {
                rj = 1.0 / j;
                textBox7.Text = Convert.ToString(rj);
            }
            else
            {
                textBox7.Text = Convert.ToString(j);
            }
            stryaz.WriteLine("n'nin k. Kuvvetini Bul : " + textBox8.Text + " " + textBox11.Text);
            stryaz.WriteLine("" + textBox7.Text);
            stryaz.Close();
            Console.ReadLine();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            FileStream dosyaAdi;
            StreamWriter stryaz;
            dosyaAdi = new FileStream(@"C:\Users\asus\Desktop\cikti.txt", FileMode.Append);
            stryaz = new StreamWriter(dosyaAdi);

            double a = Convert.ToInt32(textBox10.Text);
            double b = Convert.ToInt32(textBox9.Text);
            double aci;

            aci = (a * 30) - (b * 5.5);
            if (aci < 0)
            {
                aci = (b * 5.5) - (a * 30);
            }
            if (aci > 180)
            {
                aci = 360 - aci;
            }
            textBox12.Text = Convert.ToString(aci);
            stryaz.WriteLine("Akreple Yelkovan Arasindaki Dar Aciyi Bul : " + textBox10.Text + " " + textBox9.Text);
            stryaz.WriteLine("" + textBox12.Text);
            stryaz.Close();
            Console.ReadLine();
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
