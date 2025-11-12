using System.Runtime.InteropServices;

namespace UDIE.Adrupilot.Dataflash.Structure.Formats.Sensors;

/// <summary>
/// The SRV2 structure is used to record additional servo output values.
/// Структура SRV2 используется для записи дополнительных значений выходных сигналов сервоприводов.
/// </summary>

/// <remarks>
/// FMT, 249, 59, SRV2, Qffffffffffff, TimeUS,S13,S14,S15,S16,S17,S18,S19,S20,S21,S22,S23,S24
/// </remarks>

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct SRV2
{
    /// <summary>
    /// Time in microseconds when the data was received.
    /// Время в микросекундах, когда были получены данные.
    /// </summary>
    public ulong TimeUS { get; set; }

    /// <summary>
    /// Servo output value for channel 13.
    /// Значение выходного сигнала сервопривода для канала 13.
    /// </summary>
    public float S13 { get; set; }

    /// <summary>
    /// Servo output value for channel 14.
    /// Значение выходного сигнала сервопривода для канала 14.
    /// </summary>
    public float S14 { get; set; }

    /// <summary>
    /// Servo output value for channel 15.
    /// Значение выходного сигнала сервопривода для канала 15.
    /// </summary>
    public float S15 { get; set; }

    /// <summary>
    /// Servo output value for channel 16.
    /// Значение выходного сигнала сервопривода для канала 16.
    /// </summary>
    public float S16 { get; set; }

    /// <summary>
    /// Servo output value for channel 17.
    /// Значение выходного сигнала сервопривода для канала 17.
    /// </summary>
    public float S17 { get; set; }

    /// <summary>
    /// Servo output value for channel 18.
    /// Значение выходного сигнала сервопривода для канала 18.
    /// </summary>
    public float S18 { get; set; }

    /// <summary>
    /// Servo output value for channel 19.
    /// Значение выходного сигнала сервопривода для канала 19.
    /// </summary>
    public float S19 { get; set; }

    /// <summary>
    /// Servo output value for channel 20.
    /// Значение выходного сигнала сервопривода для канала 20.
    /// </summary>
    public float S20 { get; set; }

    /// <summary>
    /// Servo output value for channel 21.
    /// Значение выходного сигнала сервопривода для канала 21.
    /// </summary>
    public float S21 { get; set; }

    /// <summary>
    /// Servo output value for channel 22.
    /// Значение выходного сигнала сервопривода для канала 22.
    /// </summary>
    public float S22 { get; set; }

    /// <summary>
    /// Servo output value for channel 23.
    /// Значение выходного сигнала сервопривода для канала 23.
    /// </summary>
    public float S23 { get; set; }

    /// <summary>
    /// Servo output value for channel 24.
    /// Значение выходного сигнала сервопривода для канала 24.
    /// </summary>
    public float S24 { get; set; }
}