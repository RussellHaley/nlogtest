using NLog;
namespace Russell.Test.App;
    
public class LoggerTest
{
    private static ILogger _logger;// = LogManager.GetCurrentClassLogger();
    
    public LoggerTest()
    {
        LogManager.Setup().LoadConfigurationFromFile();
        _logger = LogManager.GetCurrentClassLogger();
    }
    public void Test(string message)
    {
        _logger.Info(message);
    }
}