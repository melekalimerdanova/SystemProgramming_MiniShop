using System;
using System.Collections.Generic;
using System.Text;
using SystemProgramming_MiniShop.Models;

namespace SystemProgramming_MiniShop.Repository.Abstract
{
    public interface IRepository<T> where T : class
    {
        Task<List<T>> GetAllAsync();
        Task<T?> GetByIdAsync(int id);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        Task AddAsync(OrderItem orderItem);
        Task SaveChangesAsync();
        Task AddAsync(Order order);
        Task AddAsync(Ticket newTicket);
    }
}
