using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace sales_manager.pages
{
    public class DashboardPage
    {
        private readonly IWebDriver driver;

        private readonly ScrollHelper scrollHelper;
        private readonly Helperelement helper;
        private readonly IAssertionHelper assertion;
        public DashboardPage(IWebDriver driver, IAssertionHelper assertionHelper)
        {
            this.driver = driver;
            helper = new Helperelement(driver);
            scrollHelper = new ScrollHelper(driver);
            this.assertion = assertionHelper;

        }

        // Locators
        private By DashboardHeader => By.CssSelector(".nav-item.uapp-nav-item.active");
        public By DashboardContent => By.XPath("//span[normalize-space()='Hello, Jessica Rosario!']");
        public void dashboardinfo()
        {
            helper.Click(DashboardHeader);
            helper.WaitForPageLoad(); // Wait for the page to load after clicking the dashboard header  
                                      // Wait for the page to load after scrolling
        }
        public void VerifyDashboardHeader()
        {

            {
                string expectedHeader = "Hello, Jessica Rosari!";
                string actualHeader = helper.GetText(DashboardContent);

                assertion.AssertEquals(actualHeader, expectedHeader, "Dashboard header should be matched");
                // Additional checks can be added here
                // For example, checking if the dashboard contains specific elements or data
                // softAssertionHelper.AssertTrue(helper.IsElementPresent(By.CssSelector(".some-dashboard-element")), "Dashboard should contain specific element");
            }

        }

        public void ScrollToDashboardContent()
        {
            scrollHelper.ScrollBy(0, 2000); // Scroll to the bottom of the page
            helper.WaitForPageLoad();
            // Wait for the page to load after scrolling
        }
    }
}