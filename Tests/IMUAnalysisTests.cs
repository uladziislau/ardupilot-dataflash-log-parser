using System.Reflection;
using UDIE.Adrupilot.Dataflash.Dynamic;
using Xunit;

namespace UDIE.Adrupilot.Dataflash.Tests;

public class IMUAnalysisTests
{
    [Fact]
    public void AnalyzeAccelerationData()
    {
        // Arrange
        var directoryPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        Assert.NotNull(directoryPath);
        var filePath = Path.Combine(directoryPath, "Logs", "dataflash-sample-5.bin");
        using var file = File.OpenRead(filePath);
        var dataflash = Parser.ParseDataflash(file);

        // Act
        var imuData = dataflash.Messages["IMU"];

        // Assert
        Assert.NotNull(imuData);
        Assert.NotEmpty(imuData);

        // Extract acceleration data
        var accX = imuData.Select(imu => imu.AccX).ToArray();
        var accY = imuData.Select(imu => imu.AccY).ToArray();
        var accZ = imuData.Select(imu => imu.AccZ).ToArray();

        // Calculate mean and standard deviation using MathNet.Numerics
        var accXMean = accX.Mean();
        var accYMean = accY.Mean();
        var accZMean = accZ.Mean();

        var accXStdDev = accX.StandardDeviation();
        var accYStdDev = accY.StandardDeviation();
        var accZStdDev = accZ.StandardDeviation();

        // Assert or log the results
        Console.WriteLine($"AccX Mean: {accXMean}, StdDev: {accXStdDev}");
        Console.WriteLine($"AccY Mean: {accYMean}, StdDev: {accYStdDev}");
        Console.WriteLine($"AccZ Mean: {accZMean}, StdDev: {accZStdDev}");

        // Add your assertions here
    }
}