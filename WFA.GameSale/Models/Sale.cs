using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace WFA.GameSale.Models
{
    public class Sale
    {
        [Key]
        public int SaleId { get; set; }
        public int GameId { get; set; }
        public int PlayerId { get; set; }
        public decimal BuyMoney { get; set; }

        public virtual ICollection<Game> Game { get; set; }
        public virtual ICollection<Player> Player { get; set; }
    }
}
