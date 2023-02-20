namespace WithoutViolation
{
    public class ReportClients : IReportClients
    {
        private readonly IStatisticalClients _totalResumeClients;

        public ReportClients(IStatisticalClients totalResumeClients)
        {
            _totalResumeClients = totalResumeClients;
        }

        public string Report()
        {
            var clientsStr = $"Total number of Clients = {_totalResumeClients.GetNumberOfClients()}";
            var incomeStr = $"Total Income = {_totalResumeClients.GetTotalIncome()}";
            var satisfiedClientsStr = $"Number of satisfied Clients = {_totalResumeClients.GetSatisfiedClients()}";
            var unsatisfiedClientsStr = $"Number of sad Clients = {_totalResumeClients.GetUnsatisfiedClients()}";

            return clientsStr
                   + Environment.NewLine
                   + incomeStr
                   + Environment.NewLine
                   + satisfiedClientsStr
                   + Environment.NewLine
                   + unsatisfiedClientsStr
                   + Environment.NewLine;
        }
    }
}