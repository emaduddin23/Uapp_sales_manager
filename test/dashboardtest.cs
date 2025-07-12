
using OpenQA.Selenium;
using sales_manager.pages;


[Parallelizable(ParallelScope.Self)]
[TestFixture]
public class Dashboardtest : basetest
{


    private IWebDriver driver;
    private LoginPage loginPage;
    private DashboardPage dashboard;
    private IAssertionHelper assertion;
    private ScreenshotHelper screenshotHelper;


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
        dashboard = new DashboardPage(driver, assertion);
        assertion = new HardAssertionHelper(ReportManager.test);
        screenshotHelper = new ScreenshotHelper(driver);


    }
    //[Parallelizable(ParallelScope.Self)]
    [Test, Description("Test to verify the dashboard header and content")]

    public void dashboardinfo()
    {
        ReportManager.test = ReportManager.extent.CreateTest("Dashboard page information");
        try
        {
            loginPage.userinfo();
            ReportManager.test.Info("Entered user info");

            assertion = new HardAssertionHelper(ReportManager.test);
            //assertion = new SoftAssertionHelper(ReportManager.test);
            dashboard = new DashboardPage(driver, assertion);


            loginPage.ClickLoginButton();
            ReportManager.test.Info("Clicked login");

            dashboard.dashboardinfo();
            ReportManager.test.Info("Dashboard information loaded");

            dashboard.VerifyDashboardHeader();
            ReportManager.test.Info("Verified dashboard header");


            dashboard.ScrollToDashboardContent();
            ReportManager.test.Info("Scrolled to dashboard content");
            // Additional checks can be added here
        }
        catch (Exception e)
        {
            screenshotHelper.TakeScreenshotWithHighlight("Login_Error", dashboard.DashboardContent);
            ReportManager.test.Fail("An error occurred: " + e.Message);
            throw; // Re-throw the exception to fail the test
        }

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



