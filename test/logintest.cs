
using OpenQA.Selenium;
using sales_manager.pages;


// [Parallelizable(ParallelScope.Self)]
[TestFixture]

public class LoginTest
{
    private IWebDriver driver;
    private LoginPage loginPage;
    private DashboardPage dashboard;
    private IAssertionHelper assertion;
    private Myprofile myprofile;


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
        myprofile = new Myprofile(driver);


    }

    // [Test, Order(1), Description("Test to verify the dashboard widgets load correctly")]
    // public void loginpageinfo()
    // {
    //     ReportManager.test = ReportManager.extent.CreateTest("Dashboard page information");

    //     //assertion = new HardAssertionHelper(ReportManager.test);
    //     assertion = new SoftAssertionHelper(ReportManager.test);
    //     dashboard = new DashboardPage(driver, assertion);

    //     loginPage.userinfo();
    //     ReportManager.test.Info("Entered user info");

    //     loginPage.ClickLoginButton();
    //     ReportManager.test.Info("Clicked login");

    //     dashboard.dashboardinfo();
    //     ReportManager.test.Info("Dashboard information loaded");

    //     dashboard.VerifyDashboardHeader();
    //     ReportManager.test.Info("Verified dashboard header");

    //     dashboard.ScrollToDashboardContent();
    //     ReportManager.test.Info("Scrolled to dashboard content");

    //     // Optional: in HardAssertionHelper, AssertAll() does nothin

    // }
    [Test, Order(2), Description("Test to verify the My Profile page functionality")]
    public void myprofileinfo()
    {
        ReportManager.test = ReportManager.extent.CreateTest("My Profile Menu Information");
        loginPage.userinfo();
        ReportManager.test.Info("Entered user info");
        // Myprofile myprofile = new Myprofile(driver, assertion);

        loginPage.ClickLoginButton();
        ReportManager.test.Info("Clicked login");

        myprofile.ClickMyProfile();
        ReportManager.test.Info("Clicked on My Profile");

        myprofile.contactinfo();
        ReportManager.test.Info("Clicked on Contact Info");

        myprofile.UploadFile("D:\\Uapp_sales_manager\test\\profile.png");
        ReportManager.test.Info("Uploaded profile picture");

        // Optional: in HardAssertionHelper, AssertAll() does nothing
    }

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