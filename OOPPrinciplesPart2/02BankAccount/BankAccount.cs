namespace BankAccount
{
    using System;

    public abstract class BankAccount
    {
        private decimal balance;
        private Customer customer;
        private decimal interestRate;
        private long numberOfMonths;

        public BankAccount(decimal balance, Customer customer, decimal interestRate, long numberOfMonths)
        {
            this.Balance = balance;
            this.Customer = customer;
            this.InterestRate = interestRate;
            this.NumberOfMonths = numberOfMonths;
        }

        public long NumberOfMonths
        {
            get
            {
                return this.numberOfMonths;
            }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Number of months cannot be negative");
                }

                this.numberOfMonths = value;
            }
        }

        public decimal Balance
        {
            get
            {
                return this.balance;
            }

            set
            {
                this.balance = value;
            }
        }

        public Customer Customer
        {
            get
            {
                return this.customer;
            }

            private set
            {
                this.customer = value;
            }
        }

        public decimal InterestRate
        {
            get
            {
                return this.interestRate;
            }
            
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Interest rate cannot be negative");
                }

                this.interestRate = value;
            }
        }
        
        public virtual decimal CalculateInterestAmount()
        {
            decimal interestAmount = this.InterestRate * this.NumberOfMonths;
            return interestAmount;
        }
    }
}