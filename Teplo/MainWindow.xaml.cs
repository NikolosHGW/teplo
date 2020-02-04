using System.Windows;

namespace Teplo
{
    /// <summary>
    ///     Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Info(object sender, RoutedEventArgs e)
        {
            var infoshka = (ViewModelINFO) Resources["abc"];
            infoshka.ChngOpa();
        }
    }
}