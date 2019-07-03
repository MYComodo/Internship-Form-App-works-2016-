using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA.DestructorGames.Models
{
    public class Game
    {
        [Key]
        public int GameId { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }
        public int ListPrice { get; set; }
        public int Quantity { get; set; }
        public DateTime StockDate { get; set; }
        public bool IsActive { get; set; }
        public virtual ICollection<Sale> Sales { get; set; }

    }
}
