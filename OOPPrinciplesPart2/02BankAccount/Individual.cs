namespace BankAccount
{
    using System;

    public class Individual : Customer
    {
        public Individual(string firstName, string lastName, long pIN) : base(firstName, lastName, pIN)
        {
        }
    }
}