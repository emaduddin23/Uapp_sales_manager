using OpenQA.Selenium;
using System;
using System.IO;
using OpenQA.Selenium.Support.UI;

namespace sales_manager.pages;

 
    public class FileUploader
{
    private readonly IWebDriver driver;
    private readonly Helperelement helper;

    public FileUploader(IWebDriver driver)
    {
        this.driver = driver;
        helper = new Helperelement(driver);
    }

    // Locators

    public void UploadFile(By fileInput, string filePath)
    {
        helper.Type(fileInput, filePath);

    }
}