using System;
using System.Collections.Generic;
using System.Text;

namespace SystemProgramming_MiniShop.Models
{
    public class OrderItem
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public int OrderId { get; set; }
        public int TicketId { get; set; }
        public Order Order { get; set; } = null!;
        public Ticket Ticket { get; set; } = null!;
    }
}
