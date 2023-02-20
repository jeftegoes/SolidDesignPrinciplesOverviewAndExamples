using WithoutViolation;

void FindAlarmDevice()
{
    var driver = new AlarmDriver();
    string port = driver.Find();

    var operationSystem = new OperationSystem();
    operationSystem.SetPortState(port);
}