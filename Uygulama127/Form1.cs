using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uygulama127
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] isimler = new string[5];
        int[] notlar = new int[5];
        int index = 0;
        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (index < isimler.Length)
            {
                isimler[index] = txtAdSoyad.Text;
                notlar[index] = int.Parse(txtDersNotu.Text);
                
                index++;
                txtAdSoyad.Text = "";
                txtDersNotu.Text = "";
            }
        }
        private void btnEnYuksek_Click(object sender, EventArgs e)
        {
            int enyuksek = notlar[0];
            for (int i = 0; i < enyuksek; i++)
            {
                if (notlar[i] > enyuksek)
                {
                    enyuksek = notlar[i];
                }
            }
            txtEnyuksek.Text = enyuksek.ToString();
        }

        private void btnEnDusuk_Click(object sender, EventArgs e)
        {
            int enduduk = notlar[0];
            for(int i = 0;i < enduduk; i++)
            {
                if (notlar[i] < enduduk) 
                    enduduk = notlar[i];
            }
            txtEnDuşuk.Text = enduduk.ToString();
        }

        private void btnOrtalama_Click(object sender, EventArgs e)
        {
            int toplam = 0;
            double ortalama = 0;
            for(int i = 0; i < notlar.Length; i++)
            {
                toplam = notlar[i];
            }
            ortalama=toplam /notlar.Length;
            txtOrtalama.Text = toplam.ToString();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < isimler.Length; i++)
            {
                if (isimler[i] != null)
                    lbListe.Items.Add(isimler[i] + " > " + notlar[i]);
            }
        }
    }
}
