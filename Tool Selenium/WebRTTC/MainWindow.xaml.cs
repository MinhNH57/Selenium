using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
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
using System.Windows.Shell;

namespace WebRTTC
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ChromeOptions chromeOptions = new ChromeOptions();
            chromeOptions.AddUserProfilePreference("profile.default_content_setting_values.media_stream", 2);
            chromeOptions.AddUserProfilePreference("profile.default_content_setting_values.media_stream_mic", 2);
            chromeOptions.AddUserProfilePreference("profile.default_content_setting_values.media_stream_camera", 2);
            chromeOptions.AddUserProfilePreference("media.peerconnection.enabled", false);

            ChromeDriver driver = new ChromeDriver(chromeOptions);
            driver.Navigate().GoToUrl(@"https://vi.vpnmentor.com/tools/ip-leak-test-vpns-tor/");
        }
    }
}
