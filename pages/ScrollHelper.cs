
using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.BiDi.Modules.BrowsingContext;


namespace sales_manager.pages
{
    public class ScrollHelper
    {
        private readonly IWebDriver driver;

        public ScrollHelper(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void ScrollBy(int x, int y)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            //js.ExecuteScript("document.body.style.overflowY = 'auto';");
            js.ExecuteScript($"window.scrollBy({x}, {y});");
        }
        public void highlight(By locator)
        {
            IWebElement element = driver.FindElement(locator);
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].style.border='2px solid red'; arguments[0].style.backgroundColor='yellow';", element);
            // System.Threading.Thread.Sleep(1000); // Pause for 1 second to see the highlight
            // js.ExecuteScript("arguments[0].style.backgroundColor = '';");
        }
        // {

        //     IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
        //      js.ExecuteScript("arguments[0].style.border='2px solid red'; arguments[0].style.backgroundColor='yellow';", element);
        //     // IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
        //     // js.ExecuteScript($"document.getElementById('{elementId}').style.backgroundColor = 'yellow';");
        //     // System.Threading.Thread.Sleep(1000); // Pause for 1 second to see the highlight
        //     // js.ExecuteScript($"document.getElementById('{elementId}').style.backgroundColor = '';");

        // }

        //  public void ScrollDownBy(int pixels)
        // {
        //     ScrollBy(0, pixels);
        // }
        public void ScrollFromOrigin(int xOffset, int yOffset, int deltaX, int deltaY)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript($"window.scrollTo({xOffset}, {yOffset});");
            ScrollBy(deltaX, deltaY);  // Additional scroll behavior based on deltaX and deltaY.
        }
        public void ScrollToBottom()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("document.body.style.overflowY = 'auto';");
            js.ExecuteScript("window.scrollTo(0, document.body.scrollHeight);");
        }


        public void ScrollToElement(By locator)
        {
            IWebElement element = driver.FindElement(locator);
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            //js.ExecuteScript("arguments[0].scrollIntoView(true);", element);
            js.ExecuteScript("arguments[0].scrollTop += 500;", element);
        }
    }
}