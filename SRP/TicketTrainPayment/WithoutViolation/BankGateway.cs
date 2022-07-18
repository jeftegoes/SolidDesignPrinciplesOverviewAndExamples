namespace WithoutViolation
{
    public class BankGateway : ICanPayViaCreditCard
    {
        public void ChargeCard(TicketDetails ticket, PaymentDetails payment)
        {
            // Charge
        }
    }
}