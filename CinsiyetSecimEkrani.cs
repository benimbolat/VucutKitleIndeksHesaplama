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
    public partial class CinsiyetSecimEkrani : Form
    {
        private void CinsiyetSecimEkrani_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bu program Muhammed Enes Bolat tarafından kodlandı. Devam etmek için 'Tamam' deyiniz.");
        }
        public CinsiyetSecimEkrani()
        {
            InitializeComponent();
        }

        Form1 fr1 = new Form1(); // Form1'i getiren komut.

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public void pcbxMan_Click(object sender, EventArgs e)
        {
            radioButtonMan.Checked = true;
            radioButtonWoman.Checked = false;
            Form1.cinsiyet = "Erkek";
            fr1.Show();
            this.Hide();
        }
        public void pcbxWoman_Click(object sender, EventArgs e)
        {
            radioButtonMan.Checked = false;
            radioButtonWoman.Checked = true;
            Form1.cinsiyet = "Kadın";
            fr1.Show();
            this.Hide();
        }
    }
}
