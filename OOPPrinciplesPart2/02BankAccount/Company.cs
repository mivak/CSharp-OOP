namespace BankAccount
{
    using System;

    public class Company : Customer
    {
        public Company(string firstName, long pIN) : base(firstName, pIN)
        {
        }
    }
}