using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VucutKitleIndeksHesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static public string cinsiyet;
        private void btnHesapla_Click(object sender, EventArgs e)
        {
            /************************************************/
            double boy, kilo, vki;
            if (txbBoy.Text == "" && txbKilo.Text == "")
            {
                MessageBox.Show("Kutucukları boş bırakma!!");
            }
            else
            {


                boy = double.Parse(txbBoy.Text); //parse kullanma amacım null değere izin vermemesi.
                kilo = double.Parse(txbKilo.Text);
                boy = boy / 100;
                vki = kilo / (boy * boy);
                vki = Math.Round(vki); // Sayıyı yukarı yuvarladım
                lblVki.Text = vki.ToString();

                if (cinsiyet == "Erkek")
                {
                    if (vki < 18)
                    {
                        lbldurum.Text = "Zayıf";
                        lbldurum.ForeColor = System.Drawing.Color.Red;
                        lblVki.ForeColor = System.Drawing.Color.Red;
                    }
                    else if (vki >= 18 && vki < 25)
                    {
                        lbldurum.Text = "Normal";
                        lbldurum.ForeColor = System.Drawing.Color.Green;
                        lblVki.ForeColor = System.Drawing.Color.Green;
                    }
                    else if (vki >= 25 && vki < 30)
                    {
                        lbldurum.Text = "Kilolu";
                        lbldurum.ForeColor = System.Drawing.Color.Red;
                        lblVki.ForeColor = System.Drawing.Color.Red;
                    }
                    else if (vki >= 30 && vki < 35)
                    {
                        lbldurum.Text = "Obez";
                        lbldurum.ForeColor = System.Drawing.Color.DarkRed;
                        lblVki.ForeColor = System.Drawing.Color.DarkRed;
                    }
                    else
                    {
                        lbldurum.Text = "Ciddi Obez";
                        lbldurum.ForeColor = System.Drawing.Color.DarkRed;
                        lblVki.ForeColor = System.Drawing.Color.DarkRed;
                    }
                }
                else if (cinsiyet == "Kadın")
                {
                    if (vki < 18)
                    {
                        lbldurum.Text = "Zayıf";
                        lbldurum.ForeColor = System.Drawing.Color.Red;
                        lblVki.ForeColor = System.Drawing.Color.Red;
                    }
                    else if (vki >= 18 && vki < 25)
                    {
                        lbldurum.Text = "Normal";
                        lbldurum.ForeColor = System.Drawing.Color.Green;
                        lblVki.ForeColor = System.Drawing.Color.Green;
                    }
                    else if (vki >= 25 && vki < 30)
                    {
                        lbldurum.Text = "Kilolu";
                        lbldurum.ForeColor = System.Drawing.Color.Red;
                        lblVki.ForeColor = System.Drawing.Color.Red;
                    }
                    else if (vki >= 30 && vki < 35)
                    {
                        lbldurum.Text = "Obez";
                        lbldurum.ForeColor = System.Drawing.Color.DarkRed;
                        lblVki.ForeColor = System.Drawing.Color.DarkRed;
                    }
                    else
                    {
                        lbldurum.Text = "Ciddi Obez";
                        lbldurum.ForeColor = System.Drawing.Color.DarkRed;
                        lblVki.ForeColor = System.Drawing.Color.DarkRed;
                    }
                }
            }
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("VKİ 17'nin altındaysa ZAYIF," +
                "VKİ 18 ile 25 aralığındaysa NORMAL, " +
                "VKİ 26 ile 30 aralığındaysa KİLOLU, " +
                "VKİ 31 ile 35 arasındaysa OBEZ, " +
                "VKİ 36'nın üzerindeyse CİDDİ OBEZ olarak kabul edilir.");
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            CinsiyetSecimEkrani cinsiyetSecimEkrani = new CinsiyetSecimEkrani();
            cinsiyetSecimEkrani.Show();
            this.Close();
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txbBoy.Clear(); //Temizle komutundan sonra TextBox içerisini temizler.
            txbKilo.Clear(); //Temizle komutundan sonra TextBox içerisini temizler.
            lbldurum.Text = "bekleniyor...";
            lblVki.Text = "NaN";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //Cinsiyet durumuna göre Erkek veya Kadın cinsiye sembolu getirecek kod
            if (cinsiyet == "Erkek")
            {
                pictureBoxiconman.Visible = true;
                pictureBoxiconwoman.Visible = false;
            }
            else if (cinsiyet == "Kadın")
            {
                pictureBoxiconwoman.Visible = true;
                pictureBoxiconman.Visible = false;
            }
        }
    }
}
