using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA.Tank
{
    class Motor
    {
        public string MotorAdi { get;}
        public decimal BeygirGucu { get; set; }

        public Motor(string motorAdi)
        {
            MotorAdi = motorAdi;

        }
    }
}
