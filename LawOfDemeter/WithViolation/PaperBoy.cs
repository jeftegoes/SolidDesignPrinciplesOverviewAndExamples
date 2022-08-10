namespace WithViolation
{
    public class PaperBoy
    {
        public void DeliverMagazine(decimal costOfMagazine, Customer customer)
        {
            Wallet w = customer.Wallet;

            if (w.MoneyAmount > costOfMagazine)
            {
                w.WithdrawMoney(costOfMagazine);
            }
            else
            {
                // Come back later.
            }
        }
    }
}