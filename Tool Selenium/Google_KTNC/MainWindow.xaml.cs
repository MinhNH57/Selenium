using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
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

namespace Google_KTNC
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ChromeDriver drive = new ChromeDriver();
            drive.Url = "https://www.google.com/";
            drive.Navigate();

            IWebElement Search_Bar = drive.FindElement(By.XPath("/html/body/div[1]/div[3]/form/div[1]/div[1]/div[1]/div/div[2]/textarea"));
            Search_Bar.Click();
            Search_Bar.SendKeys("Messi");
            Search_Bar.SendKeys(Keys.Enter);
        }
    }
}