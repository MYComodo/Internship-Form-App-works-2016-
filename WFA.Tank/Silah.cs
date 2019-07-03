using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA.Tank
{
    class Silah
    {
        public string SilahAdi { get; set; }
        public decimal  Caliber{ get; set; }
        //public Ulke UretimYeri { get; set; }

        public override string ToString()
        {
            return SilahAdi;
        }


    }
}
