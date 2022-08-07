namespace WithoutViolation
{
    public class GainDivergenceChecker
    {
        private IAccounter _privateAccounter;
        private IFiscalRegistrator _fr;

        public GainDivergenceChecker(IAccounter accounter, IFiscalRegistrator fiscalRegistrator)
        {
            _privateAccounter = accounter;
            _fr = fiscalRegistrator;
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