




using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using sales_manager.pages;


public class basetest
{
    public IWebDriver driver;

    [OneTimeSetUp]
    public void basesetup()
    {
        
        driver = new ChromeDriver(); // or new FirefoxDriver();
        //driver = new FirefoxDriver(); // or new ChromeDriver();
        driver.Manage().Window.Maximize();
        driver.Navigate().GoToUrl("http://test.uapp.uk/");
        Thread.Sleep(5000); // Wait for the page to load
    }


    [OneTimeTearDown]
    public void baseTeardown()
    {
        if (driver != null)
        {
            //driver.Quit();
            driver.Dispose();
        }
    }
}
