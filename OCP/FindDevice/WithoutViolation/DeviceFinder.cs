namespace WithoutViolation
{
    public class DeviceFinder
    {
        private readonly IDeviceOperations _deviceOperations;

        public DeviceFinder(IDeviceOperations deviceOperations)
        {
            _deviceOperations = deviceOperations;
        }

        public string Find(IDeviceModel model)
        {
            return _deviceOperations.Find(model.GetDevice());
        }
    }
}