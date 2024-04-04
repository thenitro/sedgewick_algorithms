namespace sedgewick_algorithms.Chapter_1.Topic_1_2_DataAbstraction
{
    public class Transaction
    {
        public string Customer { get; }
        public Date Date { get; }
        public double Amount { get; }

        public Transaction(string customer, Date date, double amount)
        {
            Customer = customer;
            Date = date;
            Amount = amount;
        }

        public override bool Equals(object other)
        {
            if (this == other) return true;
            if (other == null) return false;
            if (GetType() != other.GetType()) return false;

            var otherTransaction = other as Transaction;
            if (otherTransaction == null) return false;

            return Customer.Equals(otherTransaction.Customer) &&
                   Date.Equals(otherTransaction.Date) &&
                   Amount.Equals(otherTransaction.Amount);
        }
    }
}