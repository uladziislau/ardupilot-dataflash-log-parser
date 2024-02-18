using System.Runtime.InteropServices;

namespace UDIE.Adrupilot.Dataflash.Structure.Formats.Communication;

/// <summary>
/// Структура RSSI (Received Signal Strength Indicator), предназначенная для хранения информации о мощности принятого сигнала.
/// The RSSI (Received Signal Strength Indicator) structure is intended for storing information about the received signal strength.
/// </summary>

/// <remarks>
/// FMT, 137, 15, RSSI, Qf, TimeUS,RXRSSI
/// </remarks>

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct RSSI
{
    /// <summary>
    /// Время в микросекундах с момента запуска системы.
    /// Time in microseconds since system boot.
    /// </summary>
    public ulong TimeUS { get; set; }

    /// <summary>
    /// Мощность принятого сигнала (в децибелах).
    /// Received signal strength (in decibels).
    /// </summary>
    public float RXRSSI { get; set; }
}