using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace ATP10A_2012
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        ArrayList sehirler = new ArrayList();      
        
        
        private void btnsehir_Click(object sender, EventArgs e)
        {
            try
            {
               
                if (txtsehirgiris.Text == "")
                {
                    MessageBox.Show("Burası Boş Bırakılamaz");
                    
                }
                else
                    sehirler.Add(txtsehirgiris.Text);
                txtsehirgiris.Clear();
                txtsehirgiris.Focus();
                
            }
            catch (Exception)
            {
                MessageBox.Show("Bilinmedik Bir Hata Oluştu");
                
            }
            txtsehirgiris.Clear();
            txtsehirgiris.Focus();
        }              
        private void btnyazdir_Click(object sender, EventArgs e)
        {
            lstbyazdir.Items.Clear();
            int sayac = -1;
            //for (int i = 0; i <sehirler.Count; i++)
            //{
            //    lstbyazdir.Items.Add(sehirler[i]);                                         
            //}

            foreach (string sehir in sehirler)
            {
                sayac++;
                lstbyazdir.Items.Add( "[" + sayac + "] " + "Elemanlı Şehir " +sehir);                               
            }                     
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int arayaekle = lstbyazdir.SelectedIndex;
            int sayac = -1;
            lstbyazdir.Items.Clear();
            sehirler.Insert(arayaekle, txtarayaekle.Text);
            for (int i = 0; i <sehirler.Count; i++)
            {
                sayac++;
                lstbyazdir.Items.Add("[" + sayac + "]" + "Elemanlı Şehir " + sehirler[i]);
                
            }
            txtarayaekle.Clear();      
        }
               
        private void btnguncelle_Click(object sender, EventArgs e)
        {
            string guncelle = Convert.ToString(txtbguncelle.Text);
            for (int i = 0; i < sehirler.Count; i++)
            {

            }
        }

        

        private void btnsecilen_Click_2(object sender, EventArgs e)
        {
            int secim = lstbyazdir.SelectedIndex;
            if (secim != -1)
            {

                lstbyazdir.Items.RemoveAt(secim);
            }
            else
            {
                MessageBox.Show("Seçim Yapın!");
            }

        }

        private void btnguncelle_Click_1(object sender, EventArgs e)
        {
            int guncelle = lstbyazdir.SelectedIndex;
            
            sehirler[guncelle] = txtbguncelle.Text;
            int sayac = -1;
            lstbyazdir.Items.Clear();
            foreach (string sehir in sehirler)
            {
                sayac++;
                lstbyazdir.Items.Add("[" + sayac + "] " + "Elemanlı Şehir " + sehir);
            }
            txtbguncelle.Clear();
            
        }

        private void btnara_Click_1(object sender, EventArgs e)
        {
            int durum = sehirler.IndexOf(txtvarmi.Text);
            if (durum != -1)

                MessageBox.Show("[" + durum + "]" + " İndex Numaralı Aranan Veri Bulundu ");
            else
                MessageBox.Show("Veri Bulunamadı");
            txtvarmi.Clear();
        }
      
    }
}
