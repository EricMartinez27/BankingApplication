using System;

namespace BankingApp
{
  public class Savings : Account
  {
    private double _savingsBalance;
    private double _interestRate = 1.2;
    // private int _numOfYears;
    public override void CreateAccount()
    {
      string savingsAccount = $"Account belongs to {Name} and initial balance is ${InitialBalance}.";
      Console.WriteLine(savingsAccount);
    }
    public void Forecast(int NumOfYears)
    {

      _savingsBalance = InitialBalance * (Math.Pow((1 + (_interestRate / 100) / 12), NumOfYears * 12));
      Console.WriteLine($"Forcasted amount at a rate of {_interestRate}% compounded 12 times per year over {NumOfYears} for {Name} is: {_savingsBalance.ToString("C2")}");
    }
  }


}