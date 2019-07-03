using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA.Tank
{
    public partial class Form1 : Form
    {
        List<Tank> tanklar = new List<Tank>();
        List<Tank> tank2 = new List<Tank>();
        
        public Form1()
        {
            InitializeComponent();
            //1
            Tank leopard = new Tank("Leopard");
            leopard.ModelYili = new DateTime(1979, 1, 1);
            leopard.Uzunluk = 9.97m;
            leopard.Zirhi = "Seramik Bileşik";
            leopard.AzamiHiz = 72;
            leopard.AnaSilahi = new Silah
            {
                SilahAdi = "L44 Yivsiz Top",
                Caliber = 120
            }; 
            tanklar.Add(leopard);

            //2
            Tank leclerc = new Tank("Leclerc");
            leclerc.ModelYili = new DateTime(1990, 1, 1);
            leclerc.Uzunluk = 9.87m;
            leclerc.Zirhi = "Titanyum";
            leclerc.AzamiHiz = 72;
            leclerc.AnaSilahi = new Silah
            {
                SilahAdi = "Tank Topu",
                Caliber = 120
            };
            tanklar.Add(leclerc);

            //3
            Tank kurassier = new Tank("Kürassier");
            kurassier.ModelYili = new DateTime(1967, 1, 1);
            kurassier.Uzunluk = 5.58m;
            kurassier.Zirhi = "Çelik";
            kurassier.AzamiHiz = 70;
            kurassier.AnaSilahi = new Silah
            {
                SilahAdi = "Yivli Top",
                Caliber = 105
            };
            tanklar.Add(kurassier);

            //4
            Tank osorio = new Tank("Osorio");
            osorio.ModelYili = new DateTime(1982, 1, 1);
            osorio.Uzunluk = 9.99m;
            osorio.Zirhi = "Kompozit Alüminyum";
            osorio.AzamiHiz = 70;
            osorio.AnaSilahi = new Silah
            {
                SilahAdi = "Yivsiz Top",
                Caliber = 120
            };
            tanklar.Add(osorio);

            //5
            Tank degman = new Tank("M-95 Degman");
            degman.ModelYili = new DateTime(1991, 1, 1);
            degman.Uzunluk = 10.1m;
            degman.Zirhi = "Reaktif Zırh";
            degman.AzamiHiz = 72;
            degman.AnaSilahi = new Silah
            {
                SilahAdi = "Yivsiz",
                Caliber = 125
            };
            tanklar.Add(degman);
            
            
            //6
            Tank altay = new Tank("Altay");
            altay.ModelYili = new DateTime(2008, 1, 1);
            altay.Uzunluk = 7.3m;
            altay.Zirhi = "Bor Karbür Zırh";
            altay.AzamiHiz = 70;
            altay.AnaSilahi = new Silah
            {
                SilahAdi = "Yivsiz Top",
                Caliber = 120
            };
            tanklar.Add(altay);


            //7
            Tank arjun = new Tank("Arjun");
            arjun.ModelYili = new DateTime(2004, 1, 1);
            arjun.Uzunluk = 10.6m;
            arjun.Zirhi = "Kompozit Zırh";
            arjun.AzamiHiz = 60;
            arjun.AnaSilahi = new Silah
            {
                SilahAdi = "LAHAT ATGM",
                Caliber = 120
            };
            tanklar.Add(arjun);

            //8
            Tank zulfikar = new Tank("Zulfikar");
            zulfikar.ModelYili = new DateTime(1993,1,1);
            zulfikar.Uzunluk = 9.20m;
            zulfikar.Zirhi = "Kompozit Zırh";
            zulfikar.AzamiHiz = 70;
            zulfikar.AnaSilahi = new Silah
            {
                SilahAdi = "Yivsiz Top",
                Caliber = 125
            };
            tanklar.Add(zulfikar);
            
            
            //9
            Tank blackpanter = new Tank("K2 Black Panther");
            blackpanter.ModelYili = new DateTime(2013,1,1);
            blackpanter.Uzunluk = 10.8m;
            blackpanter.Zirhi = "Kompozit Zırh";
            blackpanter.AzamiHiz = 70;
            blackpanter.AnaSilahi = new Silah
            {
                SilahAdi = "Yivsiz Top",
                Caliber = 120
            };
            tanklar.Add(blackpanter);

            
            //10
            Tank sabra = new Tank("Sabra");
            sabra.ModelYili = new DateTime(2007, 1, 1);
            sabra.Uzunluk = 6.95m;
            sabra.Zirhi = "Çelik Kaplama";
            sabra.AzamiHiz = 48;
            sabra.AnaSilahi = new Silah
            {
                SilahAdi = "IMI Tank Topu",
                Caliber = 120
            };
            tanklar.Add(sabra);




        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
                         
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int tanksayi = tanklar.Count;
            MessageBox.Show(tanksayi + " kadar tank mevcuttur.");


        }

        private void button2_Click(object sender, EventArgs e)
        {
            string ara = textBox1.Text;

            #region For Döngüsü İle
            /* for (int i = 0; i < tanklar.Count; i++)
            {
                if (ara == tanklar[i].TankAdi)
                {
                    MessageBox.Show(string.Format("Tankın Adı :      {0}\n  Modeli :      {1}\n  Uzunluğu :      {2}\n  Zırhı :      {3}\n  Ana Silahı :      {4}\nSilahın Kalibresi : {6}\n  Azami Hızı :      {5}", tanklar[i].TankAdi, tanklar[i].ModelYili.Year, tanklar[i].Uzunluk.ToString(), tanklar[i].Zirhi, tanklar[i].AnaSilahi.SilahAdi, tanklar[i].AzamiHiz.ToString(), tanklar[i].AnaSilahi.Caliber.ToString()));
                }
                */

            #endregion

            int sayac = tanklar.Count;
            foreach (var item in tanklar)
            {
                #region MessageBox ile
                /* MessageBox.Show(string.Format("TANKIN \nAdı :               {0}\nModeli :      {1}\nUzunluğu :      {2} metre \nZırhı :             {3}\nAna Silahı :        {4}\nSilahın Kalibresi : {6} mm \nAzami Hızı :         {5} km/saat", item.TankAdi, item.ModelYili.Year, item.Uzunluk.ToString(), item.Zirhi, item.AnaSilahi.SilahAdi, item.AzamiHiz.ToString(), item.AnaSilahi.Caliber.ToString()));*/
                #endregion
                
                sayac -= 1;
                
                if (ara == item.TankAdi)
                {
                    tank2.Add(item);
                    break;
                }
                
                if(ara != item.TankAdi && sayac ==0)
                {
                    tank2.AddRange(tanklar);
                    MessageBox.Show("Aradığınız tank listede bulunmamaktadır ! ");
                }
                

            }
            
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = tank2;
           
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            int sayac = tanklar.Count;
            string ara = textBox1.Text;
            foreach(var item in tanklar)
            {
                
                    sayac -= 1;

                    if (ara ==item.TankAdi)
                    {
                    tanklar.Remove(item);
                    MessageBox.Show(item.TankAdi + " tankı listeden silinmiştir");

                        break;
                    }

                    if (ara != item.TankAdi && sayac == 0)
                    {
                        
                        MessageBox.Show("Aradığınız tank listede bulunmamaktadır ! ");
                    }



                

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int sayac = tanklar.Count;
            string ara = textBox2.Text;
            foreach(var item in tanklar)
            {
                sayac -= 1;
                if(ara==item.TankAdi)
                {
                    string eskisilah = item.AnaSilahi.SilahAdi;
                    item.AnaSilahi.SilahAdi = textBox3.Text;
                    MessageBox.Show(item.TankAdi + " tankının " +eskisilah+ " adlı silahı " + item.AnaSilahi.SilahAdi + " silahı olarak güncellenmiştir");

                    break;
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = tanklar;
        }
    }
}
