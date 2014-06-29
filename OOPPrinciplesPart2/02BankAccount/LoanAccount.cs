namespace BankAccount
{
    using System;

    public class LoanAccount : BankAccount, IDepositable
    {
        public LoanAccount(decimal balance, Customer customer, decimal interestRate, long numberOfMonths)
            : base(balance, customer, interestRate, numberOfMonths)
        {
        }

        public void DepositMoney(decimal moneyAmount)
        {
            this.Balance += moneyAmount;
        }

        public override decimal CalculateInterestAmount()
        {
            decimal interestAmount = 0;
            if (this.Customer is Company)
            {
                interestAmount = this.InterestRate * (this.NumberOfMonths - 2);
            }
            else
            {
                interestAmount = this.InterestRate * (this.NumberOfMonths - 3);
            }
            
            return interestAmount;
        }
    }
}