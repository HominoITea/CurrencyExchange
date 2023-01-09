using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfClient.Annotations;
using WpfClient.ViewModels.BaseComands;

namespace WpfClient.Models
{
    public sealed class MonthItemModel
    {
        public string MonthName { get; set; }
        public string Quarter { get; set; }
        public DateTime TargetDate { get; set; }
    }
}
