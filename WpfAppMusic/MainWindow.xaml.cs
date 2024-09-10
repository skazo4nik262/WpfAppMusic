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

namespace WpfAppMusic
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public List<Music> Sigma { get; set; }

        public List<Music> Vibori()
        {
            return Sigma = MysqlTools.SimpleSelectFromTable
        }

        
        
        

        private void zaglushka1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Не хватило финансирования(транзакций)");
        }

        private void zaglushka2(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Не хватило финансирования");
        }
    }
}