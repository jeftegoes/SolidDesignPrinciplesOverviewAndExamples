using System.IO.Ports;

namespace WithoutViolation
{
    public class BillDispenserEcdmDevice : IDeviceModel
    {
        public SerialPort GetDevice()
        {
            return new SerialPort
            {
                BaudRate = 4800,
                Parity = Parity.Mark,
                Handshake = Handshake.RequestToSendXOnXOff
            };
        }
    }
}