using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;
using System.Windows;

namespace Lab06_KiemThuNangCao
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Khởi tạo ChromeDriver
            ChromeDriver chromeDriver = new ChromeDriver();

            try
            {
                // Điều hướng đến trang web
                chromeDriver.Navigate().GoToUrl("https://fpl1.poly.edu.vn/login.php?target=&client_id=fpolyhn&auth_stat=");

                //IWebElement email_input = chromeDriver.FindElement(By.XPath("/html/body/div[1]/header/div/ul/li[2]"));
                //email_input.Click();

                //IWebElement input1 = chromeDriver.FindElement(By.Id("main_menu_search"));
                //input1.SendKeys("Ha Noi");
                //input1.SendKeys(Keys.Enter);

                IWebElement DN = chromeDriver.FindElement(By.XPath("/html/body/div[1]/main/div/div/div/div/div/div[3]/div[3]/div/div/div[3]/div/div[3]/a"));
                DN.Click();
                IWebElement TK = chromeDriver.FindElement(By.Id("identifierId"));
                TK.SendKeys("minhnhph45057@fpt.edu.vn");
                TK.SendKeys(Keys.Enter);
                WebDriverWait wait = new WebDriverWait(chromeDriver, TimeSpan.FromSeconds(15));
                IWebElement passwordField = wait.Until(driver =>
                    driver.FindElement(By.XPath("//input[@type='password']")));

                Thread.Sleep(2000);

                //IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)chromeDriver;
                //jsExecutor.ExecuteScript("arguments[0].value = '0945451168';", passwordField);

                passwordField.SendKeys("0945451168");

                passwordField.SendKeys(Keys.Enter);

            }
            catch (NoSuchElementException ex)
            {
                Console.WriteLine("Không tìm thấy phần tử: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Đã xảy ra lỗi: " + ex.Message);
            }
            finally
            {
                // Đóng trình duyệt
                //chromeDriver.Quit();
            }
        }
    }
}
