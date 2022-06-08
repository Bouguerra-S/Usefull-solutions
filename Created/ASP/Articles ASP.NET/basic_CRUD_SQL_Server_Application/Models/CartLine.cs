using System;
using System.Collections.Generic;

#nullable disable

namespace basic_CRUD_SQL_Server_Application.Models
{
    public partial class CartLine
    {
        public int CartLineId { get; set; }
        public string ProductId { get; set; }
        public int Quantity { get; set; }
        public int CartHeader { get; set; }

        public virtual Cart CartHeaderNavigation { get; set; }
        public virtual Product Product { get; set; }
    }
}
