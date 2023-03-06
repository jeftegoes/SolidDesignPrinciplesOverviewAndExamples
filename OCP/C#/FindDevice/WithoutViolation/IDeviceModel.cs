using System.IO.Ports;

namespace WithoutViolation
{
    public interface IDeviceModel
    {
        SerialPort GetDevice();
    }
}