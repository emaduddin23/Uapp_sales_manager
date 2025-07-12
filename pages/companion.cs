using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

using sales_manager.pages;
public class companion
{
    private readonly IWebDriver driver;
    private readonly Helperelement helper;
    private readonly WebDriverWait wait;
    private readonly ScrollHelper scrollHelper;
    public companion(IWebDriver driver)
    {
        this.driver = driver;
        this.wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
        this.helper = new Helperelement(driver);
        this.scrollHelper = new ScrollHelper(driver);
    }
    //locators

    private By tapcommenu => By.XPath("//span[normalize-space()='Companions']");
    private By tapcommarket => By.XPath("//span[normalize-space()='Companion Marketers']");
    private By tapstatus => By.CssSelector("#consultantTypeId > .css-13cymwt-control");
    private By tapstatusoption => By.XPath("//div[contains(text(),'New Account')]");

    private By enternamesearch => By.XPath("//input[@placeholder='Name, Email']");

    private By enteruserinfo => By.CssSelector(".btn-group > button:nth-child(1)");
    private By tapupperbutton => By.XPath("//button[@class ='btn-icon scroll-top btn btn-primary']"); // Assuming this is the correct locator for the upper button
    private By backinfo => By.XPath("//span[normalize-space()='Back']");


    public void ClickcompMenu()
    {
        helper.Click(tapcommenu);
        helper.WaitForPageLoad(); // Wait for the page to load after clicking companion menu
        helper.Click(tapcommarket);
        helper.WaitForPageLoad(); // Wait for the page to load after clicking companion marketers
        helper.Click(tapstatus);
        helper.WaitForPageLoad(); // Wait for the page to load after clicking staff menu   
        helper.Click(tapstatusoption);
        helper.WaitForPageLoad(); // Wait for the page to load after clicking sales team
        helper.Type(enternamesearch, "Nomlanga Kim");
        helper.WaitForPageLoad(); // Wait for the page to load after entering name search
        helper.Click(enteruserinfo);
        helper.WaitForPageLoad(); // Wait for the page to load after clicking user info
        scrollHelper.ScrollBy(0, 500); // Scroll down to view the user info 
        helper.WaitForPageLoad(); // Wait for the page to load after scrolling
        helper.Click(tapupperbutton);
        helper.WaitForPageLoad(); // Wait for the page to load after clicking the upper button
        helper.Click(backinfo);
        helper.WaitForPageLoad(); // Wait for the page to load after clicking back info



    }


}