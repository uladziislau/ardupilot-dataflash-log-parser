using System.Runtime.InteropServices;

namespace UDIE.Adrupilot.Dataflash.Structure.Formats.Communication;

/// <summary>
/// Структура RAD (Radio Communication), предназначенная для хранения информации о беспроводной связи.
/// The RAD (Radio Communication) structure is intended for storing information about radio communication.
/// </summary>

/// <remarks>
/// FMT, 144, 20, RAD, QBBBBBHH, TimeUS,RSSI,RemRSSI,TxBuf,Noise,RemNoise,RxErrors,Fixed
/// </remarks>

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct RAD
{
    /// <summary>
    /// Время в микросекундах, когда была получена информация об обмене данными.
    /// Time in microseconds when the data exchange information was received.
    /// </summary>
    public ulong TimeUS { get; set; }

    /// <summary>
    /// Значение индикатора силы приема сигнала (Received Signal Strength Indicator) устройства, которое принимает данные.
    /// Received Signal Strength Indicator value of the device receiving the data.
    /// </summary>
    public byte RSSI { get; set; }

    /// <summary>
    /// Значение индикатора силы приема сигнала (RSSI) устройства, с которым происходит обмен данными.
    /// Received Signal Strength Indicator value of the device with which data exchange is taking place.
    /// </summary>
    public byte RemRSSI { get; set; }

    /// <summary>
    /// Буфер передачи. Это количество данных, ожидающих отправки в момент получения этого сообщения.
    /// Transmission buffer. This is the amount of data waiting to be sent at the time this message is received.
    /// </summary>
    public byte TxBuf { get; set; }

    /// <summary>
    /// Уровень шума на канале связи.
    /// Noise level on the communication channel.
    /// </summary>
    public byte Noise { get; set; }

    /// <summary>
    /// Уровень шума на канале связи у устройства, с которым происходит обмен данными.
    /// Noise level on the communication channel of the device with which data exchange is taking place.
    /// </summary>
    public byte RemNoise { get; set; }

    /// <summary>
    /// Количество ошибок при приеме данных.
    /// Number of errors in received data.
    /// </summary>
    public ushort RxErrors { get; set; }

    /// <summary>
    /// Битовый флаг, указывающий на наличие или отсутствие исправленных ошибок в принятых данных.
    /// Если флаг установлен, то есть исправленные ошибки, если нет - то нет.
    /// Bit flag indicating the presence or absence of corrected errors in received data.
    /// If the flag is set, there are corrected errors; if not, there are none.
    /// </summary>
    public ushort Fixed { get; set; }
}