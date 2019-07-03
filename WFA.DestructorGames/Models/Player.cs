using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA.DestructorGames.Models
{
    public class Player
    {
        [Key]
        public int PlayerId { get; set; }
        [MaxLength(75)]
        public string FullName { get; set; }
        [MaxLength(75)]
        public string NickName { get; set; }
        public decimal Price { get; set; }
        public DateTime RegisterationDate { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<Sale> Sales { get; set; }
    }
}
