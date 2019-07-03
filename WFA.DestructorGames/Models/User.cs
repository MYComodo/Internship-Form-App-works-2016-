using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA.DestructorGames.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        [MaxLength(75)]
        public string FullName { get; set; }
        [MaxLength(10)]
        public string UserName { get; set; }
        [MaxLength(8)]
        public string Password { get; set; }
        public bool IsActive { get; set; }
    }
}
