using System.Windows.Controls;
using System.Windows.Input;


namespace WpfClient.Views.Controls
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
