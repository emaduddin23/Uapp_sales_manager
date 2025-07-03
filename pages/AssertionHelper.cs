using NUnit.Framework; // Ensure you have NUnit installed
using System;
using AventStack.ExtentReports;
// or use xUnit/MSTest if you're using those

namespace sales_manager.pages
{

    public class AssertionHelper
    {
        public void AssertEquals(object actual, object expected, string message = "")
        {
            try
            {
                Assert.AreEqual(expected, actual, message);  // Try this assertion
            }
            catch (AssertionException ex)
            {
                Console.WriteLine("Assertion failed: " + ex.Message);  // Catch and log the failure
                throw;  // Optional: re-throw to mark test as failed
            }
        }
        public void AssertNotEquals(object actual, object expected, string message = "")
        {
            try
            {
                Assert.AreNotEqual(expected, actual, message);  // Try this assertion
            }
            catch (AssertionException ex)
            {
                Console.WriteLine("Assertion failed: " + ex.Message);  // Catch and log the failure
                throw;  // Optional: re-throw to mark test as failed
            }
        }

        public void AssertAndLogEquals(string actual, string expected, string fieldName)
        {
            try
            {
                AssertEquals(actual, expected, $"{fieldName} should match expected value.");
                Console.WriteLine($"✅ Assertion passed: {fieldName} matched.");

            }
            catch (AssertionException ex)
            {
                Console.WriteLine($"❌ Assertion failed: {ex.Message}");
                throw;  // Re-throw to ensure the test fails
            }
        }

        public void AssertTrue(bool condition, string message = "")
        {
            try
            {
                Assert.IsTrue(condition, message);  // Try to assert the condition is true
            }
            catch (AssertionException ex)
            {
                Console.WriteLine("Assertion failed: " + ex.Message);  // Log failure
                throw;  // Re-throw to ensure the test fails
            }
        }

        public void AssertFalse(bool condition, string message = "")
        {
            try
            {
                Assert.IsFalse(condition, message);  // Try to assert the condition is false
            }
            catch (AssertionException ex)
            {
                Console.WriteLine("Assertion failed: " + ex.Message);  // Log failure
                throw;  // Re-throw to ensure the test fails
            }
        }
        public void AssertContains(string actual, string expectedSubstring, string message = "")
        {
            try
            {
                Assert.IsTrue(actual.Contains(expectedSubstring), message);  // Check if actual contains expected substring
            }
            catch (AssertionException ex)
            {
                Console.WriteLine("Assertion failed: " + ex.Message);  // Log failure
                throw;  // Re-throw to ensure the test fails
            }
        }
        public void AssertNull(string actual, string message = "")
        {
            try
            {
                Assert.IsNull(actual, message);  // Check if actual is null
            }
            catch (AssertionException ex)
            {
                Console.WriteLine("Assertion failed: " + ex.Message);  // Log failure
                throw;  // Re-throw to ensure the test fails
            }
        }
        public void AssertNotNull(string actual, string message = "")
        {
            try
            {
                Assert.IsNotNull(actual, message);  // Check if actual is not null
            }
            catch (AssertionException ex)
            {
                Console.WriteLine("Assertion failed: " + ex.Message);  // Log failure
                throw;  // Re-throw to ensure the test fails
            }
        }

        // Add more custom assertions if needed
    }
}