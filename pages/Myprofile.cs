
using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V134.Network;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace sales_manager.pages
{
    public class Myprofile
    {
        private readonly IWebDriver driver;
        private readonly Helperelement helper;
        public ScrollHelper scrollHelper;
        private readonly FileUploader fileUploader;


        public Myprofile(IWebDriver driver)
        {
            this.driver = driver;
            helper = new Helperelement(driver);
            scrollHelper = new ScrollHelper(driver);
            fileUploader = new FileUploader(driver);

        }
        // Locators
        private By myprofileLink => By.XPath("//span[normalize-space()='My Profile']");
        private By editprofileLink => By.CssSelector(".img-fluid");
        private By savenext => By.XPath("//button[normalize-space()='Save and Next']");
        //private By dateofbirth => By.ClassName("ant-picker ant-picker-focused");

        //private By selectcountry => By.ClassName("selected-flag open");
        private By phonenumber => By.XPath("//input[@placeholder='1 (702) 123-4567']");

        private By phoneNumberInput => By.XPath("//span[normalize-space()='Phone number required minimum 9 digit']"); // Assuming this is the correct locator for the phone number input
        private By savenext2 => By.XPath("//button[normalize-space()='Save and Next']");
        private By changecountry => By.CssSelector(".css-b62m3t-container > .css-13cymwt-control");

        private By changeCountryDropdown => By.XPath("//div[@class='css-1dimb5e-singleValue' and text()='Australia']"); // Assuming this is the correct locator for the country dropdown

        private By savenext3 => By.XPath("//button[normalize-space()='Save and Next']");

        private By changeCountryInput => By.CssSelector("#countryId > .css-13cymwt-control"); // Assuming this is the correct locator for the country input
        // private By backbutton => By.XPath("//span[normalize-space()='Back']");
        private By changecountrydrop => By.XPath("//div[contains(text(),'Algeria')]"); // Assuming this is the correct locator for the change country dropdown

        private By savenext4 => By.XPath("//button[normalize-space()='Save and Next']");
        private By myfileinput => By.XPath("//label[@for='inputImgId/Passport']//span[@type='button'][normalize-space()='Upload']");
        public void ClickMyProfile()
        {
            helper.Click(myprofileLink);
            helper.WaitForPageLoad();
            helper.Click(editprofileLink);
            helper.WaitForPageLoad();
            helper.Click(savenext);
            helper.WaitForPageLoad();
            helper.Click(savenext2);
            helper.WaitForPageLoad();
        }

        public void contactinfo()
        {
            helper.Click(changecountry);
            helper.WaitForPageLoad();
            helper.ScrollAndClick(changeCountryDropdown);
            helper.WaitForPageLoad();
            // helper.SelectCustomDropdown(changeCountryDropdown, "Australia");
            helper.WaitForPageLoad();
            // helper.Click(changecountry);
            // helper.WaitForPageLoad();

            // helper.Click(changeCountryDropdown);
            // helper.WaitForPageLoad();

            helper.Click(savenext3);
            helper.WaitForPageLoad();

            // helper.Click(changeCountryInput);
            // helper.WaitForPageLoad();
            // helper.Click(changecountrydrop);
            // helper.WaitForPageLoad();
            // helper.Click(savenext4);
            // helper.WaitForPageLoad();

        }

        public void UploadFile(string filePath)
        {
            helper.Click(myfileinput);
            helper.WaitForPageLoad();
            fileUploader.UploadFile(myfileinput, filePath);
            helper.WaitForPageLoad();
        }


        // public void SubmitPhoneNumber()
        // {
        //     helper.Type(phonenumber, "456789");
        //     helper.WaitForPageLoad();
        //     // helper.GetText(phoneNumberInput);
        //     // helper.WaitForPageLoad();
        //     // Scroll down to the bottom of the page
        //     // scrollHelper.ScrollBy(0, 3000);
        //     // helper.WaitForPageLoad();
        //     // helper.Click(savenext2);
        //     // helper.WaitForPageLoad();
        // }


        // public void verifyDateOfBirth(string expectedDate)
        // {
        //     // string actualDate = helper.GetAttributeValue(dateofbirth, "value");
        //     // assertionHelper.AssertAndLogEquals(actualDate, expectedDate, "Date of Birth");

        //     string actualDate = helper.GetAttributeValue(savenext2, "value");
        //     assertionHelper.AssertFalse(actualDate, expectedDate, "save and next button value");
        // }
        // public string GetPhoneNumberValidationErrorMessage()
        // {
        //     return helper.GetText(phoneNumberInput);
        // }

        public void AssertPhoneNumberValidationError(string expectedMessage)
        {
            string actualMessage = helper.GetText(phoneNumberInput);

            helper.Click(savenext2);
            helper.WaitForPageLoad();
        }
        // public void VerifySomethingIsFalse(bool condition)
        // {
        //     assertionHelper.AssertFalse(condition, "The condition should be false.");
        // }

    }
}