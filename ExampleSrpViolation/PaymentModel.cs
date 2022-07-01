namespace ExampleSrpViolation
{
    public class PaymentModel
    {
        private decimal _cashAccepted;

        public void BuyTicket(TicketDetails ticket,
                              PaymentDetails payment,
                              Action onPayChangeToMobilePhone)
        {
            if (payment.Method == PaymentMethod.CreditCard)
            {
                ChargeCard(ticket, payment);
            }
            else
            {
                AcceptCash(ticket);
                DispenseChange(ticket, onPayChangeToMobilePhone);
            }
        }

        private void DispenseChange(TicketDetails ticket, Action onPayChangeToMobilePhone)
        {
            if (_cashAccepted > ticket.Price && !TryToDispense(_cashAccepted - ticket.Price))
                onPayChangeToMobilePhone?.Invoke();
        }

        private bool TryToDispense(decimal changeAmount)
        {
            return false; // Or true...
        }

        private void AcceptCash(TicketDetails ticket)
        {
            var r = new Random();
            _cashAccepted = r.Next((int)ticket.Price, (int)ticket.Price + 1000);
        }

        private void ChargeCard(TicketDetails ticket, PaymentDetails payment)
        {
            var gateway = new ProcessingCenterGateway();
            gateway.Charge(ticket.Price, payment);
        }
    }
}