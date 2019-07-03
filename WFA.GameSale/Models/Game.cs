using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace WFA.GameSale.Models
{
    public class Game
    {

        [Key]
        public int GameId { get; set; }
        public string GameName { get; set; }
        public decimal GamePrice { get; set; }

        public virtual Sale Sales { get; set; }

    }
}
