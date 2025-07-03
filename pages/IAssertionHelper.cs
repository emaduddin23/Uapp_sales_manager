namespace sales_manager.pages
{
    public interface IAssertionHelper
    {
        void AssertEquals(object actual, object expected, string message = "");
        void AssertNotEquals(object actual, object expected, string message = "");
        void AssertTrue(bool condition, string message = "");
        void AssertFalse(bool condition, string message = "");
        void AssertNull(object obj, string message = "");
        void AssertNotNull(object obj, string message = "");
        void AssertContains(string actual, string expectedSubstring, string message = "");
        void AssertAll(); // Will do nothing for hard assertions
    }
}
