using System.Runtime.InteropServices;

namespace UDIE.Adrupilot.Dataflash.Structure.Formats.Sensors;

/// <summary>
/// Structure RCIN represents the RC input channels to the vehicle.
/// Структура RCIN представляет собой входные каналы пульта дистанционного управления (RC) на борту аппарата.
/// </summary>

/// <remarks>
/// FMT, 135, 39, RCIN, QHHHHHHHHHHHHHH, TimeUS,C1,C2,C3,C4,C5,C6,C7,C8,C9,C10,C11,C12,C13,C14
/// </remarks>

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct RCIN
{
    /// <summary>
    /// Time in microseconds since system startup.
    /// Время в микросекундах с момента запуска системы.
    /// </summary>
    public ulong TimeUS { get; set; }

    /// <summary>
    /// Channel 1 input.
    /// Вход канала 1.
    /// </summary>
    public ushort C1 { get; set; }

    /// <summary>
    /// Channel 2 input.
    /// Вход канала 2.
    /// </summary>
    public ushort C2 { get; set; }

    /// <summary>
    /// Channel 3 input.
    /// Вход канала 3.
    /// </summary>
    public ushort C3 { get; set; }

    /// <summary>
    /// Channel 4 input.
    /// Вход канала 4.
    /// </summary>
    public ushort C4 { get; set; }

    /// <summary>
    /// Channel 5 input.
    /// Вход канала 5.
    /// </summary>
    public ushort C5 { get; set; }

    /// <summary>
    /// Channel 6 input.
    /// Вход канала 6.
    /// </summary>
    public ushort C6 { get; set; }

    /// <summary>
    /// Channel 7 input.
    /// Вход канала 7.
    /// </summary>
    public ushort C7 { get; set; }

    /// <summary>
    /// Channel 8 input.
    /// Вход канала 8.
    /// </summary>
    public ushort C8 { get; set; }

    /// <summary>
    /// Channel 9 input.
    /// Вход канала 9.
    /// </summary>
    public ushort C9 { get; set; }

    /// <summary>
    /// Channel 10 input.
    /// Вход канала 10.
    /// </summary>
    public ushort C10 { get; set; }

    /// <summary>
    /// Channel 11 input.
    /// Вход канала 11.
    /// </summary>
    public ushort C11 { get; set; }

    /// <summary>
    /// Channel 12 input.
    /// Вход канала 12.
    /// </summary>
    public ushort C12 { get; set; }

    /// <summary>
    /// Channel 13 input.
    /// Вход канала 13.
    /// </summary>
    public ushort C13 { get; set; }

    /// <summary>
    /// Channel 14 input.
    /// Вход канала 14.
    /// </summary>
    public ushort C14 { get; set; }
}