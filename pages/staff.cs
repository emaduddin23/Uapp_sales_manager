using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

using sales_manager.pages;
public class Staff
{
    private readonly IWebDriver driver;
    private readonly Helperelement helper;
    private readonly WebDriverWait wait;
    public Staff(IWebDriver driver)
    {
        this.driver = driver;
        this.wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
        this.helper = new Helperelement(driver);
    }
    //locators
    private By staffmenu => By.XPath("//span[normalize-space()='Staff']");
    private By tapsalesteam => By.XPath("//span[normalize-space()='Sales Team Leader']");
    private By tapstaffinfo => By.CssSelector(".btn-group > button:nth-child(1)");
    private By staffinfoback => By.XPath("//span[@class='text-white']");


    public void ClickStaffMenu()
    {
        helper.Click(staffmenu);
        helper.WaitForPageLoad(); // Wait for the page to load after clicking staff menu   
        helper.Click(tapsalesteam);
        helper.WaitForPageLoad(); // Wait for the page to load after clicking sales team
        helper.Click(tapstaffinfo);
        helper.WaitForPageLoad(); // Wait for the page to load after clicking staff info
        helper.Click(staffinfoback);
        helper.WaitForPageLoad(); // Wait for the page to load after clicking back from staff
    }


}