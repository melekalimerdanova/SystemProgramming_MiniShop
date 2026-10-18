using System;
using System.Linq;
using System.Threading.Tasks;
using SystemProgramming_MiniShop.Data;
using SystemProgramming_MiniShop.Models;
using SystemProgramming_MiniShop.Repository.Concrete;

namespace SystemProgramming_MiniShop
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            using var context = new ShopDBContext();

            var ticketRepo = new TicketRepository(context);
            var orderRepo = new OrderRepository(context);
            var orderItemRepo = new OrderItemRepository(context);

            Console.WriteLine("--- Butun Biletler ---");
            var tickets = await ticketRepo.GetAllAsync();
            foreach (var t in tickets)
            {
                Console.WriteLine($"ID: {t.Id} | Name: {t.Name} | Price: {t.Price} AZN | Stock: {t.Stock}");
            }

            Console.WriteLine("\n--- Yeni Ticket Elave Olunur ---");
            var newTicket = new Ticket { Name = "Backstage Pass", Price = 200m, Stock = 3 };
            ticketRepo.Add(newTicket);
            context.SaveChanges(); 
            Console.WriteLine("Yeni ticket ugurla elave olundu!");

            Console.WriteLine("\n--- Ticket Yenilenir ---");
            var ticketToUpdate = await ticketRepo.GetByIdAsync(1);
            if (ticketToUpdate != null)
            {
                ticketToUpdate.Price = 120m;
                ticketRepo.Update(ticketToUpdate);
                context.SaveChanges();
                Console.WriteLine("ID 1 olan ticket-in qiymeti 120m olaraq yenilendi.");
            }

            Console.WriteLine("\n--- Yeni Sifaris Yaradilir ---");
            var order = new Order
            {
                CustomerName = "Melek Elimerdanova",
                CreatedDate = DateTime.Now
            };

            orderRepo.Add(order);
            context.SaveChanges();
            Console.WriteLine($"Sifaris yaradildi. Musteri: {order.CustomerName}, Sifaris ID: {order.Id}");

            var selectedTicket = (await ticketRepo.GetAllAsync()).FirstOrDefault();
            if (selectedTicket != null)
            {
                var orderItem = new OrderItem
                {
                    OrderId = order.Id,
                    TicketId = selectedTicket.Id,
                    Quantity = 2,
                    Price = selectedTicket.Price
                };

                orderItemRepo.Add(orderItem);
                context.SaveChanges();
                Console.WriteLine("Sifaris elementi ugurla elave olundu!");
            }

            Console.WriteLine("\nButun emeliyyatlar ugurla basa catdi!");
        }
    }
}