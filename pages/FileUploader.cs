// using OpenQA.Selenium;
// using System;
// using System.IO;
// using OpenQA.Selenium.Support.UI;
// using SeleniumExtras.WaitHelpers;

// namespace sales_manager.pages;


// public class FileUploader
// {
//     private readonly IWebDriver driver;
//     private readonly Helperelement helper;

//     public FileUploader(IWebDriver driver)
//     {
//         this.driver = driver;
//         helper = new Helperelement(driver);
//     }

//     // Locators

//     // public void UploadFile(By fileInput, string filePath)
//     // {
//     //     helper.Type(fileInput, filePath);
//     //     helper.WaitForPageLoad();

//     // }

//     // public void UploadFile(By fileInput, string filePath)
//     // {
//     //     try
//     //     {
//     //         var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));

//     //         // Wait for file input to be present (not necessarily visible)
//     //         var input = wait.Until(ExpectedConditions.ElementExists(fileInput));

//     //         // If the element is hidden, make it visible via JS
//     //         ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].style.display='block';", input);

//     //         input.SendKeys(filePath);

//     //         Console.WriteLine("File uploaded successfully.");
//     //     }
//     //     catch (Exception e)
//     //     {
//     //         Console.WriteLine("File upload failed: " + e.Message);
//     //         throw;
//     //     }
//     // }
//     public void UploadFile(By fileLocator, string filePath)
//     {
//         helper.UploadFile(fileLocator, filePath);

//     }

// }