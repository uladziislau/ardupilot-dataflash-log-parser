using System.Runtime.InteropServices;

namespace UDIE.Adrupilot.Dataflash.Structure.Formats.Sensors;

/// <summary>
/// The ACC1 structure is used to record accelerometer sensor data.
/// Структура ACC1 используется для записи данных акселерометра.
/// </summary>

/// <remarks>
/// FMT, 178, 31, ACC3, QQfff, TimeUS,SampleUS,AccX,AccY,AccZ
/// </remarks>

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct ACC3
{
    /// <summary>
    /// Time in microseconds when the data was obtained.
    /// Время в микросекундах, когда были получены данные.
    /// </summary>
    public ulong TimeUS { get; set; }

    /// <summary>
    /// Time in microseconds since last sensor sample.
    /// Время в микросекундах с момента последнего считывания данных сенсора.
    /// </summary>
    public ulong SampleUS { get; set; }

    /// <summary>
    /// Acceleration along the X-axis in meters per second squared (m/s^2).
    /// Ускорение вдоль оси X в метрах в секунду в квадрате (м/с^2).
    /// </summary>
    public float AccX { get; set; }

    /// <summary>
    /// Acceleration along the Y-axis in meters per second squared (m/s^2).
    /// Ускорение вдоль оси Y в метрах в секунду в квадрате (м/с^2).
    /// </summary>
    public float AccY { get; set; }

    /// <summary>
    /// Acceleration along the Z-axis in meters per second squared (m/s^2).
    /// Ускорение вдоль оси Z в метрах в секунду в квадрате (м/с^2).
    /// </summary>
    public float AccZ { get; set; }
}