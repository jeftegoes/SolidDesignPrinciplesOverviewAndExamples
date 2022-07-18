namespace WithoutViolation
{
    public interface ICanPayViaCreditCard
    {
        void ChargeCard(TicketDetails ticket, PaymentDetails payment);
    }
}