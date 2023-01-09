using Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class DbFactory<T> : IDbFactory<T> where T : class, new()
    {
        private T _context;

        public T Initialize() 
        { 
            return _context ?? (_context = new T()); 
        }  
    }
}
