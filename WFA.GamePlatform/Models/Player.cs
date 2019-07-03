using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA.GamePlatform.Models
{
    class Player
    {
        [Key]
        public int PlayerId { get; set; }
        public string  PlayerName { get; set; }
        public string Password { get; set; }
        public DateTime RegistrationDate { get; set; }
        public decimal PlayerAccount { get; set; }
        public string PlayerMail { get; set; }
        
        public virtual Player Players { get; set; }

    }
}
