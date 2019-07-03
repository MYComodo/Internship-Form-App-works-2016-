using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA.Properties
{
    public class Player
    {
        public string NickName { get; }
        public decimal Point { get; set; }
        public Level Level { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public Player(string nickName)
        {
            NickName = nickName;
        }
    }
}
