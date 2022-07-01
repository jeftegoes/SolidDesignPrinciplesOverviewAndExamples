namespace ExampleSrp
{
    public class BankGateway : ICanPayViaCreditCard
    {
        public void ChargeCard(TicketDetails ticket, PaymentDetails payment)
        {
            throw new NotImplementedException();
        }
    }
}