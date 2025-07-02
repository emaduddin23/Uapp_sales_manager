using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using System.Threading;

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

    }
}