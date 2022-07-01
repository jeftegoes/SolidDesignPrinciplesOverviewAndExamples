namespace ExampleSrp
{
    public interface ICanPayViaCreditCard
    {
        void ChargeCard(TicketDetails ticket, PaymentDetails payment);
    }
}