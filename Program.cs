using Russell.Test.App;
using Microsoft.Extensions.Configuration;
using NLog;

var config = new ConfigurationBuilder()
    .SetBasePath(Directory.GetCurrentDirectory()) // Ensure to set the correct application base path
    .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
    .Build();


string azureBlobConnectionString = config.GetConnectionString("AzureBlob");
Console.WriteLine($"AzureBlob connection string: {azureBlobConnectionString}");

string testVar = config["MySection:MyVar"];
Console.WriteLine($"MyVar: {testVar}");

LoggerTest loggerTest = new();
loggerTest.Test("one");
loggerTest.Test("two");
loggerTest.Test("three");

Console.WriteLine("Done.");
NLog.LogManager.Shutdown();