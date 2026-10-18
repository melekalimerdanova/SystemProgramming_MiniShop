using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Text;
using SystemProgramming_MiniShop.Data;
using SystemProgramming_MiniShop.Models;
using SystemProgramming_MiniShop.Repository.Abstract;

namespace SystemProgramming_MiniShop.Repository.Concrete
{
    public class TicketRepository : ITicketRepository
    {
        private readonly ShopDBContext _context;

        public TicketRepository(ShopDBContext context)
        {
            _context = context;
        }

        public void Add(Ticket entity)
        {
            _context.Tickets.Add(entity);
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

        public void Delete(Ticket entity)
        {
            _context.Tickets.Remove(entity);
        }

        public async Task<List<Ticket>> GetAllAsync()
        {
            return await _context.Tickets.ToListAsync();
        }

        public async Task<Ticket?> GetByIdAsync(int id)
        {
            return await _context.Tickets.SingleOrDefaultAsync(t => t.Id == id);
        }

        public Task SaveChangesAsync()
        {
            throw new NotImplementedException();
        }

        public void Update(Ticket entity)
        {
            _context.Tickets.Update(entity);
        }
    }
}
