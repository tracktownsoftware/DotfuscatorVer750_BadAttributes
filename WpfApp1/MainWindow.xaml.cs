using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var service = new LibraryAssembly1.PublicApiService("TestService");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var service = new LibraryAssembly1.PublicApiService("TestService");
            var status = service.GetStatus();
            MessageBox.Show(status, "Service Status", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}