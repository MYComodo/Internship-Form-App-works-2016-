using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA.List
{
    public partial class Form1 : Form
    {
        List<List<int>> list = new List<List<int>>();

        Listeler Savasci = new Listeler();
        List<string> hayvanlar = new List<string>();
        List<string> kediler = new List<string>();
        public Form1()
        {
            InitializeComponent();
            var list = new List<string>();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(Savasci.SkilEkle(textBox2.Text))
            {
                MessageBox.Show(textBox2.Text + " skili savaşcınıza eklenmiştir.");
            }


            #region KediEkleme
            /* kediler.Add(textBox1.Text);

             kediler.AddRange(hayvanlar);
             for(int i =0;i<kediler.Count;i++)
             {
                 MessageBox.Show(textBox1.Text + "isimli hayvan listeye eklenmiştir . " );

             }
             /*foreach(string prime in kediler)
             {
                 MessageBox.Show(prime);
             }*/

            /*for(int i=0; i<hayvanlar.Count;i++)
            {
                MessageBox.Show(hayvanlar[i]);
            }*/
            // listBox1.DataSource = hayvanlar;
            #endregion

        }

        private void button2_Click(object sender, EventArgs e)
        {
            kediler.Clear();
            kediler.Count();
            MessageBox.Show("Kediler Listesindeki tüm veriler temizlendi = "+kediler.Count.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //hayvanlar.TrimExcess();

            /* hayvanlar.Add("Kedi");
             hayvanlar.Add("Köpek");
             hayvanlar.Add("Aslan");
             hayvanlar.BinarySearch("Köpek");  */

            #region  Birleştirme       
            /*  kediler.Add("TEkir Kedi");
            hayvanlar.Add("Köpek ");
            var sonuc = kediler.Concat(hayvanlar);
            List<string> sonuclistesi = sonuc.ToList();

            foreach (string i in sonuclistesi)
            {
                MessageBox.Show(i);
            }
             */
                #endregion 

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(Savasci.SavasciEkle(textBox1.Text))
            {
                MessageBox.Show(textBox1.Text+" savaşcı olarak eklenmiştir.");

            }
        }
        
        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Savasci.BinarySearch(textBox3.Text).ToString());

        }

        private void button6_Click(object sender, EventArgs e)
        {
              
            Savasci.SavasciGoruntule();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Savasci.SkillGoruntule();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if(Savasci.SavasciCikar(textBox3.Text))
                MessageBox.Show(textBox3.Text+" isimli savaşçı silinmiştir!");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Savasci.SkillCikar(textBox4.Text);
        }
    }
}
