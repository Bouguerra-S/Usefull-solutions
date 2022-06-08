using System;
using System.Collections.Generic;

#nullable disable

namespace basic_CRUD_SQL_Server_Application.Models
{
    public partial class Product
    {
        public Product()
        {
            CartLines = new HashSet<CartLine>();
        }

        public string ProductId { get; set; }
        public string ProductLabel { get; set; }
        public decimal? UnitPrice { get; set; }
        public byte[] ProductImage { get; set; }

        public virtual ICollection<CartLine> CartLines { get; set; }
    }
}
