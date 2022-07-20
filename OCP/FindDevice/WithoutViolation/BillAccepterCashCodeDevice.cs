using System.IO.Ports;

namespace WithoutViolation
{
    public class BillAccepterCashCodeDevice : IDeviceModel
    {
        public SerialPort GetDevice()
        {
            return new SerialPort
            {
                BaudRate = 9600,
                Parity = Parity.Even,
                Handshake = Handshake.RequestToSend
            };
        }
    }
}