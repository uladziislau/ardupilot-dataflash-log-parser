using System.Runtime.InteropServices;

namespace UDIE.Adrupilot.Dataflash.Structure.Formats.Battery;

/// <summary>
/// Структура MOTB предназначена для записи данных о состоянии мотора и батареи.
/// The MOTB structure is designed to record motor and battery state data.
/// </summary>

/// <remarks>
/// FMT, 13, 27, MOTB, Qffff, TimeUS,LiftMax,BatVolt,BatRes,ThLimit
/// </remarks>

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct MOTB
{
    /// <summary>
    /// Время, когда были получены данные, в микросекундах.
    /// Time when the data was received, in microseconds.
    /// </summary>
    public ulong TimeUS { get; set; }

    /// <summary>
    /// Максимальное значение подъемной силы.
    /// Maximum lift value.
    /// </summary>
    public float LiftMax { get; set; }

    /// <summary>
    /// Напряжение батареи в вольтах.
    /// Battery voltage in volts.
    /// </summary>
    public float BatVolt { get; set; }

    /// <summary>
    /// Сопротивление батареи.
    /// Battery resistance.
    /// </summary>
    public float BatRes { get; set; }

    /// <summary>
    /// Предел газа.
    /// Throttle limit.
    /// </summary>
    public float ThLimit { get; set; }
}