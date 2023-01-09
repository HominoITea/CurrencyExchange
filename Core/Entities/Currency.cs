using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Core.Entities
{
    public class Currency : BaseEntity
    {
        public string Code { get; set; }
        public string FullName { get; set; }    
    }
}