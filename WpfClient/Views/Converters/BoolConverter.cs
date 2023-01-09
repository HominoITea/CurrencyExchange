using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace WpfClient.Views.Converters
{
    public class BoolInverter : IValueConverter
    {
        public static readonly IValueConverter Instance = new BoolInverter();
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            try
            {
                if (value == null) return false;

                var boolValue = (bool)value;
                return boolValue ? false : true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) => Binding.DoNothing;
        
    }
}
