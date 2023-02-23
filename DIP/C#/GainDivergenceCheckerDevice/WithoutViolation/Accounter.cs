namespace WithoutViolation
{
    public class Accounter : IAccounter
    {
        public decimal GetSalesSumm()
        {
            throw new NotImplementedException();
        }

        public decimal GetSummOfReturnedTickets()
        {
            throw new NotImplementedException();
        }
    }
}