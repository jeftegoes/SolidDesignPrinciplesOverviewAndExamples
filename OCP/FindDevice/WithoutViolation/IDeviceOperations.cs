using System.IO.Ports;

namespace WithoutViolation
{
    public interface IDeviceOperations
    {
        string Find(SerialPort serialPort);
    }
}