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

namespace Thaotaccoban
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
            chromeDriver.Url = "https://tratencongty.com/";
            chromeDriver.Navigate();

            // Tim kiem tu dong
            var search = chromeDriver.FindElements(By.Name("q"));

            IWebElement searchInput = search[0];

            // Thực hiện một số thao tác với phần tử tìm thấy, ví dụ: nhập văn bản
            searchInput.SendKeys("Phung Xa");

            //Tim ra the co class name la input-group-btn
            var acction_click_parent = chromeDriver.FindElement(By.ClassName("input-group-btn"));
            // Tu the cos class name la input-group-btn tim ra mot the button
            var button_click = acction_click_parent.FindElement(By.TagName("button"));
            button_click.Click();

        }
    }
}
