//using OpenQA.Selenium;
//using OpenQA.Selenium.Chrome;
//using OpenQA.Selenium.Firefox;
//using OpenQA.Selenium.Support.UI;

//public static class DriverFactory
//{
//    public static IWebDriver CreateDriver()
//    {
//        driver.Manage().Window.Maximize();
//        driver.Navigate().GoToUrl("http://test.uapp.uk/");
//        wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
//        return new FirefoxDriver(); // or ChromeDriver
//    }
//}
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using RazorEngine.Compilation.ImpromptuInterface.Dynamic;


public static class DriverFactory
{
    public static IWebDriver driver;
    public static WebDriverWait wait;

    public static IWebDriver CreateDriver()
    {

        //driver = new ChromeDriver(); // or new FirefoxDriver();
        driver = new FirefoxDriver(); // or new ChromeDriver();
        driver.Manage().Window.Maximize();
        driver.Navigate().GoToUrl("http://test.uapp.uk/");


        wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
        return driver;
    }

}