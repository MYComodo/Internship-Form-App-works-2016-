using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace WFA.SqlWriteExample.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [MaxLength(150)]
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }

        public DateTime ProductBuyDate { get; set; }
        public bool IsActive { get; set; }

        public virtual Category Category { get; set; }
            
    }
}
