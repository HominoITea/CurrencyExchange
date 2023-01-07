using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Core.Entities
{
    public class CurrencyRate : BaseEntity
    {
        public double Rate { get; set; }
        public Currency From { get; set; }
        public Currency To { get; set; }
    }
}