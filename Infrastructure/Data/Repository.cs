using Core.Entities;
using Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class Repository<T>: IAsyncRepository<T> where T: BaseEntity
    {
        private CurrencyContext _context;

        public Repository(CurrencyContext context)
        {
            _context = context;
        }
        
        public async Task UpdateAllAsync(List<T> entities)
        {
            foreach (var entity in entities)
            {
                _context.Entry(entity).State = EntityState.Modified;
            }
            await _context.SaveChangesAsync();
        }

        public async Task AddAllAsync(List<T> entities)
        {
            foreach (var entity in entities)
            {
                _context.Entry(entity).State = EntityState.Added;
            }
            await _context.SaveChangesAsync();
        }

        public async Task<IReadOnlyList<T>> ListAllAsync()
        {
            return await _context.Set<T>().ToListAsync<T>();
        }

        public async Task<IReadOnlyList<T>> ListByPeriodAsync(int year, int month)
        {
            var slice = await _context.Set<T>()
                .OrderBy((x) => x.Id)
                .Where(x => x.Created.Year == year && x.Created.Month == month)
                .ToListAsync();

            return slice;
        }
    }
}
