using System.IO.Ports;

namespace WithoutViolation
{
    public class DeviceOperations : IDeviceOperations
    {
        public string Find(SerialPort port)
        {
            string[] names = SerialPort.GetPortNames();
            foreach (string name in names)
            {
                port.Write("special code");
                if (port.ReadByte() == 0)
                    return name;
            }
            return null;
        }
    }
}