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
        public FeaturePage()
        {
            InitializeComponent();
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

        private void GenerateLabel(object sender, RoutedEventArgs e)
        {
            string selectedFileName = CoreCore.getRandomPath(folderpath);
            if(selectedFileName != "")
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
