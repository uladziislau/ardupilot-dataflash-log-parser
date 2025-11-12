using System.Reflection;
using UDIE.Adrupilot.Dataflash.Dynamic;
using Xunit;
using Xunit.Abstractions;

namespace UDIE.Adrupilot.Dataflash.Tests;

public class AutomaticAnalysisTests
{
    private readonly ITestOutputHelper _testOutputHelper;

    public AutomaticAnalysisTests(ITestOutputHelper testOutputHelper)
    {
        _testOutputHelper = testOutputHelper;
    }

    [Fact]
    public void CheckAvailableParametersForAnalysis()
    {
        // Arrange
        var directoryPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        Assert.NotNull(directoryPath);
        var filePath = Path.Combine(directoryPath, "Logs", "dataflash-sample-5.bin");
        using var file = File.OpenRead(filePath);
        var dataflash = Parser.ParseDataflash(file);

        // Act
        var parameters = dataflash.Messages["PARM"]
            .Select(p => p.Name)
            .ToList();
        
        // Output
        _testOutputHelper.WriteLine("Available parameters for analysis:");
        foreach (var parameter in parameters)
        {
            _testOutputHelper.WriteLine(parameter);
        }
        
        _testOutputHelper.WriteLine("Available Messages groups for analysis:");
        foreach (var kvp in dataflash.Messages)
        {
            var groupName = kvp.Key;
            var messageCount = kvp.Value.Count;
            _testOutputHelper.WriteLine($"{groupName}: {messageCount} messages");
        }
        
        // Assert
        Assert.Contains("THR_MIN", parameters);
        Assert.Contains("THR_MAX", parameters);
        Assert.Contains("WP_RADIUS", parameters);
        Assert.Contains("WP_MAX_RADIUS", parameters);
        Assert.Contains("WP_LOITER_RAD", parameters);
        Assert.Contains("FS_BATT_VOLTAGE", parameters);
    }
}