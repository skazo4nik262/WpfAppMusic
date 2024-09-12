using MySqlConnector;
using System.ComponentModel;
using System.Runtime.CompilerServices;
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
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public MainWindow()
        {
            MySqlConnection mySqlConnection;
            MySqlConnectionStringBuilder sb =
                new MySqlConnectionStringBuilder();
            sb.Server = "192.168.200.13";
            sb.UserID = "student";
            sb.Password = "student";
            sb.Database = "database_Music_1135_new_free_bez_sms";
            sb.CharacterSet = "utf8mb4";
            sb.ConnectionTimeout = 5;
            //Console.WriteLine(sb.ToString());
            mySqlConnection = new MySqlConnection(sb.ToString());

            try
            {
                mySqlConnection.Open();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine($"{ex.Number}: {ex.Message}");
                return;
            }

            MysqlTools.SetConnection(mySqlConnection);

            InitializeComponent();
            DataContext = this;
            Vibori();
        }

        public List<Music> musics;
        public List<Music> Musics { get => musics; set { musics = value; Signal(); } }
        public List<Singer> Artists { get; set; }
        public List<ALbum> Albums { get; set; }

        private Music selectedMusic;
        public Music SelectedMusic {  get => selectedMusic; set { selectedMusic = value; Signal(); } }
        private Singer selectedArtist;
        public Singer SelectedArtist {  get => selectedArtist; set { selectedArtist = value; Signal(); } }
        private ALbum selectedALbum;
        public ALbum SelectedALbum {  get => selectedALbum; set { selectedALbum = value; Signal(); } }

        public List<Table> Tables {  get; set; }


        public event PropertyChangedEventHandler? PropertyChanged;

        protected void Signal([CallerMemberName] string prop = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }


        public void Vibori()
        {
            Musics = MysqlTools.SimpleSelectFromTable<Music>();//" JOIN Singer ON Music.Singer_ID=Singer.ID"
            Artists = MysqlTools.SimpleSelectFromTable<Singer>();
            Albums = MysqlTools.SimpleSelectFromTable<ALbum>();
            
        }

        DataBase dataBase = new DataBase();
        private void AddMusic(object sender, RoutedEventArgs e)
        {
            
        }

        private void EditMusic(object sender, RoutedEventArgs e)
        {

        }

        private void DeleteMusic(object sender, RoutedEventArgs e)
        {
            var music = dataBase.GetMusicByID(selectedMusic.ID).Delete();
            //var singer = dataBase.GetSingerByID(selectedMusic.ID).Delete();
        }

        private void AddArtist(object sender, RoutedEventArgs e)
        {

        }

        private void EditArtist(object sender, RoutedEventArgs e)
        {

        }

        private void DeleteArtist(object sender, RoutedEventArgs e)
        {

        }

        private void AddAlbum(object sender, RoutedEventArgs e)
        {

        }

        private void EditAlbum(object sender, RoutedEventArgs e)
        {

        }

        private void DeleteAlbum(object sender, RoutedEventArgs e)
        {

        }
    }
}