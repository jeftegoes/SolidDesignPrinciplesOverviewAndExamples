int GetNumberOfClients()
{
    return 100;
}

decimal GetTotalIncome()
{
    return 10.20m;
}

int GetSatisfiedClients()
{
    return 88;
}

int GetUnsatisfiedClients()
{
    return 12;
}

string GetReport()
{
    int clientsNumber = GetNumberOfClients();
    decimal totalIncome = GetTotalIncome();
    int satisfiedClients = GetSatisfiedClients();
    int unsatisfiedClients = GetUnsatisfiedClients();

    string clientsStr = $"Total number of Clients = {clientsNumber}";
    string incomeStr = $"Total Income = {totalIncome}";
    string satisfiedClientsStr = $"Number of satisfied Clients = {satisfiedClients}";
    string unsatisfiedClientsStr = $"Number of sad Clients = {unsatisfiedClients}";

    return clientsStr
           + Environment.NewLine
           + incomeStr
           + Environment.NewLine
           + satisfiedClientsStr
           + Environment.NewLine
           + unsatisfiedClientsStr
           + Environment.NewLine;
}

Console.WriteLine(GetReport());