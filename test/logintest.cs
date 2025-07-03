
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

    }




    [Test, Order(1), Description("Test to verify the dashboard widgets load correctly")]
    public void loginpageinfo()
    {
        ReportManager.test = ReportManager.extent.CreateTest("Dashboard page information");

        assertion = new HardAssertionHelper(ReportManager.test);
        //assertion = new SoftAssertionHelper(ReportManager.test);
        dashboard = new DashboardPage(driver, assertion);

        loginPage.userinfo();
        ReportManager.test.Info("Entered user info");

        loginPage.ClickLoginButton();
        ReportManager.test.Info("Clicked login");

        dashboard.dashboardinfo();
        ReportManager.test.Info("Dashboard information loaded");

        dashboard.VerifyDashboardHeader();
        ReportManager.test.Info("Verified dashboard header");
        
        dashboard.ScrollToDashboardContent();
        ReportManager.test.Info("Scrolled to dashboard content");

        // Optional: in HardAssertionHelper, AssertAll() does nothin

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