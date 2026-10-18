using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Text;
using SystemProgramming_MiniShop.Data;
using SystemProgramming_MiniShop.Models;
using SystemProgramming_MiniShop.Repository.Abstract;

namespace SystemProgramming_MiniShop.Repository.Concrete
{
    public class OrderRepository : IOrderRepository
    {
        private readonly ShopDBContext _context;

        public OrderRepository(ShopDBContext context)
        {
            _context = context;
        }

        public void Add(Order entity)
        {
            _context.Orders.Add(entity);
        }

        public Task AddAsync(OrderItem orderItem)
        {
            throw new NotImplementedException();
        }

        public Task AddAsync(Order order)
        {
            throw new NotImplementedException();
        }

        public Task AddAsync(Ticket newTicket)
        {
            throw new NotImplementedException();
        }

        public void Delete(Order entity)
        {
            _context.Orders.Remove(entity);
        }

        public async Task<List<Order>> GetAllAsync()
        {
            return await _context.Orders.ToListAsync();
        }

        public async Task<Order?> GetByIdAsync(int id)
        {
            return await _context.Orders.SingleOrDefaultAsync(o => o.Id == id);
        }

        public Task SaveChangesAsync()
        {
            throw new NotImplementedException();
        }

        public void Update(Order entity)
        {
            _context.Orders.Update(entity);
        }
    }
}
