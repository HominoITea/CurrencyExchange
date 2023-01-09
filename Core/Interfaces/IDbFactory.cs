using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IDbFactory <T>
    {
        T Initialize();
    }
}
