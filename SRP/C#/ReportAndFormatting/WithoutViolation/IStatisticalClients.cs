namespace WithoutViolation
{
    public interface IStatisticalClients
    {
        int GetNumberOfClients();
        decimal GetTotalIncome();
        int GetSatisfiedClients();
        int GetUnsatisfiedClients();
    }
}