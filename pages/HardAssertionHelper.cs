using NUnit.Framework;
using System;
using AventStack.ExtentReports;
namespace sales_manager.pages;



    public class HardAssertionHelper: IAssertionHelper
{
    private readonly ExtentTest test;
    public HardAssertionHelper(ExtentTest extentTest)
    {
        test = extentTest;
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
            test.Fail("❌ " + message + " | " + ex.Message);
            Console.WriteLine("❌ Failed: " + ex.Message);
            throw;
        }
    }

    public void AssertNotEquals(object actual, object expected, string message = "")
    {
        try
        {
            Assert.AreNotEqual(expected, actual, message);
            test.Pass("✅ " + message);
            Console.WriteLine("✅ Passed: " + message);
        }
        catch (AssertionException ex)
        {
            test.Fail("❌ " + message + " | " + ex.Message);
            Console.WriteLine("❌ Failed: " + ex.Message);
            throw;
        }
    }

    public void AssertTrue(bool condition, string message = "")
    {
        try
        {
            test.Pass("✅ " + message);
            Assert.IsTrue(condition, message);
            Console.WriteLine("✅ Passed: " + message);
        }
        catch (AssertionException ex)
        {
            Console.WriteLine("❌ Failed: " + ex.Message);
            test.Fail("❌ " + message + " | " + ex.Message);
            throw;
        }
    }

    public void AssertFalse(bool condition, string message = "")
    {
        try
        {
            Assert.IsFalse(condition, message);
            test.Pass("✅ " + message);
            Console.WriteLine("✅ Passed: " + message);
        }
        catch (AssertionException ex)
        {
            test.Fail("❌ " + message + " | " + ex.Message);
            Console.WriteLine("❌ Failed: " + ex.Message);
            throw;
        }
    }

    public void AssertNull(object obj, string message = "")
    {
        try
        {
            Assert.IsNull(obj, message);
            test.Pass("✅ " + message);
            Console.WriteLine("✅ Passed: " + message);
        }
        catch (AssertionException ex)
        {
            test.Fail("❌ " + message + " | " + ex.Message);
            Console.WriteLine("❌ Failed: " + ex.Message);
            throw;
        }
    }

    public void AssertNotNull(object obj, string message = "")
    {
        try
        {
            Assert.IsNotNull(obj, message);
            test.Pass("✅ " + message);
            Console.WriteLine("✅ Passed: " + message);
        }
        catch (AssertionException ex)
        {
            test.Fail("❌ " + message + " | " + ex.Message);
            Console.WriteLine("❌ Failed: " + ex.Message);
            throw;
        }
    }

    public void AssertContains(string actual, string expectedSubstring, string message = "")
    {
        try
        {
            Assert.IsTrue(actual.Contains(expectedSubstring), message);
            test.Pass("✅ " + message);
            Console.WriteLine("✅ Passed: " + message);
        }
        catch (AssertionException ex)
        {
            test.Fail("❌ " + message + " | " + ex.Message);
            Console.WriteLine("❌ Failed: " + ex.Message);
            throw;
        }
    }

    public void AssertAll()
    {
        throw new NotImplementedException();
    }
}

