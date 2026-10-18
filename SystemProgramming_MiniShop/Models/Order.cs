using System;
using System.Collections.Generic;
using System.Text;

namespace SystemProgramming_MiniShop.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string? CustomerName { get; set; }
        public DateTime CreatedDate { get; set; }
        public List<OrderItem> Items { get; set; } = new();
    }
}
