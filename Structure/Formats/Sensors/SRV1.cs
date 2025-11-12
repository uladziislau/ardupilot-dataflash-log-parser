using System.Runtime.InteropServices;

namespace UDIE.Adrupilot.Dataflash.Structure.Formats.Sensors;

/// <summary>
/// The SRV1 structure is used to record servo output values.
/// Структура SRV1 используется для записи значений выходных сигналов сервоприводов.
/// </summary>

/// <remarks>
/// FMT, 250, 59, SRV1, Qffffffffffff, TimeUS,S1,S2,S3,S4,S5,S6,S7,S8,S9,S10,S11,S12
/// </remarks>

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct SRV1
{
    /// <summary>
    /// Time in microseconds when the data was received.
    /// Время в микросекундах, когда были получены данные.
    /// </summary>
    public ulong TimeUS { get; set; }

    /// <summary>
    /// Servo output value for channel 1.
    /// Значение выходного сигнала сервопривода для канала 1.
    /// </summary>
    public float S1 { get; set; }

    /// <summary>
    /// Servo output value for channel 2.
    /// Значение выходного сигнала сервопривода для канала 2.
    /// </summary>
    public float S2 { get; set; }

    /// <summary>
    /// Servo output value for channel 3.
    /// Значение выходного сигнала сервопривода для канала 3.
    /// </summary>
    public float S3 { get; set; }

    /// <summary>
    /// Servo output value for channel 4.
    /// Значение выходного сигнала сервопривода для канала 4.
    /// </summary>
    public float S4 { get; set; }

    /// <summary>
    /// Servo output value for channel 5.
    /// Значение выходного сигнала сервопривода для канала 5.
    /// </summary>
    public float S5 { get; set; }

    /// <summary>
    /// Servo output value for channel 6.
    /// Значение выходного сигнала сервопривода для канала 6.
    /// </summary>
    public float S6 { get; set; }

    /// <summary>
    /// Servo output value for channel 7.
    /// Значение выходного сигнала сервопривода для канала 7.
    /// </summary>
    public float S7 { get; set; }

    /// <summary>
    /// Servo output value for channel 8.
    /// Значение выходного сигнала сервопривода для канала 8.
    /// </summary>
    public float S8 { get; set; }

    /// <summary>
    /// Servo output value for channel 9.
    /// Значение выходного сигнала сервопривода для канала 9.
    /// </summary>
    public float S9 { get; set; }

    /// <summary>
    /// Servo output value for channel 10.
    /// Значение выходного сигнала сервопривода для канала 10.
    /// </summary>
    public float S10 { get; set; }

    /// <summary>
    /// Servo output value for channel 11.
    /// Значение выходного сигнала сервопривода для канала 11.
    /// </summary>
    public float S11 { get; set; }

    /// <summary>
    /// Servo output value for channel 12.
    /// Значение выходного сигнала сервопривода для канала 12.
    /// </summary>
    public float S12 { get; set; }
}