using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfClient.Views.CurrencyTable.Controls
{
    /// <summary>
    /// Логика взаимодействия для StartYearControl.xaml
    /// </summary>
    public partial class StartYearControl : UserControl
    {
        public StartYearControl()
        {
            InitializeComponent();
        }

        private void NumberValidationHandler(object sender, TextCompositionEventArgs e)
        {
            var result = 0;
            e.Handled = !int.TryParse(e.Text, out result) || e.Text.Length != 4;
        }
    }
}
