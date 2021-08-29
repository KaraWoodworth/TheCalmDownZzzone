using System;
using System.Collections.Generic;
using System.IO;
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
//using System.Windows.Shapes;

namespace CalmDown.pages
{
    /// <summary>
    /// Interaction logic for CoreTest.xaml
    /// </summary>
    public partial class FeaturePage : Page
    {
        private String folderpath = "Assets\\Test";
        private Boolean isGIF = false;
        public FeaturePage()
        {
            InitializeComponent();
            this.ShowsNavigationUI = false;
        }
        /// <summary>
        /// sets up page based on arguments
        /// </summary>
        /// <param name="titletext"> what you see at top of page </param>
        /// <param name="buttontext"> what you see on button </param>
        /// <param name="pagepath"> relative to executable </param>
        public FeaturePage(String titletext, String buttontext, String pagepath)
        {
            InitializeComponent();
            pageButton.Content = buttontext;
            pageLabel.Content = titletext;
            folderpath = pagepath;
        }
        /// <summary>
        /// Overload for constructing
        /// </summary>
        /// <param name="titletext"></param>
        /// <param name="pagepath"></param>
        public FeaturePage(String titletext, String pagepath, Boolean isgif)
        {
            InitializeComponent();
            isGIF = isgif;
            pageLabel.Content = titletext;
            folderpath = pagepath;
            pageMedia.Source = new Uri(Path.GetFullPath(pagepath));
            pageButton.IsEnabled = false;
            pageButton.Visibility = Visibility.Hidden;
            pageImage.Visibility = Visibility.Hidden;
        }

        private void pageMedia_MediaEnded(object sender, RoutedEventArgs e)
        {
            pageMedia.Position = new TimeSpan(0, 0, 1);
            pageMedia.Play();
        }

        private void GenerateLabel(object sender, RoutedEventArgs e)
        {
            
            string selectedFileName = CoreCore.getRandomPath(folderpath);
            if (selectedFileName != "")
            {
                Uri fileUri = new Uri(Path.GetFullPath(selectedFileName));

                pageImage.Source = new BitmapImage(fileUri);
            }
            
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService ns = NavigationService.GetNavigationService(this);
            
            ns.Navigate(new StartPage());            
        }
    }
}
