using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

using sales_manager.pages;
public class LoginPage
{
    private readonly IWebDriver driver;
    private readonly Helperelement helper;
    private readonly WebDriverWait wait;
    public LoginPage(IWebDriver driver)
    {
        //this.driver = driver;
        this.wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
        this.helper = new Helperelement(driver);
    }
    //locators
    private By EmailField => By.XPath("//input[@placeholder='Email Address']");
    private By Passwordfield => By.XPath("//input[@placeholder='Password']");
    private By LoginButton => By.XPath("//button[@type='submit']");

    public void userinfo()
    {
        helper.Type(EmailField, "diguzyp@mailinator.com");
        helper.WaitForPageLoad(); // Wait for the page to load after entering email
        helper.Type(Passwordfield, "a12345");
        helper.WaitForPageLoad(); // Wait for the page to load after entering password   
    }
    public void ClickLoginButton()
    {
        helper.Click(LoginButton);
        helper.WaitForPageLoad(); // Wait for the page to load after clicking login
    }

}