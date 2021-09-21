using System;

namespace BankingApp
{
    public abstract class User
    {
        public string Name;
        public double InitialBalance;

        public abstract void CreateAccount();

    }
}