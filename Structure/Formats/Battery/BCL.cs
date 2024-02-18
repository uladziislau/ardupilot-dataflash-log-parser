using System.Runtime.InteropServices;

namespace UDIE.Adrupilot.Dataflash.Structure.Formats.Battery;

/// <summary>
/// Структура BCL2 предназначена для записи данных о состоянии батареи.
/// The BCL2 structure is designed to record battery status data.
/// </summary>

/// <remarks>
/// FMT, 166, 35, BCL, QfHHHHHHHHHH, TimeUS,Volt,V1,V2,V3,V4,V5,V6,V7,V8,V9,V10
/// </remarks>

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct BCL
{
    /// <summary>
    /// Время, когда были получены данные, в микросекундах.
    /// Time when the data was received, in microseconds.
    /// </summary>
    public ulong TimeUS { get; set; }

    /// <summary>
    /// Напряжение батареи в вольтах.
    /// Battery voltage in volts.
    /// </summary>
    public float Volt { get; set; }

    /// <summary>
    /// Напряжение на ячейке батареи №1.
    /// Voltage on battery cell №1.
    /// </summary>
    public ushort V1 { get; set; }

    /// <summary>
    /// Напряжение на ячейке батареи №2.
    /// Voltage on battery cell №2.
    /// </summary>
    public ushort V2 { get; set; }

    /// <summary>
    /// Напряжение на ячейке батареи №3.
    /// Voltage on battery cell №3.
    /// </summary>
    public ushort V3 { get; set; }

    /// <summary>
    /// Напряжение на ячейке батареи №4.
    /// Voltage on battery cell №4.
    /// </summary>
    public ushort V4 { get; set; }

    /// <summary>
    /// Напряжение на ячейке батареи №5.
    /// Voltage on battery cell №5.
    /// </summary>
    public ushort V5 { get; set; }

    /// <summary>
    /// Напряжение на ячейке батареи №6.
    /// Voltage on battery cell №6.
    /// </summary>
    public ushort V6 { get; set; }

    /// <summary>
    /// Напряжение на ячейке батареи №7.
    /// Voltage on battery cell №7.
    /// </summary>
    public ushort V7 { get; set; }

    /// <summary>
    /// Напряжение на ячейке батареи №8.
    /// Voltage on battery cell №8.
    /// </summary>
    public ushort V8 { get; set; }

    /// <summary>
    /// Напряжение на ячейке батареи №9.
    /// Voltage on battery cell №9.
    /// </summary>
    public ushort V9 { get; set; }

    /// <summary>
    /// Напряжение на ячейке батареи №10.
    /// Voltage on battery cell №10.
    /// </summary>
    public ushort V10 { get; set; }
}