namespace BankAccount
{
    using System;

    public class MortgageAccount : BankAccount, IDepositable
    {
        public MortgageAccount(decimal balance, Customer customer, decimal interestRate, long numberOfMonths)
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
                if (this.NumberOfMonths <= 12)
                {
                    interestAmount = this.InterestRate * this.NumberOfMonths / 2;
                    return interestAmount;
                }
                else
                {
                    interestAmount = this.InterestRate * 6 + this.InterestRate * (this.NumberOfMonths - 12);
                    return interestAmount;
                }
            }
            else
            {
                if (this.NumberOfMonths <= 6)
                {
                    interestAmount = 0;
                    return interestAmount;
                }
                else
                {
                    interestAmount = this.InterestRate * (this.NumberOfMonths - 6);
                    return interestAmount;
                }
            }
        }
    }
}