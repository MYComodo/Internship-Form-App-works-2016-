using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Web;

namespace WFA.SqlWriteExample.Models
{
    public class Category
    { 
        
        [Key]
        public int CategoryId { get; set; }
        [MaxLength(150)]
        public string CategoryName { get; set; }   
         
        public bool IsActive { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
