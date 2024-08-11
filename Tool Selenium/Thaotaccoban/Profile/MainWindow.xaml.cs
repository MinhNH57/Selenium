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

namespace Profile
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
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("user-data-dir=C:\\Users\\Dell\\AppData\\Local\\Google\\Chrome\\User Data");
            options.AddArgument("profile-directory=Profile 4");
            ChromeDriver chromeDriver = new ChromeDriver(options);
            chromeDriver.Navigate().GoToUrl(@"https://www.google.com");
            var search = chromeDriver.FindElements(By.Id("APjFqb"));

            if (search.Count > 0)
            {
                IWebElement searchInput = search[0];
                searchInput.SendKeys("Facebook");
                searchInput.SendKeys(Keys.Enter);
            }
            else
            {
                Console.WriteLine("Không tìm thấy phần tử với ID 'input'");
            }
        }
    }
}
