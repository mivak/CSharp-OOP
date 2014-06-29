namespace BankAccount
{
    using System;

    public class DepositAccount : BankAccount, IDepositable
    {
        public DepositAccount(decimal balance, Customer customer, decimal interestRate, long numberOfMonths)
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
            if (this.Balance > 0 && this.Balance < 1000)
            {
                interestAmount = 0;
            }
            else
            {
                interestAmount = this.InterestRate * this.NumberOfMonths;
            }

            return interestAmount;
        }

        public decimal WithdrawMoney(decimal withdrawMoney)
        {
            this.Balance -= withdrawMoney;
            return this.Balance;
        }
    }
}