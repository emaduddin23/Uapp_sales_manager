using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;

namespace sales_manager.pages
{
    public static class ReportManager
    {
        public static ExtentReports extent;
        public static ExtentTest test;

        public static void SetupReport()
        {
            var spark = new ExtentSparkReporter("LoginReport.html");
            extent = new ExtentReports();
            extent.AttachReporter(spark);
        }

        public static void FlushReport()
        {
            extent.Flush();
        }
    }
}