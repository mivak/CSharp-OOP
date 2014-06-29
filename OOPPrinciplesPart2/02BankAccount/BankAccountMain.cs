namespace BankAccount
{
    using System;
    using System.Collections.Generic;

    public class BankAccountMain
    {
        public static void Main()
        {
            Customer ivan = new Individual("Ivan", "Ivanov", 8112212564);
            Customer firm = new Company("Firm", 987654321);

            BankAccount firstDeposit = new DepositAccount(1000, ivan, 5.5M, 3);
            BankAccount secondDeposit = new DepositAccount(1000, firm, 5.5M, 3);

            BankAccount firstMortgage = new MortgageAccount(1000, ivan, 5.5M, 3);
            BankAccount secondMortgage = new MortgageAccount(1000, firm, 5.5M, 3);

            BankAccount firstLoan = new LoanAccount(1000, ivan, 5.5M, 3);
            BankAccount secondLoan = new LoanAccount(1000, firm, 5.5M, 3);

            List<BankAccount> accounts = new List<BankAccount>();
            accounts.Add(firstDeposit);
            accounts.Add(secondDeposit);
            accounts.Add(firstMortgage);
            accounts.Add(secondMortgage);
            accounts.Add(firstLoan);
            accounts.Add(secondLoan);
            
            foreach (var account in accounts)
            {
                decimal interestAmount = account.CalculateInterestAmount();
                Console.WriteLine(interestAmount);
            }
        }
    }
}