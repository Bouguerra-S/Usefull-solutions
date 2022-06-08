using System;
using System.Collections.Generic;

#nullable disable

namespace basic_CRUD_SQL_Server_Application.Models
{
    public partial class Cart
    {
        public Cart()
        {
            CartLines = new HashSet<CartLine>();
        }

        public int CartId { get; set; }
        public string ClientName { get; set; }
        public DateTime DateCreated { get; set; }

        public virtual ICollection<CartLine> CartLines { get; set; }
    }
}
