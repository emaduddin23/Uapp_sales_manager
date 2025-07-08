using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using OpenQA.Selenium;

public class ScreenshotHelper
{
    private IWebDriver driver;

    public ScreenshotHelper(IWebDriver driver)
    {
        this.driver = driver;
    }

    // Standard screenshot method (no highlight)
    public void TakeScreenshot(string fileName)
    {
        try
        {
            var screenshot = ((ITakesScreenshot)driver).GetScreenshot();
            string folder = @"D:\Uapp_sales_manager\pages\screenshots";

            if (!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);
            }

            string filePath = Path.Combine(folder, fileName + "_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".png");

            byte[] screenshotBytes = Convert.FromBase64String(screenshot.AsBase64EncodedString);
            File.WriteAllBytes(filePath, screenshotBytes);

            Console.WriteLine("Screenshot saved: " + filePath);
        }
        catch (Exception e)
        {
            Console.WriteLine("Error taking screenshot: " + e.Message);
        }
    }

    // Screenshot with red rectangle highlight
    public void TakeScreenshotWithHighlight(string fileName, By locator)
    {
        try
        {
            var screenshot = ((ITakesScreenshot)driver).GetScreenshot();
            byte[] screenshotBytes = Convert.FromBase64String(screenshot.AsBase64EncodedString);

            string folder = @"D:\Uapp_sales_manager\pages\screenshots";

            if (!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);
            }

            string filePath = Path.Combine(folder, fileName + "_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".png");

            using (MemoryStream ms = new MemoryStream(screenshotBytes))
            using (Bitmap bitmap = new Bitmap(ms))
            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                IWebElement element = driver.FindElement(locator);
                var location = element.Location;
                var size = element.Size;

                // Draw red rectangle
                using (Pen pen = new Pen(Color.Red, 3))
                {
                    graphics.DrawRectangle(pen, new Rectangle(location, size));
                }

                // Optional label above the element
                using (Font font = new Font("Arial", 12))
                using (Brush brush = new SolidBrush(Color.Red))
                {
                    graphics.DrawString("Failed Here", font, brush, location.X, location.Y - 20);
                }

                bitmap.Save(filePath, ImageFormat.Png);
            }

            Console.WriteLine("Screenshot with highlight saved: " + filePath);
        }
        catch (Exception e)
        {
            Console.WriteLine("Error taking screenshot with highlight: " + e.Message);
        }
    }
}
