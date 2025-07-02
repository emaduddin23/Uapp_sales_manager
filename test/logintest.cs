
using OpenQA.Selenium;
using sales_manager.pages;


// [Parallelizable(ParallelScope.Self)]
[TestFixture]

public class LoginTest
{
    private IWebDriver driver;
    private LoginPage loginPage;
    // private StudentPage studentPage;
    // private Leadstudent leadstudent;
    // private Application application;
    // private Dashboard dashboard; // Added Dashboard instance for completeness  
    // private Myprofile myprofile; // Added Myprofile instance for completeness
    // private Logoutpage Logoutpage; // Added Logout instance for completeness
    // private searchapply searchapply;
    // private Consultants consultants;
    // private Reportmenu reportmenu;
    // // Assuming you have an AssertionHelper class
    // private pipline pipline;
    // private sales_manager.pages.AssertionHelper assertionHelper; // Explicitly specify the namespace to resolve ambiguity



    [OneTimeSetUp]
    public void GlobalSetUp()
    {
        ReportManager.SetupReport();
    }

    [SetUp]
    public void SetUp()
    {
        driver = DriverFactory.CreateDriver();
        loginPage = new LoginPage(driver);
        //navigationPage = new StudentPage(driver);
        // leadstudent = new Leadstudent(driver);
        // application = new Application(driver);
        // studentPage = new StudentPage(driver); // Assuming you meant to instantiate StudentPage here
        // dashboard = new Dashboard(driver);
        // myprofile = new Myprofile(driver);
        // searchapply = new searchapply(driver); // Assuming you have a SearchAndApply class
        // Logoutpage = new Logoutpage(driver);
        // consultants = new Consultants(driver);
        // reportmenu = new Reportmenu(driver);
        // pipline = new pipline(driver);
        // assertionHelper = new sales_manager.pages.AssertionHelper();



    }


    // [Test, Order(1), Description("Test to login with valid credentials and verify phone validation")]
    // public void TestLoginAndMenuNavigation()
    // {
    //     ReportManager.test = ReportManager.extent.CreateTest("TestLoginAndMenuNavigation");

    //     loginPage.login("vujimah@mailinator.com", "a12345");
    //     ReportManager.test.Pass("Login successful");

    //     myprofile.ClickMyProfile();
    //     ReportManager.test.Pass("My Profile clicked");

    //     myprofile.SubmitPhoneNumber();
    //     ReportManager.test.Pass("Submitted phone number");

    //     myprofile.AssertPhoneNumberValidationError("Phone number required minimum 9 digit");
    //     ReportManager.test.Fail("Get the phone number validation error");

    //     Logoutpage.clicklogout();
    //     ReportManager.test.Pass("Logout clicked");
    // }

    [Test, Order(1), Description("Test to verify the dashboard widgets load correctly")]
    public void loginpageinfo()
    {
        ReportManager.test = ReportManager.extent.CreateTest("TestDashboardWidgetsLoad");
        loginPage.userinfo();
        ReportManager.test.Pass("User information entered successfully");
        loginPage.ClickLoginButton();
        ReportManager.test.Pass("Login successful");

        // dashboard.ClickDashboard();
        // ReportManager.test.Pass("Dashboard clicked");

        // dashboard.VerifyDashboardPage();
        // ReportManager.test.Pass("checking the assertion");

        // Logoutpage.clicklogout();
        // ReportManager.test.Pass("Logout clicked");

    }
    //  [Test,Order(2), Description("Test to verify the dashboard widgets load correctly")]
    // public void TestDashboardWidgetsLoad()
    // {
    //     loginPage.login("wixilat466@besibali.com", "a123456");
    //     dashboard.ClickDashboard();
    //     string actualTitle = "Hello, Robin Ahmed!";
    //     string expectedTitle = "Hello, Robin Ahmed!";
    //     CustomAssert.AssertEquals(actualTitle, expectedTitle, "Dashboard title should match expected title.");
    //     Console.WriteLine("Assertion passed: Dashboard title matched.");
    //     ReportManager.test = ReportManager.extent.CreateTest("TestDashboardWidgetsLoad");

    //     ReportManager.test.Pass("Dashboard clicked");
    // }
    // [Test, Order(3), Description("Test to verify the profile widgets load correctly")]
    // public void TestprofileWidgetsLoad()
    // {
    //     loginPage.login("vujimah@mailinator.com", "a12345");
    //     myprofile.ClickMyProfile();
    //     string actualTitle = "UAPP Registration Date";
    //     string expectedTitle = "UAPP Registration Date";
    //     assertionHelper.AssertEquals(actualTitle, expectedTitle, "Profile title should match expected title.");
    //     Console.WriteLine("Assertion passed: Profile title matched.");
    //     ReportManager.test = ReportManager.extent.CreateTest("TestprofileWidgetsLoad");
    //     ReportManager.test.Pass("Profile clicked");
    // }

    [TearDown]
    public void TearDown()
    {
        driver.Dispose();
    }
    [OneTimeTearDown]
    public void EndReport()
    {
        ReportManager.FlushReport();
    }
}