using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA.DestructorGames.Models
{
    public class Sale
    {
        [Key]
        public int SaleId { get; set; }
        public int PlayerId { get; set; }
        public int GameId { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public DateTime SaleDate { get; set; }
        public bool IsActive { get; set; }

        public virtual Player Player { get; set; }
        public virtual Game Game { get; set; }


    }
}
