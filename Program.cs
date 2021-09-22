using System;

namespace BankingApp
{
  class Program
  {
    static void Main(string[] args)
    {
      Savings user1Account = new() { Name = "Eric Martinez", InitialBalance = 10000.00 };
      user1Account.CreateAccount();
      user1Account.Forecast(3);

      Savings user2Account = new() { Name = "Kargen Fei", InitialBalance = 15000.00 };
      user2Account.CreateAccount();
      user2Account.Forecast(5);

      Checkings user1CheckingAccount = new() { Name = "Eric Martinez", InitialBalance = 10000.00 };
      user1CheckingAccount.CreateAccount();
      user1CheckingAccount.Deposit(500);
      user1CheckingAccount.GetTransactionHistory();
      user1CheckingAccount.Deposit(1000);
      user1CheckingAccount.GetTransactionHistory();
      user1CheckingAccount.Withdraw(50000);
      user1CheckingAccount.Withdraw(50000);
      user1CheckingAccount.Withdraw(50000);
      user1CheckingAccount.GetTransactionHistory();
      user1CheckingAccount.Deposit(1000);
      user1CheckingAccount.GetTransactionHistory();

    }
  }
}
