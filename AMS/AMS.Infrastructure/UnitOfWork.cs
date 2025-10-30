using AMS.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMS.Infrastructure
{
    public abstract class UnitOfWork : IUnitOfWork
    {
        private readonly DbContext _context;
        public UnitOfWork(DbContext context)
        {
            _context = context;
        }   
        public void Save()
        {
            _context.SaveChanges();
        }
        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
