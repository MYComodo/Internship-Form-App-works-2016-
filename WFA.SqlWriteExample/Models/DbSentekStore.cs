using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace WFA.SqlWriteExample.Models
{
    public class DbSentekStore:DbContext
    {
        public virtual DbSet<Category> Categories { get; set; }
       public virtual DbSet<Product> Products { get; set; }
    }
}
