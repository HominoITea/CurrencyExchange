using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using WpfClient.ViewModels.Interfaces;
using WpfClient.ViewModels.Shared;

namespace WpfClient.ViewModels
{
    public sealed class MainViewModel : BaseViewModel, IMainViewModel
    {
        public IYearPickerViewModel YearPicker { get; set; }
        public IDataGridViewModel DataGrid { get; set; }
        public MainViewModel(IYearPickerViewModel yearPicker, IDataGridViewModel dataGrid) 
        {
            YearPicker = yearPicker;
            DataGrid = dataGrid;    
        }        
    }
}
