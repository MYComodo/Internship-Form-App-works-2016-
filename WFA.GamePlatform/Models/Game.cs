using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA.GamePlatform.Models
{
    class Game
    {
        [Key]
        public int GameId { get; set; }
        public string GameName { get; set; }
        public int GamePrice { get; set; }

        public virtual Game Games { get; set; }

    }
}
