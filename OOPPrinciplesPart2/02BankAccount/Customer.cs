namespace BankAccount
{
    using System;

    public class Customer
    {
        private string firstName;
        private string lastName;
        private long pIN;

        public Customer(string firstName, long pIN)
        {
            this.FirstName = firstName;
            this.PIN = pIN;
        }

        public Customer(string firstName, string lastName, long pIN) : this(firstName, pIN)
        {
            this.LastName = lastName;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            private set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Name cannot be null");
                }

                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }

            private set
            {
                this.lastName = value;
            }
        }

        public long PIN
        {
            get
            {
                return this.pIN;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("PIN cannot be negative");
                }

                this.pIN = value;
            }
        }
    }
}