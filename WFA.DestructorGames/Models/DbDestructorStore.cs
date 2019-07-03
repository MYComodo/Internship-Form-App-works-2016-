using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA.DestructorGames.Models
{
    public class DbDestructorStore:DbContext
    {
        public DbDestructorStore():base("DbDestructorStore")
        {

        }
        public DbSet<Player> Players { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
