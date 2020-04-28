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
using Newtonsoft.Json;
namespace MovieSearch
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Movie SearchedMovie { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            ApiStart.StartClientHttp();

        }


        private async Task LoadImage(string search)
        {
            MovieProcessor processor = new MovieProcessor();
            SearchedMovie = await processor.LoadMovie(search);

            BitmapImage bitmapImage = new BitmapImage();
            bitmapImage.BeginInit();
            var uriSource = new Uri(SearchedMovie.Poster, UriKind.Absolute);
            bitmapImage.UriSource = uriSource;
            bitmapImage.EndInit();


            this.ImageHolder.Source = bitmapImage;

        }

        private async void Window_Loaded(object sender, RoutedEventArgs e)
        {
            await LoadImage("it");
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            await LoadImage(this.SearchBar.Text);
            this.Movie_Title.Text = SearchedMovie.Title;
            this.Movie_RunTime.Text = SearchedMovie.RunTime;
            this.Movie_Genre.Text = SearchedMovie.Genre;
            this.Movie_ReleaseYear.Text = SearchedMovie.Year;
            this.Movie_Description.Text = SearchedMovie.Plot;
        }
    }
}
