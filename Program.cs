using System;

namespace BankingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Savings user1Account = new(){Name = "Eric Martinez", InitialBalance = 10000.00};
            user1Account.CreateAccount();
            user1Account.Forecast(3);

            Savings user2Account = new(){Name = "Kargen Fei", InitialBalance = 15000.00};
            user2Account.CreateAccount();
            user2Account.Forecast(5);

        }
    }
}
