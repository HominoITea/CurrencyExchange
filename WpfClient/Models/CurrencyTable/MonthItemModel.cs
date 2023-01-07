using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using WpfClient.Annotations;

namespace WpfClient.Models.CurrencyTable
{
    public sealed class MonthItemModel
    {
        public string MonthName { get; set; }
        public string Quarter { get; set; }
        public DateTime TargetDate { get; set; }
    }
}
