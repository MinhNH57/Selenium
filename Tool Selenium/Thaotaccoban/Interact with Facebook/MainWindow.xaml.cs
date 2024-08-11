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
using System.Windows.Shell;

namespace Interact_with_Facebook
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
            ChromeDriver chromeDriver = new ChromeDriver();
            chromeDriver.Navigate().GoToUrl("https://fpl1.poly.edu.vn/login.php?target=&client_id=fpolyhn&auth_stat=");


            //IWebElement email_input = chromeDriver.FindElement(By.Id("email"));
            //IWebElement pass_input = chromeDriver.FindElement(By.Id("passContainer"));

            //email_input.SendKeys("oanhchuthi698@gmail.com");
            ////pass_input.SendKeys("ChuThiOanh123456@");
            ////pass_input.SendKeys(Keys.Enter);

        }
    }
}
