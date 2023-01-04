using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WcfServer.Entities
{
    public class CurrencyRate
    {
        [Key]
        [ForeignKey("Currency")]
        public int Id { get; set; }        
        public int CurrencyId { get; set; }
        public double Rate { get; set; }
        public Currency Currency { get; set; }
    }
}