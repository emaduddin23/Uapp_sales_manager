using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using System.Threading;
using OpenQA.Selenium.Interactions;

namespace sales_manager.pages
{
    public class Helperelement
    {
        private readonly IWebDriver driver;
        private readonly WebDriverWait wait;

        public Helperelement(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
        }

        public void WaitForPageLoad()
        {
            System.Threading.Thread.Sleep(5000);
        }

        public void Click(By locator)
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(locator)).Click();
        }

        public void Type(By locator, string text)
        {
            var element = wait.Until(ExpectedConditions.ElementIsVisible(locator));
            // element.Clear();
            element.SendKeys(text);

        }
        public string GetText(By locator)
        {
            var element = wait.Until(ExpectedConditions.ElementIsVisible(locator));
            return element.Text;
        }
        public string GetAttributeValue(By locator, string attributeName)
        {
            var element = wait.Until(ExpectedConditions.ElementIsVisible(locator));
            return element.GetAttribute(attributeName);
        }
        // public void SelectCustomDropdown(By dropdownToggle, string optionText)
        // {
        //     // Click the dropdown to open it
        //     var toggle = wait.Until(ExpectedConditions.ElementToBeClickable(dropdownToggle));
        //     toggle.Click();

        //     // Build dynamic XPath for the visible option text
        //     var option = wait.Until(ExpectedConditions.ElementIsVisible(
        //         By.XPath($"//*[contains(text(),'{optionText}')]")));
        //     option.Click();
        // }
        // public void ScrollAndClick(By locator)
        // {
        //     var element = wait.Until(ExpectedConditions.ElementIsVisible(locator));
        //     ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", element);
        //     wait.Until(ExpectedConditions.ElementToBeClickable(locator)).Click();
        // }

        public void ScrollToElement(By locator)
        {
            var element = wait.Until(ExpectedConditions.ElementIsVisible(locator));
            Actions actions = new Actions(driver);
            actions.MoveToElement(element).Perform();
        }
        public void ScrollToElementjs(By locator)
        {
            var element = wait.Until(ExpectedConditions.ElementIsVisible(locator));
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].scrollIntoView({ behavior: 'auto', block: 'center' });", element);
        }

    }
}