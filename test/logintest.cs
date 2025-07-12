
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using sales_manager.pages;


[Parallelizable(ParallelScope.Self)]
[TestFixture]
public class LoginTest
{
    private IWebDriver driver;
    private LoginPage loginPage;
    //private DashboardPage dashboard;
    private IAssertionHelper assertion;
    private Myprofile myprofile;
    private ScreenshotHelper screenshotHelper;
    private Staff staff;
    private companion companion;

    // private ThreadLocal<IWebDriver> _driver = new(() =>

    //     new ChromeDriver() // or new FirefoxDriver()
    // );

    // public IWebDriver driver => _driver.Value;



    [OneTimeSetUp]
    public void GlobalSetUp()
    {
        ReportManager.SetupReport();
    }
    [SetUp]
    public void SetUp()
    {
        //driver = DriverFactory.CreateDriver();
        loginPage = new LoginPage(driver);
        myprofile = new Myprofile(driver);
        screenshotHelper = new ScreenshotHelper(driver);
        staff = new Staff(driver);
        companion = new companion(driver);


    }

    // [Test, Order(1), Description("Test to verify the dashboard widgets load correctly")]
    // public void loginpageinfo()
    // {
    //     ReportManager.test = ReportManager.extent.CreateTest("Dashboard page information");
    //     try
    //     {

    //         assertion = new HardAssertionHelper(ReportManager.test);
    //         //assertion = new SoftAssertionHelper(ReportManager.test);
    //         dashboard = new DashboardPage(driver, assertion);

    //         loginPage.userinfo();
    //         ReportManager.test.Info("Entered user info");

    //         loginPage.ClickLoginButton();
    //         ReportManager.test.Info("Clicked login");

    //         dashboard.dashboardinfo();
    //         ReportManager.test.Info("Dashboard information loaded");

    //         dashboard.VerifyDashboardHeader();
    //         ReportManager.test.Info("Verified dashboard header");


    //         dashboard.ScrollToDashboardContent();
    //         ReportManager.test.Info("Scrolled to dashboard content");
    //         ReportManager.test.Pass("Dashboard widgets loaded successfully");
    //     }
    //     catch (Exception e)
    //     {
    //         screenshotHelper.TakeScreenshotWithHighlight("Login_Error", dashboard.DashboardContent);
    //         ReportManager.test.Fail("An error occurred: " + e.Message);
    //         throw; // Re-throw the exception to fail the test
    //     }

    //     // Optional: in HardAssertionHelper, AssertAll() does nothin

    // }

    [Test, Description("Test to verify the My Profile page functionality")]
    public void myprofileinfo()
    {
        //ReportManager.test = ReportManager.extent.CreateTest("My Profile Menu Information");
        try
        {
            loginPage.userinfo();
            // ReportManager.test.Info("Entered user info");

            loginPage.ClickLoginButton();
            // ReportManager.test.Info("Clicked login");

            //companion.ClickcompMenu();
            //ReportManager.test.Info("Clicked on companion menu");

            myprofile.ClickMyProfile();
            ReportManager.test.Info("Clicked on My Profile");

            // // myprofile.contactinfo();
            // // ReportManager.test.Info("Clicked on Contact Info");

            // myprofile.UploadFile();
            // ReportManager.test.Info("Uploaded profile picture");
            // myprofile.tapimage();
            // ReportManager.test.Info("Tapped on the profile image");
            // staff.ClickStaffMenu();
            // ReportManager.test.Info("Clicked on Staff Menu");


        }
        catch (Exception e)
        {

            screenshotHelper.TakeScreenshot("MyProfile_Error");
            ReportManager.test.Fail("An error occurred: " + e.Message);
            throw; // Re-throw the exception to fail the test
        }

        // myprofile.UploadFile("D:\\Uapp_sales_manager\test\\profile.png");
        // ReportManager.test.Info("Uploaded profile picture");

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