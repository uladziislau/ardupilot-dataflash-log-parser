using System.Runtime.InteropServices;

namespace UDIE.Adrupilot.Dataflash.Structure.Formats.Sensors;

/// <summary>
/// Structure MAG is designed to record magnetometer data.
/// Структура MAG предназначена для записи данных о магнитометре.
/// </summary>

/// <remarks>
/// FMT, 168, 34, MAG, QhhhhhhhhhBI, TimeUS,MagX,MagY,MagZ,OfsX,OfsY,OfsZ,MOfsX,MOfsY,MOfsZ,Health,S
/// </remarks>

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct MAG
{
    /// <summary>
    /// Time in microseconds when the data was received.
    /// Время в микросекундах, когда данные были получены.
    /// </summary>
    public ulong TimeUS { get; set; }

    /// <summary>
    /// Magnetic field strength along the X-axis.
    /// Сила магнитного поля вдоль оси X.
    /// </summary>
    public short MagX { get; set; }

    /// <summary>
    /// Magnetic field strength along the Y-axis.
    /// Сила магнитного поля вдоль оси Y.
    /// </summary>
    public short MagY { get; set; }

    /// <summary>
    /// Magnetic field strength along the Z-axis.
    /// Сила магнитного поля вдоль оси Z.
    /// </summary>
    public short MagZ { get; set; }

    /// <summary>
    /// Offset along the X-axis.
    /// Смещение по оси X.
    /// </summary>
    public short OfsX { get; set; }

    /// <summary>
    /// Offset along the Y-axis.
    /// Смещение по оси Y.
    /// </summary>
    public short OfsY { get; set; }

    /// <summary>
    /// Offset along the Z-axis.
    /// Смещение по оси Z.
    /// </summary>
    public short OfsZ { get; set; }

    /// <summary>
    /// Hard iron offset along the X-axis.
    /// Жесткое смещение по оси X.
    /// </summary>
    public short MOfsX { get; set; }

    /// <summary>
    /// Hard iron offset along the Y-axis.
    /// Жесткое смещение по оси Y.
    /// </summary>
    public short MOfsY { get; set; }

    /// <summary>
    /// Hard iron offset along the Z-axis.
    /// Жесткое смещение по оси Z.
    /// </summary>
    public short MOfsZ { get; set; }

    /// <summary>
    /// Sensor health status.
    /// Статус здоровья сенсора.
    /// </summary>
    public byte Health { get; set; }

    /// <summary>
    /// Sensor flags.
    /// Флаги сенсора.
    /// </summary>
    public uint S { get; set; }
}