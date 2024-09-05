using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TesteCrud
{
    public class Begin
    {
        public IWebDriver driver;
        public bool Quit = true;

        [SetUp]
        public void StartTest()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://localhost:7025/Usuarios/Create");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(6);
        }

        [TearDown]
        public void StopTest()
        {
            if(Quit == false) driver.Close();
        }
    }
}