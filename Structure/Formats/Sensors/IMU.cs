using System.Runtime.InteropServices;

namespace UDIE.Adrupilot.Dataflash.Structure.Formats.Sensors;

/// <summary>
/// Structure representing IMU (Inertial Measurement Unit) data.
/// Структура данных IMU, представляющая измерения инерциальных датчиков.
/// </summary>

/// <remarks>
/// FMT, 133, 53, IMU, QffffffIIfBBHH, TimeUS,GyrX,GyrY,GyrZ,AccX,AccY,AccZ,EG,EA,T,GH,AH,GHz,AHz
/// </remarks>

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct IMU
{
    /// <summary>
    /// Time in microseconds.
    /// Время в микросекундах.
    /// </summary>
    public ulong TimeUS { get; set; }

    /// <summary>
    /// Angular velocity about the X-axis.
    /// Угловая скорость по оси X.
    /// </summary>
    public float GyrX { get; set; }

    /// <summary>
    /// Angular velocity about the Y-axis.
    /// Угловая скорость по оси Y.
    /// </summary>
    public float GyrY { get; set; }

    /// <summary>
    /// Angular velocity about the Z-axis.
    /// Угловая скорость по оси Z.
    /// </summary>
    public float GyrZ { get; set; }

    /// <summary>
    /// Acceleration along the X-axis.
    /// Ускорение по оси X.
    /// </summary>
    public float AccX { get; set; }

    /// <summary>
    /// Acceleration along the Y-axis.
    /// Ускорение по оси Y.
    /// </summary>
    public float AccY { get; set; }

    /// <summary>
    /// Acceleration along the Z-axis.
    /// Ускорение по оси Z.
    /// </summary>
    public float AccZ { get; set; }

    /// <summary>
    /// Gyroscope error.
    /// Ошибка гироскопа.
    /// </summary>
    public uint EG { get; set; }

    /// <summary>
    /// Accelerometer error.
    /// Ошибка акселерометра.
    /// </summary>
    public uint EA { get; set; }

    /// <summary>
    /// Temperature.
    /// Температура.
    /// </summary>
    public float T { get; set; }

    /// <summary>
    /// GPS message number.
    /// Номер сообщения GPS.
    /// </summary>
    public byte GH { get; set; }

    /// <summary>
    /// AHRS message number.
    /// Номер сообщения AHRS.
    /// </summary>
    public byte AH { get; set; }

    /// <summary>
    /// Gyroscope frequency.
    /// Частота гироскопа.
    /// </summary>
    public ushort GHz { get; set; }

    /// <summary>
    /// Accelerometer frequency.
    /// Частота акселерометра.
    /// </summary>
    public ushort AHz { get; set; }
}