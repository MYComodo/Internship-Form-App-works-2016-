using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA.Tank
{
    class Tank
    {
        //public string @string;
        
        public string TankAdi { get; }
        public DateTime ModelYili { get; set; } 
        public decimal Uzunluk { get; set; }
        public string Zirhi { get;set;}
        public Silah AnaSilahi{ get; set; }
        public int AzamiHiz { get; set; }


        #region Extra
        //public Motor Motoru{ get; set; }
        // public Ulke Ulkesi { get; set; } 
        //public int BosAgirlik { get; set; }
        //public float Genislik{ get; set; }
        //public float Yukseklik { get; set; }
        // public int MrttebatSay { get; set; }
        #endregion



        public Tank(string tankAdi)
        {
            
            TankAdi = tankAdi;
        }
    }
}
