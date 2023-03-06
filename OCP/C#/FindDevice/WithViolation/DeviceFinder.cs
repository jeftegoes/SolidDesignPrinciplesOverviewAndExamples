using System.IO.Ports;

namespace WithViolation
{
    public class DeviceFinder
    {
        public string FindDevice(DeviceModel model)
        {
            var port = new SerialPort();
            
            switch (model)
            {
                case DeviceModel.BillAccepterCashCode:
                    {
                        port.BaudRate = 9600;
                        port.Parity = Parity.Even;
                        port.Handshake = Handshake.RequestToSend;
                        return Find(port);
                    }
                case DeviceModel.BillDispenserEcdm:
                    {
                        port.BaudRate = 4800;
                        port.Parity = Parity.Mark;
                        port.Handshake = Handshake.RequestToSendXOnXOff;
                        return Find(port);
                    }
                case DeviceModel.CoinAccepterNri:
                    {
                        port.BaudRate = 19200;
                        port.Parity = Parity.Odd;
                        port.Handshake = Handshake.XOnXOff;
                        return Find(port);
                    }
                case DeviceModel.CoinDispenserCube4:
                    {
                        port.BaudRate = 9600;
                        port.Parity = Parity.Space;
                        port.Handshake = Handshake.None;
                        return Find(port);
                    }
                case DeviceModel.CoinDispsenerSch2:
                    {
                        port.BaudRate = 4800;
                        port.Parity = Parity.Even;
                        port.Handshake = Handshake.None;
                        return Find(port);
                    }
                default:
                    throw new ArgumentException($"Unknown model: {model}.");
            }
        }

        private string Find(SerialPort port)
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