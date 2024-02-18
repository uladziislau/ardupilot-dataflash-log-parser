using System.Runtime.InteropServices;

namespace UDIE.Adrupilot.Dataflash.Structure.Formats.Battery;

/// <summary>
/// The POWR structure is used to record power and safety data.
/// Структура POWR используется для записи данных о питании и безопасности.
/// </summary>

/// <remarks>
/// FMT, 140, 22, POWR, QffHB, TimeUS,Vcc,VServo,Flags,Safety
/// </remarks>

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct POWR
{
    /// <summary>
    /// Time in microseconds when the data was obtained.
    /// Время в микросекундах, когда были получены данные.
    /// </summary>
    public ulong TimeUS { get; set; }

    /// <summary>
    /// Main power supply voltage in volts.
    /// Напряжение основного питания в вольтах.
    /// </summary>
    public float Vcc { get; set; }

    /// <summary>
    /// Servo power supply voltage in volts.
    /// Напряжение на сервоприводе в вольтах.
    /// </summary>
    public float VServo { get; set; }

    /// <summary>
    /// Flags.
    /// Флаги.
    /// </summary>
    public ushort Flags { get; set; }

    /// <summary>
    /// Safety information.
    /// Информация о безопасности.
    /// </summary>
    public byte Safety { get; set; }
}