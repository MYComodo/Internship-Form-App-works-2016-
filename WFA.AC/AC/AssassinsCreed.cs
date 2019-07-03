using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AC
{
    class AssassinsCreed
    {
        public string as_adi;
        public double as_boy;
        public int as_yas;
        public int as_kilo;
        public int as_can;
        public int as_silah_hasari;
        public string as_silah;
        public int dusman_cani;

        public void SilahGucleri()
        {
            MessageBox.Show("Kılıç = 300\nBıçak = 150\nYay=400");
        }
        public int SilahHasari(int silah_hasari)
        {
            if (as_silah == "Kılıç")
                silah_hasari = 300;
            if (as_silah == "Bıçak")
                silah_hasari = 150;
            if (as_silah == "Yay")
                silah_hasari = 400;

            return silah_hasari;
        }

        public void SaldiriRaporu()
        {
            MessageBox.Show(string.Format("Düşmana {0}  ile {1} kadar hasar verilmiştir . ",as_silah,as_silah_hasari));
        }

        public int DusmanYasam(int dusman_cani)
        {
            if(dusman_cani<=0)
            {
                MessageBox.Show("Düşman öldürüldü. ");
                dusman_cani = 0;
               return dusman_cani;
            }
            else
            {
                MessageBox.Show("Düşman hala hayatta !! ");
                return dusman_cani;
            }

        }
        public int YasamKontrol(int can)
        {
            if (can <= 0)
            {
                MessageBox.Show(string.Format("{0} saldırıda başarısız olmuş ve vefat etmiştir .. ", as_adi));
                return as_can = 0;
            }
            else
            {
                MessageBox.Show(string.Format("{0} saldırıyı başarılı bir şekilde gerçekleştirmiştir..", as_adi));
                return as_can = can;
            }
        }
        public int HasarVer(string silah)
        {
            as_silah = silah;
            as_silah_hasari = SilahHasari(as_silah_hasari);


            dusman_cani -= as_silah_hasari;
            as_can -= 50;
            return as_can;
        }
        public void Iyilestir()
        {
            as_can = 500;
            MessageBox.Show(string.Format("{0} tedavi edildi ..", as_adi));
            

        }
        public AssassinsCreed(string adi ,double boy,int yas,int kilo)
        {
            as_adi = adi;
            as_boy = boy;
            as_yas = yas;
            as_kilo = kilo;
           

            MessageBox.Show(string.Format("Seçilen Assassin adı {0} , boyu {1} , yaşı {2} , kilosu {3} dur.", adi, boy,yas,kilo));

        }
        public  void Atack(double enlem, double boylam,int can,string silah)
        {

            MessageBox.Show(string.Format(" {0} ve {1} noktasına  saldırıyı başlattı .",enlem,boylam));
            HasarVer(silah);
            DusmanYasam(dusman_cani);
            YasamKontrol(as_can);
            

        }
        

    }
}
