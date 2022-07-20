using WithoutViolation;

var deviceFinder = new DeviceFinder(new DeviceOperations());
deviceFinder.Find(new BillAccepterCashCodeDevice());