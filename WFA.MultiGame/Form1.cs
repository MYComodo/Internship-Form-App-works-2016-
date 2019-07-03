using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA.MultiGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        List<Players> GetPlayer()
        {
            List<Players> oyuncular = new List<Players>() {
            new Players
            {
                PlayersId = 1,
                NickName = "Temucinkhaan",
                Email = "t@t.t",
                Password = "1324sdtg",
            },
            new Players
            {
                PlayersId = 2,
                NickName = "Ottoman95",
                Email = "o@o.o",
                Password = "098ndsfs",

            },

            new Players
            {
                PlayersId = 3,
                NickName = "Nuclear",
                Email="n@n.n",
                Password = "juhg341",
            },
            new Players
            {
                PlayersId = 4,
                NickName = "charlus",
                Email = "c@c.c",
                Password = "hugs7632",
            },
            new Players
            {
                PlayersId = 5,
                NickName = "Elrond",
                Email = "e@e.e",
                Password = "elf3000",
            },
            new Players
            {
                PlayersId = 6,
                NickName = "salloma",
                Email = "s@s.s",
                Password = "salla9873",
            },
            new Players
            {
                PlayersId = 7,
                NickName = "Temoo",
                Email = "t@t.t",
                Password = "zehirlitemoo",
            },
            new Players
            {
                PlayersId = 8,
                NickName = "lord-nikon",
                Email = "lord@l.l",
                Password = "hacker2001",
            },
            new Players
            {
                PlayersId = 9,
                NickName = "SamBowanga",
                Email = "SB@sb.sb",
                Password = "5457gkjge",
            },
            new Players
            {
                PlayersId = 10,
                NickName = "Nazgol",
                Email = "gol@g.g",
                Password = "MasterSauron",
            },
            new Players
            {
                PlayersId = 11,
                NickName = "Enes",
                Email = "E@e.e",
                Password = "1324sdtg",
            }
            };


            return oyuncular;
        }


        List<Games> GetGame()
        {
            List<Games> oyunlar = new List<Games>()
            {
                 new Games

                 {

                     GameId = 1,

                     GameName = "Crusader Kings",

                     Difficulty = "Medium"

                 },

                new Games

                {

                    GameId = 2,

                    GameName = "Red Alert",

                    Difficulty = "Easy"

                },

                new Games

                {

                    GameId = 3,

                    GameName = "League of Legends",

                    Difficulty = "Hard"

                },

                new Games

                {

                    GameId = 5,

                    GameName = "PES13",

                    Difficulty = "Easy"

                },


                new Games
                
                {

                    GameId = 4,

                    GameName = "BattleBorn",

                    Difficulty = "Insanity"

                }
            };
           



            return oyunlar;
        }
        

        List<PlayerGames> GetPlaying()
        {
           
            var oyuncu = GetPlayer();
            var oyun = GetGame();


            List<PlayerGames> oynayanlar = new List<PlayerGames>() {

                new PlayerGames
                {
                    BeginDate = new DateTime(2015, 3, 4),
                    GameId = 1,
                    PlayerId = 10,
                    Point = 321

                },
                 new PlayerGames
                 {
                     BeginDate = new DateTime(2010, 4, 2),
                     GameId = 4,
                     PlayerId = 6,
                     Point = 452

                 },
                /* new PlayerGames
                 {
                     BeginDate = new DateTime(2011, 12, 2),
                     GameId = 5,
                     PlayerId = 11,
                     Point = 1

                 },*/
                  new PlayerGames
                 {
                     BeginDate = new DateTime(2013, 1, 28),
                     GameId = 3,
                     PlayerId = 1,
                     Point = 203

                 },
                   new PlayerGames
                 {
                     BeginDate = new DateTime(2009, 9, 17),
                     GameId = 2,
                     PlayerId = 6,
                     Point =298

                 },
                    new PlayerGames
                 {
                     BeginDate = new DateTime(2000, 12, 16),
                     GameId = 1,
                     PlayerId = 4,
                     Point = 472

                 }

                 };

            
            
            return oynayanlar;
        }


        void Oyuncular()
        {
            Grid1.DataSource = null;
            Grid1.DataSource = GetPlayer().Select(p =>
            new
            {
                OyuncuNo = p.PlayersId,
                Oyuncuİsmi = p.NickName,
                OyuncuEmail = p.Email,
                OyuncuŞifresi  = p.Password,

            } ).ToList();
        }


        void Oyunlar()
        {
            Grid1.DataSource = null;
            Grid1.DataSource = GetGame().Select(g =>
            new
            {
                OyunNo = g.GameId,
                Oyunİsmi = g.GameName,
                OyunZorluğu = g.Difficulty

            }).OrderBy(g=> g.OyunNo).ToList();

            Grid1.Columns[0].HeaderText = "Oyun No";
            Grid1.Columns[1].HeaderText = "Oyun İsmi";
            Grid1.Columns[2].HeaderText = "Oyun Zorluğu";


        }



        void Oynayanlar()
        {
            var plist = GetPlaying();
            var players = GetPlayer();
            var games = GetGame();

            Grid1.DataSource = null;
            Grid1.DataSource = plist.Join
                (players, pl => pl.PlayerId
                        , p => p.PlayersId
                        ,(pl, p) => 
                        new
                        {
                            
                            OyunaBaşlangıçTarihi = pl.BeginDate,
                            Oyuncuİsmi = p.NickName,
                            OyunNo= pl.GameId,
                            OyuncuNo=p.PlayersId,
                            OyunPuanı = pl.Point
                           
                        }
                ).Join
                (games,p=> p.OyunNo
                      , g=> g.GameId 
                      , (p,g) => 
                      new
                      {
                          BaşlangıçTarihi=p.OyunaBaşlangıçTarihi,
                          OyuncuNo= p.OyuncuNo,
                          Oyuncuİsmi=p.Oyuncuİsmi,
                          Oyunİsmi = g.GameName,
                          OyunZorluğu = g.Difficulty,
                          OyunPuanı = p.OyunPuanı
                          
                          
                      }
                      ).OrderBy(s=> s.OyuncuNo).ToList();


            Grid1.Columns[0].HeaderText = " Başlangıç Tarihi ";
            Grid1.Columns[1].HeaderText = " Oyuncu No ";
            Grid1.Columns[2].HeaderText = " Oyuncu İsmi ";
            Grid1.Columns[3].HeaderText = " Oyun İsmi ";
            Grid1.Columns[4].HeaderText = " Oyun Zorluğu ";
            Grid1.Columns[5].HeaderText = " Oyun Puanı ";



        }

        /*void ConCat()
        {
            var plist = GetPlayer();
            var glist = GetPlayer();
            Grid1.DataSource = null;
            Grid1.DataSource = plist.Concat(glist).ToList();
        }*/


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        void Top5()
        {
            Grid1.DataSource = null;
            Grid1.DataSource = GetPlaying()
                                    .Join(GetPlayer(),pl=> pl.PlayerId
                                                     ,p => p.PlayersId
                                                     ,(pl,p)=>
                                                        new
                                                        {
                                                            pl.PlayerId,
                                                            pl.GameId,
                                                            p.NickName,
                                                            OyuncuPuanı = pl.Point
                                                            

                                                        }
                                                     )
                                     .Join(GetGame(), pl => pl.GameId
                                                    , g  => g.GameId
                                                    ,(pl,g) => 
                                                        new
                                                        {
                                                            pl.OyuncuPuanı,
                                                            pl.PlayerId,
                                                            pl.NickName,
                                                            g.GameName,
                                                            g.Difficulty
                                                        }
                                                     
                                                     ).OrderByDescending(o=>o.OyuncuPuanı).Take(5).ToList();

            Grid1.Columns[0].HeaderText = "Oyuncu Puanı";
            Grid1.Columns[1].HeaderText = "Oyuncu No";
            Grid1.Columns[2].HeaderText = "Oyuncu İsmi";
            Grid1.Columns[3].HeaderText = "Oyun Adı";
            Grid1.Columns[4].HeaderText = "Oyun Zorluğu";


        }

        void EnKotu()
        {
            Grid1.DataSource = null;
            Grid1.DataSource = GetPlaying()
                .Join(GetPlayer()
                , pl => pl.PlayerId
                , p => p.PlayersId
                , (pl,p)=>
                 new
                 {
                     pl.PlayerId,
                     pl.BeginDate,
                     p.NickName,
                     pl.Point,
                     pl.GameId,
                     
                     

                 }
                ).Join(GetGame()
                , pl=> pl.GameId
                , g => g.GameId
                ,(pl,g) => 
                new
                {
                    OyuncuNo=pl.PlayerId,
                    Oyuncuİsmi = pl.NickName,
                    Oyunİsmi = g.GameName,
                    OyuncuPuanı=pl.Point
                    

                }).OrderBy(o=> o.OyuncuPuanı).Take(1).ToList();
        }

        void NotPlaying()
        {
            /*Grid1.DataSource = null;
            Grid1.DataSource = GetPlaying()
                .GroupBy(pl => pl.GameId=0
                ).
                    );*/

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Oyuncular();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Oyunlar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Oynayanlar();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Top5();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            EnKotu();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            NotPlaying();
        }
    }


}
