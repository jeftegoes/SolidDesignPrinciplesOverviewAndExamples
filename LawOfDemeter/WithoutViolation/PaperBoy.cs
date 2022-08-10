namespace WithoutViolation
{
    public class PaperBoy
    {
        public void DeliverMagazine(decimal costOfMagazine, Customer customer)
        {
            decimal payment = customer.GetPayment(costOfMagazine);
            if (payment == costOfMagazine)
            {
                // Say thank you and get out.
            }
            else
            {
                // Come back later.
            }
        }
    }
}