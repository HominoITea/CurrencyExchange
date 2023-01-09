using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientShared.Entities
{
    internal class CurrencyRate
    {
        public DateTime Created { get; set; }
        public double Rate { get; set; }
        public Currency From { get; set; }
        public Currency To { get; set; }        
    }
}
