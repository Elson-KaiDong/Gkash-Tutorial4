using Serilog;
namespace T4_WebApi
{
    public static class Logger
    {
        private static readonly ILogger _log;

        static Logger()
        {
            var logPath = System.Web.Hosting.HostingEnvironment.MapPath("~/Logs/log.txt");

            _log = new LoggerConfiguration()
                    .WriteTo.File(logPath, rollingInterval: RollingInterval.Day)
                    .CreateLogger();
        }

        public static void LogInfo(string info)
        {
            _log.Information(info);
        }
    }
}