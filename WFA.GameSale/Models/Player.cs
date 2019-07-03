using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace WFA.GameSale.Models
{
    public class Player
    {
        [Key]
        public int PlayerId { get; set; }
        public string PlayerName { get; set; }
        public string PlayerMail { get; set; }
        public string Password { get; set; }
        public decimal PlayerAccount { get; set; }
        public DateTime RegistrationDate { get; set; }
        public bool IsActive { get; set; }

        public virtual Sale Sales { get; set; }

    }
}
