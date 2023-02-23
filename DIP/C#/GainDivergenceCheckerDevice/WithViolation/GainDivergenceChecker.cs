namespace WithViolation
{
    public class GainDivergenceChecker
    {
        private Accounter _privateAccounter;
        private FiscalRegistrator _fr;

        public GainDivergenceChecker()
        {
            _privateAccounter = new Accounter();
            _fr = new FiscalRegistrator();
        }

        public bool HasDivergence()
        {
            decimal salesSumm = _privateAccounter.GetSalesSumm();
            decimal summOfReturnedTickets = _privateAccounter.GetSummOfReturnedTickets();

            decimal salesSummByFiscalRegistrator = _fr.GetSalesSumm();
            decimal summOfReturnedTicketsByFiscalRegistrator = _fr.GetSummOfReturnedTickets();

            return salesSumm == salesSummByFiscalRegistrator
                && summOfReturnedTickets == summOfReturnedTicketsByFiscalRegistrator;
        }

        private void ValidateDepencies(Accounter accounter, FiscalRegistrator fr)
        {
            if (accounter == null)
                throw new ArgumentNullException("accounter");
            if (fr == null)
                throw new ArgumentNullException("fr");
        }
    }
}