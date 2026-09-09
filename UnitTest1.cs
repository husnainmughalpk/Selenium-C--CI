using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace SeleniumProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            OpenQA.Selenium.IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.google.com");
            driver.Manage().Window.Maximize();
            IWebElement searchbox = driver.FindElement(By.Name("q"));
            searchbox.SendKeys("Selenium");
            searchbox.SendKeys(Keys.Return);
            driver.Close();
        }

        [Test]
        public void Workingadvancedcode()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("file:///D:/OneDrive%20-%20PERSEUS%20MANAGEMENT%20GROUP%20INC/Drop%20Down%20PageHTML%20File/dropdown.html");

            SelectElement selectElement = new SelectElement(driver.FindElement(By.Id("country")));
            selectElement.SelectByText("Pakistan");
            Thread.Sleep(1000);
            driver.FindElement(By.Id("fullName")).SendKeys("John Doe");
            Thread.Sleep(1000);
            driver.FindElement(By.Id("email")).SendKeys("husnainmughal@gmail.com");
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//input[@type='radio' and @value='male']")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("/html/body/div/div[2]/label[2]/input")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.Id("comments")).SendKeys("123456");
            driver.FindElement(By.Id("submitBtn")).Click();
            driver.Close();
        }


    }
}
