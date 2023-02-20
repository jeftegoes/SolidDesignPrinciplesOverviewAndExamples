using WithViolation;

void FindAlarmDevice()
{
    var driver = new AlarmDriver();
    string port = driver.Find();

    if (!string.IsNullOrWhiteSpace(port))
    {
        SystemState.AlarmCanBeUsed = false;
    }

    SystemState.AlarmCanBeUsed = true;
}