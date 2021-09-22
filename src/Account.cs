using System;

namespace BankingApp
{
  public abstract class Account
  {
    public string Name;
    public double InitialBalance;

    public abstract void CreateAccount();

  }
}