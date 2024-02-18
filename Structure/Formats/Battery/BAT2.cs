using System.Runtime.InteropServices;
using UDIE.Adrupilot.Dataflash.Structure.Helpers;

namespace UDIE.Adrupilot.Dataflash.Structure.Formats.Battery;

/// <summary>
/// The BAT structure is used to record battery data.
/// Структура BAT используется для записи данных о батарее.
/// </summary>

/// <remarks>
/// FMT, 165, 37, BAT2, Qfffffcf, TimeUS,Volt,VoltR,Curr,CurrTot,EnrgTot,Temp,Res
/// </remarks>

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct BAT2
{
    /// <summary>
    /// Time in microseconds when the data was obtained.
    /// Время в микросекундах, когда были получены данные.
    /// </summary>
    public ulong TimeUS { get; set; }

    /// <summary>
    /// Battery voltage in volts.
    /// Напряжение батареи в вольтах.
    /// </summary>
    public float Volt { get; set; }

    /// <summary>
    /// Battery voltage after regulation in volts.
    /// Напряжение батареи после управления в вольтах.
    /// </summary>
    public float VoltR { get; set; }

    /// <summary>
    /// Current in amperes.
    /// Текущий в амперах.
    /// </summary>
    public float Curr { get; set; }

    /// <summary>
    /// Total current in ampere-hours.
    /// Общий ток в ампер-часах.
    /// </summary>
    public float CurrTot { get; set; }

    /// <summary>
    /// Total energy in watt-hours.
    /// Общая энергия в ватт-часах.
    /// </summary>
    public float EnrgTot { get; set; }

    private readonly short _Temp;
    
    /// <summary>
    /// Temperature in degrees Celsius.
    /// Температура в градусах Цельсия.
    /// </summary>
    public double Temp => _Temp.Toc();

    /// <summary>
    /// Resistance.
    /// Сопротивление.
    /// </summary>
    public float Res { get; set; }
}