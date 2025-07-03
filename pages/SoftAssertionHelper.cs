using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using AventStack.ExtentReports;

namespace sales_manager.pages
{

    public class SoftAssertionHelper : IAssertionHelper
    {
        private readonly ExtentTest test;
        private StringBuilder errorMessages = new StringBuilder();

        public SoftAssertionHelper(ExtentTest test)
        {
            this.test = test;
        }

        public void AssertEquals(object actual, object expected, string message = "")
        {
            try
            {
                Assert.AreEqual(expected, actual, message);
                test.Pass("✅ " + message);
                Console.WriteLine("✅ Passed: " + message);
            }
            catch (AssertionException ex)
            {
                string error = "❌ " + message + " | " + ex.Message;
                test.Fail("❌ " + message + " | " + ex.Message);
                Console.WriteLine(error);
                errorMessages.AppendLine(error);
            }
        }

        public void AssertTrue(bool condition, string message = "")
        {
            try
            {
                Assert.IsTrue(condition, message);
                test.Pass("✅ " + message);
                Console.WriteLine("✅ Passed: " + message);
            }
            catch (AssertionException ex)
            {
                string error = "❌ " + message + " | " + ex.Message;
                test.Fail("❌ " + message + " | " + ex.Message);
                Console.WriteLine(error);
                errorMessages.AppendLine(error);
            }
        }

        public void AssertAll()
        {
            if (errorMessages.Length > 0)
            {
                string allErrors = string.Join("\n", errorMessages);
                test.Fail("Soft assertion failures:\n" + allErrors);
                errorMessages.Clear();
                Assert.Fail("Soft assertion failures:\n" + allErrors);
            }
            else
            {
                test.Pass("✅ All soft assertions passed.");
                Console.WriteLine("✅ All soft assertions passed.");
            }
        }

        public void AssertNotEquals(object actual, object expected, string message = "")
        {
            throw new NotImplementedException();
        }

        public void AssertFalse(bool condition, string message = "")
        {
            throw new NotImplementedException();
        }

        public void AssertNull(object obj, string message = "")
        {
            throw new NotImplementedException();
        }

        public void AssertNotNull(object obj, string message = "")
        {
            throw new NotImplementedException();
        }

        public void AssertContains(string actual, string expectedSubstring, string message = "")
        {
            throw new NotImplementedException();
        }
       
    }
}
