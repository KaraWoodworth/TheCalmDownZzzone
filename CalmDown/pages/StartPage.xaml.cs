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
            this.ShowsNavigationUI = false;
        }


        private void clickBreathing(object sender, RoutedEventArgs e)
        {
            NavigationService ns = NavigationService.GetNavigationService(this);

            ns.Navigate(new FeaturePage(ButtonBreathing.Content.ToString(), "assets\\breathe\\box_breathing_gif_healthline.gif", true));

        }

        private void clickStretches(object sender, RoutedEventArgs e)
        {
            NavigationService ns = NavigationService.GetNavigationService(this);
            ns.Navigate(new FeaturePage(ButtonStretches.Content.ToString(), "Give me a stretch!", "assets\\stretches"));
            
        }

        private void clickTea(object sender, RoutedEventArgs e)
        {
            NavigationService ns = NavigationService.GetNavigationService(this);
            ns.Navigate(new FeaturePage(ButtonTea.Content.ToString(), "Pick me a tea!", "assets\\teas"));
        }

        private void clickSmile(object sender, RoutedEventArgs e)
        {
            NavigationService ns = NavigationService.GetNavigationService(this);
            ns.Navigate(new FeaturePage(ButtonSmile.Content.ToString(), "I need smiles!", "assets\\cutePics"));
        }

         private void CheckMusic_Checked(object sender, RoutedEventArgs e)
        {
            SoundPlayer sp = new SoundPlayer();
            if (CheckMusic.IsChecked == true){ 
                sp.SoundLocation = "assets\\RainSmall.wav";
                sp.PlayLooping();
            }
            else
            {
                sp.Stop();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService ns = NavigationService.GetNavigationService(this);
            ns.Navigate(new Resources());
        }
    }
}
