using System.Reflection;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Diagnosers;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Running;
using UDIE.Adrupilot.Dataflash.Dynamic;
using Xunit;
using Xunit.Abstractions;

namespace UDIE.Adrupilot.Dataflash.Tests;

public class DataflashParserTests
{
    private readonly ITestOutputHelper _testOutputHelper;

    public DataflashParserTests(ITestOutputHelper testOutputHelper)
    {
        _testOutputHelper = testOutputHelper;
    }

    [Fact]
    public void Benchmark()
    {
        BenchmarkRunner.Run<DataflashParserTests>(
            ManualConfig.Create(DefaultConfig.Instance)
                .AddJob(Job.Default.WithGcServer(true).WithGcConcurrent(true))
                .AddDiagnoser(MemoryDiagnoser.Default));
    }
    
    [Fact]
    [Benchmark]
    public void GetUuid()
    {
        var directoryPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        Assert.NotNull(directoryPath);
        var filePath = Path.Combine(directoryPath, "Logs", "dataflash-sample-1.bin");
        using var file = File.OpenRead(filePath);
        var dataflash = Parser.ParseDataflash(file);
        var uuid = Extractor.ExtractUuid(dataflash.Messages["MSG"]);
        Assert.Equal("003100193138510E35363631", uuid);
    }
    
    [Fact]
    public void CalculationHelpersTests()
    {
        var directoryPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        Assert.NotNull(directoryPath);
        var filePath = Path.Combine(directoryPath, "Logs", "dataflash-sample-5.bin");
        using var file = File.OpenRead(filePath);
        var dataflash = Parser.ParseDataflash(file);
            
        var passedFlightDistance = Extractor.ExtractGpsPassedFlightDistance(dataflash.Messages["GPS"]);
        var maxDistanceFromStartPoint = Extractor.ExtractMaxDistanceFromStartPoint(dataflash.Messages["GPS"]);
        var totalClimb = Extractor.ExtractTotalClimb(Extractor.ExtractAltitudesFromGps(dataflash.Messages["GPS"]));
            
        Assert.NotEqual(0, passedFlightDistance);
        Assert.NotEqual(0, maxDistanceFromStartPoint);
        Assert.NotEqual(0, totalClimb);

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

        // Assert
        Assert.Contains("THR_MIN", parameters);
        Assert.Contains("THR_MAX", parameters);
        Assert.Contains("YAW_MAX", parameters);
        Assert.Contains("STABILIZE_D", parameters);
        Assert.Contains("WP_RADIUS", parameters);
        Assert.Contains("WP_MAX_RADIUS", parameters);
        Assert.Contains("WP_LOITER_RAD", parameters);
        Assert.Contains("FS_BATT_VOLTAGE", parameters);
        Assert.Contains("ALT", parameters);
        Assert.Contains("GPS_HDOP", parameters);
        Assert.Contains("SYS_STATUS", parameters);
        Assert.Contains("GPS_STATUS", parameters);
    }
}