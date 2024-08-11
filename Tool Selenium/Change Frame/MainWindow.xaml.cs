using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
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

namespace Change_Frame
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
            ChromeDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://howkteam.vn/course/turn-off-webrtc-voi-selenium-trong-wpf/turn-off-webrtc-voi-selenium-trong-wpf-2589");
            IWebElement ytb = driver.FindElement(By.Id("ytplayer"));
            ytb.Click();
            // Neu nhu khong co cau lenh nay thi se khong the chuyen trang duoc 
            driver.SwitchTo().Frame(ytb);
            var ytb_frame = driver.FindElement(By.CssSelector(".ytp-youtube-button"));
            ytb_frame.Click();
        }
    }
}
