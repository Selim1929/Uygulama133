using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uygulama133
{
    public partial class Form1 : Form
    {
        class Ogrenciler
        {
            public int Numara { get; set; }
            public string AdSoyad { get; set; }
        }
        List<int> numaralarList = new List<int>();
        List<string> adsoyadList = new List<string>();
        List<Ogrenciler> ogrencilerList = new List<Ogrenciler>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkleSayı_Click(object sender, EventArgs e)
        {
            {
                numaralarList.Add(int.Parse(txtNumara.Text));
                IBSayı.Items.Clear();
                foreach (var item in numaralarList)
                {
                    IBSayı.Items.Add(item);
                }
                {
                    numaralarList.Add(int.Parse(txtNumara.Text));
                    IBSayı.Items.Clear();
                    foreach (var item in numaralarList)
                    {
                        IBSayı.Items.Add(item);
                    }
                }
            }
        }

        private void btnEkleMetin_Click(object sender, EventArgs e)
        {
            {
                Ogrenciler ogrenci = new Ogrenciler();
                ogrenci.Numara = int.Parse(txtNumaraN.Text);
                ogrenci.AdSoyad = txtAdSoyadN.Text;
                ogrencilerList.Add(ogrenci);
                IbMetin.Items.Clear();
                foreach (var item in ogrencilerList)
                {
                    IBSayı.Items.Add(item.Numara +" "+item.AdSoyad);
                }
            }

        }
    }
}
