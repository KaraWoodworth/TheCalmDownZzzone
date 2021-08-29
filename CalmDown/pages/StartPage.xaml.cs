using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
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

namespace CalmDown.pages
{
    /// <summary>
    /// Interaction logic for StartPage.xaml
    /// </summary>
    public partial class StartPage : Page
    {
        public StartPage()
        {
            InitializeComponent();
        }

        

        private void clickBreathing(object sender, RoutedEventArgs e)
        {
            //TODO: make new page for breathing since its different in some way
        }

        private void clickStretches(object sender, RoutedEventArgs e)
        {
            NavigationService ns = NavigationService.GetNavigationService(this);
            ns.Navigate(new FeaturePage(ButtonStretches.Content.ToString(), "Recommend Stretch", "Assets\\Stretch"));
        }

        private void clickTea(object sender, RoutedEventArgs e)
        {
            NavigationService ns = NavigationService.GetNavigationService(this);
            ns.Navigate(new FeaturePage(ButtonTea.Content.ToString(), "Recommend A Tea", "Assets\\Tea"));
        }

        private void clickSmile(object sender, RoutedEventArgs e)
        {
            NavigationService ns = NavigationService.GetNavigationService(this);
            ns.Navigate(new FeaturePage(ButtonSmile.Content.ToString(), "Make me smile", "Assets\\Smile"));
        }

        private void clickCheckbox(object sender, RoutedEventArgs e)
        {
            SoundPlayer sp = new SoundPlayer();
            if ((bool)(CheckMusic.IsChecked)){ 
                sp.SoundLocation = "assets\\RainforestWAV.wav";
                sp.Play();
            }
            else
            {
                sp.Stop();
            }
        }
    }
}
