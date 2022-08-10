namespace WithoutViolation
{
    public class Wallet
    {
        public decimal MoneyAmount { get; private set; }

        public Wallet(decimal moneyAmount)
        {
            MoneyAmount = moneyAmount;
        }

        public void AddMoney(decimal amount)
        {
            MoneyAmount += amount;
        }

        public void WithdrawMoney(decimal amount)
        {
            MoneyAmount -= amount;
        }
    }
}