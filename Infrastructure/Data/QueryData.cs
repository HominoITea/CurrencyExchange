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
    public class QueryData<T>: IQueryData<T> where T: BaseEntity
    {
        private readonly DbContext _context;

        public QueryData(DbContext context)
        {
            _context = context;
        }      

        public async Task<IReadOnlyList<T>> ListAllAsync()
        {
            return await _context.Set<T>().ToListAsync<T>();
        }

        public async Task<IList<T>> ListByPeriodAsync(int year, int month)
        {
            return await _context.Set<T>()
                .OrderBy((x) => x.Id)
                .Where(x => x.Created.Year == year && x.Created.Month == month)
                .ToListAsync();
        }
    }
}
