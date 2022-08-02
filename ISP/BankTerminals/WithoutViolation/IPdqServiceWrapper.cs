namespace WithoutViolation
{
    public interface IPdqServiceWrapper
    {
        bool IsContactReaderOnPort(string comPort);
        bool IsNonContactReaderOnPort(string comPort);
        string FindContactReader();
        string FindNonContactReader();
    }
}