namespace WithoutViolation
{
    public abstract class PaymentModel
    {
        protected TicketDetails _ticketDetails { get; set; }

        protected PaymentModel(TicketDetails ticketDetails)
        {
            _ticketDetails = ticketDetails;
        }

        public abstract void BuyTicket();
    }
}