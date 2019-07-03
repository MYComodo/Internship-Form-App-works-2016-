using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace WFA.GamePlatform.Models
{
    class Sales
    {
        [Key]
        public int SaleId { get; set; }
        [Key]
        public int GameId { get; set; }
        [Key]
        public int PlayerId { get; set; }
        public decimal BuyMoney { get; set; }

        public virtual ICollection<Game> Games { get; set; }
        public virtual ICollection<Player> Players { get; set; }

    }
}
