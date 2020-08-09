using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace To_Do_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Görev_Ekle_btn_Click(object sender, EventArgs e)
        {
            if (Görev_Text.Text.Length > 0)
            {
                Yapılacaklar_List.Items.Add(Görev_Text.Text);
            }
        }

        private void Görev_Sil_btn_Click(object sender, EventArgs e)
        {
            int secim_Yapilacaklar = Yapılacaklar_List.SelectedIndex;
            int secim_Yapilanlar = Yapılanlar_List.SelectedIndex;
            if (secim_Yapilacaklar >= 0)
            {

                Yapılacaklar_List.Items.RemoveAt(secim_Yapilacaklar);
            }
            else if (secim_Yapilanlar >= 0)

            {

                Yapılanlar_List.Items.RemoveAt(secim_Yapilanlar);

            }
          
    }

        private void Güncelle_Btn_Click(object sender, EventArgs e)
        {
            double tamamlanan,yüzde1,toplam,durum;

            toplam = Convert.ToDouble(Yapılanlar_List.Items.Count) + Convert.ToDouble(Yapılacaklar_List.Items.Count);

            yüzde1 = 100 / toplam;

            tamamlanan = Yapılanlar_List.Items.Count * yüzde1;

            tamamlanan = Convert.ToInt32(tamamlanan);

            Durum_label.Text="Görevlerinizin"+" "+"%"+tamamlanan.ToString()+" "+"değerini tamamladınız.";

            foreach (string Item in Yapılacaklar_List.CheckedItems.OfType<string>().ToList())
            {
                Yapılanlar_List.Items.Add(Item);
                Yapılacaklar_List.Items.Remove(Item);
            }
                
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Yapılacaklar_List.BackColor = Color.Yellow;
            Yapılanlar_List.BackColor = Color.Green;
        }
    }
}
