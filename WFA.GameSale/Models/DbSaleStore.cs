using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
namespace WFA.GameSale.Models
{
    public class DbSaleStore :DbContext
    {
        public virtual DbSet<Sale> Sales { get; set; }
        public virtual DbSet<Game> Games { get; set; }
        public virtual DbSet<Player> Players { get; set; }

        public DbSaleStore()
        {
        Database.SetInitializer<DbSaleStore>(null);
        }
    }
}
