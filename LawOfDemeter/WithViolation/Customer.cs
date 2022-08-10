namespace WithViolation
{
    public class Customer
    {
        public string FirstName { get; }
        public string LastName { get; }
        public Wallet Wallet { get; }

        public Customer(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            Wallet = new Wallet(1000m);
        }
    }
}