using WithoutViolation;

IStatisticalClients statisticalClients = new StatisticalClients();
IReportClients reportClients = new ReportClients(statisticalClients);

Console.WriteLine(reportClients.Report());