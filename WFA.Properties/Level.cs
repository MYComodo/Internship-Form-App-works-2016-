using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA.Properties
{
    public class Level
    {
        public string LevelName { get; set; }
        public object Object { get; set; }
        public decimal MinPoint { get; set; }
        public decimal MaxPoint { get; set; }
        public bool IsActive { get; set; }
    }
}
