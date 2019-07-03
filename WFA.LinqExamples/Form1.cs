using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA.LinqExamples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        List<Games> OyunGetir()
        {
            List<Games> oyunlar = new List<Games>() {

            new Games
            {
                GameId = 1,
                GameName = "Assassins Creed",
                Difficulty = "Medium"
            },
            new Games
            {
                
                GameId = 2,
                GameName = "Call of Duty",
                Difficulty = "Hard"

            },

            new Games
            {
                
                GameId = 3,
                GameName = "Crusade Kings",
                Difficulty = "Insanity"
            }


            };


            return oyunlar;
        }

        List<Player> OyuncuGetir()
        {
            List<Player> oyuncular = new List<Player>()
            {
                new Player
                {
                
                    PlayerId =1,
                    NickName = "Crusade Kings",
                    Point = 90,
                    Email="a@a.a",
                    Password = "1abds2",



                },

                new Player
                {
                    PlayerId =2,
                    NickName = "Osmanlı95",
                    Point = 80,
                    Email="z@z.z",
                    Password = "3fdas3"

                },
                new Player
                {
                  
                    PlayerId =3,
                    NickName = "Muhammed",
                    Point = 100,
                    Email="m@m.m",
                    Password = "65fdhSD432dadDF43++"

                },
                new Player
                {
                    
                    PlayerId =4,
                    NickName = "İhsan00",
                    Email="t@t.t",
                    Password = "0000000",
                   
                    

                },
                new Player
                {
                   
                    PlayerId =5,
                    NickName = "TemooThePoison",
                    Point = 94,
                    Email="s@s.s",
                    Password = "987654321"

                },
                new Player
                {
                    
                    PlayerId =6,
                    NickName = "Stajer",
                    Point = 78,
                    Email="u@u.u",
                    Password = "122334444555555"

                },
                new Player
                {
                    PlayerId =7,
                    NickName = "Risquer",
                    Password = "jhgufdd"

                }

            };

            return oyuncular;
        }


        //List<Members> AbonelikGetir()
        //{
        //    List<Members> abonelikler = new List<Members>();
        //    new Members
        //    {
        //        MemberId=1,
        //        OyuncuId =

        //    };

        //    return abonelikler;
        //}

        /* void OyunGoster()
         {
             Grid1.DataSource = OyunGetir().ToList();
         }*/


        // Take Kullanım


        void Top5()
        {
            Grid1.DataSource = null;
            Grid1.DataSource = OyuncuGetir().Take(5).OrderByDescending(o=> o.Point).ThenBy(o=>o.PlayerId).ThenBy(o=> o.NickName).Select(o => new {Oyuncu_İsmi=o.NickName,Top_5 = o.Point }).ToList();

        }

        
        //SelectMany Kullanım
        void OyuncuOyun()
        {
           
            var oyuncular = OyuncuGetir();
            var oyunlar = OyunGetir();

            /*var PvG = oyuncular.GroupJoin(oyunlar,
                p=> p.NickName,o=> o.GameName,(c,result)=> new  {OyuncuAdı=c.NickName,Sayısı = result}).ToList();

            foreach (var item in PvG)
            {
                foreach (var item2 in item.Sayısı)
                {
                    var x = item2;
                }
            }


            int a = 5;
            a = a * 5;*/
            
            var PvG = oyuncular.SelectMany(p => oyunlar.Where(g => g.GameId == p.PlayerId), (p, g) => new
            {
                OyuncuKaydı = p.PlayerId,
                OyuncuAdı = p.NickName,
                OyunAdı = g.GameName,
                Puan = p.Point
            });
            Grid1.DataSource = null;
            Grid1.DataSource = PvG.ToList();   

        /* Grid1.DataSource = null;
            Grid1.DataSource =
                OyuncuGetir().SelectMany(O => OyunGetir(),
                (o, g) => new { Oyuncu_İsmi = o.NickName, Oyun_İsmi = g.GameName }).ToList();
        */
        }

        //Select Kullanım
        void SifreGetir()
        {
             Grid1.DataSource = null;
             Grid1.DataSource =
                   OyuncuGetir().Select(İsim => new { Sifre = İsim.Password }).ToList();
           
         
        }
        // Select ile Aritmetik İşlemler 
        void PuanAzalt()
        {
            Grid1.DataSource = null;
            Grid1.DataSource = OyuncuGetir().Select(o => new {
            Azaltılmış_Puan=o.Point-10}).ToList();
        }

        //Select Kullanımı

        void OyuncuGoruntule()

        {
            Grid1.DataSource = null;
            Grid1.DataSource =
                OyuncuGetir().Select(oyuncu=> new { Oyuncu_İsmi = oyuncu.NickName, Oyuncu_Puanı=oyuncu.Point,
                                                    Oyuncu_Email = oyuncu.Email,Oyuncu_Şifresi = oyuncu.Password}).ToList();
            
            


        }

        void ReverseList()
        {
            Grid1.DataSource = null;
            Grid1.DataSource = OyuncuGetir().OrderBy(o=> o.PlayerId).Reverse().ToList();
        }
       void AbonelikGoster()
        {
            Grid1.DataSource = null;
           // Grid1.DataSource = AbonelikGetir().ToList();
        }

        //Where ,  Select Birlikte Kullanım
        void EmailBos()
        {
            Grid1.DataSource = null;
            Grid1.DataSource =
                OyuncuGetir().Where(o => o.Email == null).Select(o=> /**/new { Emaili_Boş_Olanlar =/**/ o.NickName }).ToList();
                

        }

        void MinPuan()
        {
            MessageBox.Show(OyuncuGetir().Select(o =>
            new { ToplamPuan = o.Point }).Min(o => o.ToplamPuan).ToString(), "En Düşük Puan :");
        }

        void MaxPuan()
        {
            MessageBox.Show(OyuncuGetir().Select(o => 
            new { ToplamPuan = o.Point }).Max(o => o.ToplamPuan).ToString(), "En Yüksek Puan :");
        }

        void OrtalamaPuan()
        {
            MessageBox.Show(OyuncuGetir().Select(o => 
            new { ToplamPuan = Math.Round(o.Point, 2) }).Average(o => Math.Round(o.ToplamPuan,2)).ToString(), "Toplam Puanlar");
        }

        void ToplamPuan()
        {
            MessageBox.Show(OyuncuGetir().Select(o => new { ToplamPuan = o.Point }).Sum(o => o.ToplamPuan).ToString(),"Toplam Puanlar");
        }


        void GroupBy()
        {
            Grid1.DataSource = null;
            Grid1.DataSource = OyuncuGetir().OrderBy(o => o.PlayerId).GroupBy(o => o.Point).Select(point => new { Puanlar = point.Key, OyuncuSayısı = point.Count() }).ToList();
        }
        //Where Kullanım
        void Basarili(decimal point)
        {
            Grid1.DataSource = null;
            Grid1.DataSource =
                OyuncuGetir().Where(p => p.Point >= point).Select(p=> 
                new 
                { OyuncuNO=p.PlayerId,Oyuncuİsmi=p.NickName,OyuncuPuanı=p.Point  }).ToList();
        }
        void LastReg()
        {
            Grid1.DataSource = null;
            Grid1.DataSource = OyuncuGetir().Skip(OyuncuGetir().Count() - 1).ToList(); 

        }

        /// Where Kullanım
        void HarfeGore(string nickName)
        {
            Grid1.DataSource = null;
            Grid1.DataSource = 
                    OyuncuGetir().Where(n=>n.NickName.ToLower().Contains(nickName.ToLower())).ToList();
        }


        private void button1_Click(object sender, EventArgs e)
        {
          
            HarfeGore(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OyuncuGoruntule();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
           
            decimal sayi = Convert.ToDecimal(textBox2.Text);
            
            Basarili(sayi);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            EmailBos();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SifreGetir();
        }

       /* private void button6_Click(object sender, EventArgs e)
        {
            
            
        }*/

        private void button6_Click_1(object sender, EventArgs e)
        {
             OyuncuOyun();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Top5();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AbonelikGoster();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            PuanAzalt();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            LastReg();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            ReverseList();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            GroupBy();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            ToplamPuan();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            MinPuan();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            MaxPuan();
        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            OrtalamaPuan();
        }
    }
}
