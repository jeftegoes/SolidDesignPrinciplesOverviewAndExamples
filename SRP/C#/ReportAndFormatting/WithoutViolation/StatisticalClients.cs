namespace WithoutViolation
{
    public class StatisticalClients : IStatisticalClients
    {
        public int GetNumberOfClients()
        {
            return 100;
        }

        public decimal GetTotalIncome()
        {
            return 10.20m;
        }

        public int GetSatisfiedClients()
        {
            return 88;
        }

        public int GetUnsatisfiedClients()
        {
            return 12;
        }
    }
}