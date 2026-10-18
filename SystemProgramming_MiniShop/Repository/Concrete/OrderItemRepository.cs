using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Text;
using SystemProgramming_MiniShop.Data;
using SystemProgramming_MiniShop.Models;
using SystemProgramming_MiniShop.Repository.Abstract;

namespace SystemProgramming_MiniShop.Repository.Concrete
{
    public class OrderItemRepository : IOrderItemRepository
    {
        private readonly ShopDBContext _context;

        public OrderItemRepository(ShopDBContext context)
        {
            _context = context;
        }

        public void Add(OrderItem entity)
        {
            _context.OrderItems.Add(entity);
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

        public void Delete(OrderItem entity)
        {
            _context.OrderItems.Remove(entity);
        }

        public async Task<List<OrderItem>> GetAllAsync()
        {
            return await _context.OrderItems.ToListAsync();
        }

        public async Task<OrderItem?> GetByIdAsync(int id)
        {
            return await _context.OrderItems.SingleOrDefaultAsync(oi => oi.Id == id);
        }

        public Task SaveChangesAsync()
        {
            throw new NotImplementedException();
        }

        public void Update(OrderItem entity)
        {
            _context.OrderItems.Update(entity);
        }
    }
}
