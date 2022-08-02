namespace WithoutViolation
{
    public class PdqTerminalServiceCommunicator
    {
        private IPdqServiceWrapper _serviceWrapper;
        
        public bool IsContactReaderOnPort(string comPort)
        {
            return _serviceWrapper.IsContactReaderOnPort(comPort);
        }

        public bool IsNonContactReaderOnPort(string comPort)
        {
            return _serviceWrapper.IsNonContactReaderOnPort(comPort);
        }

        public string FindContactReader()
        {
            return _serviceWrapper.FindContactReader();
        }

        public string FindNonContactReader()
        {
            return _serviceWrapper.FindNonContactReader();
        }
    }
}