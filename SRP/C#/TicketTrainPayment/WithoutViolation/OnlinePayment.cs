namespace WithoutViolation
{
    public class OnlinePayment : PaymentModel
    {
        private readonly PaymentDetails _payment;
        private readonly ICanPayViaCreditCard _bankGateway;

        public OnlinePayment(TicketDetails ticketDetails, PaymentDetails payment) : base(ticketDetails)
        {
            _payment = payment;
            _bankGateway = new BankGateway();
        }

        public override void BuyTicket()
        {
            _bankGateway.ChargeCard(base._ticketDetails, _payment);
        }
    }
}