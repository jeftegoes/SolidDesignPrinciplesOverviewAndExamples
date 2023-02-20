namespace WithoutViolation
{
    public class OperationSystem
    {
        public void SetPortState(string port)
        {
            if (!string.IsNullOrWhiteSpace(port))
            {
                SystemState.AlarmCanBeUsed = false;
            }

            SystemState.AlarmCanBeUsed = true;
        }
    }
}