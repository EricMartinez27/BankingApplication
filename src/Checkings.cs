using System;

namespace BankingApp
{
  public class Checkings : Account
  {
    private double _checkingFunds = 0;
    private bool _withdrawalStatus = false;
    private int _failureCounter = 0;
    private const int _penaltyFee = 50;
    private string _date = "09/20/2021";
    private string _transactionType = "";
    private double _moneyFlow = 0;
    private string _statusFlow = "";
    private bool _accountFlag = true;

    public override void CreateAccount()
    {
      string checkingAccount = $"Account belongs to {Name} and initial balance is ${InitialBalance}.";
      Console.WriteLine(checkingAccount);
    }
    public void Deposit(double DepositAmount)
    {
      if (_accountFlag)
      {
        if (_checkingFunds == 0)
        {
          _transactionType = "Inital Deposit";
          _statusFlow = "Success";
          _checkingFunds = InitialBalance + _checkingFunds;
          _moneyFlow = _checkingFunds;
        }
        else
        {
          _moneyFlow = DepositAmount;
          _checkingFunds += DepositAmount;
          _statusFlow = "Success";
          _transactionType = "Deposit";
        }
      }
    }
    public void Withdraw(double WithdrawAmount)
    {
      if (_accountFlag)
      {
        if (_checkingFunds - WithdrawAmount > 0)
        {
          _moneyFlow = WithdrawAmount;
          _checkingFunds = _checkingFunds - WithdrawAmount;
          _withdrawalStatus = true;
        }
        else if (WithdrawAmount > _checkingFunds)
        {
          _moneyFlow = _penaltyFee;
          _statusFlow = "Failed";
          _checkingFunds = _checkingFunds - _penaltyFee;
          _transactionType = "Fee";
          Console.WriteLine($"Insuffient funds! Checking Balance: {_checkingFunds}");
          _failureCounter += 1;
          if (_failureCounter == 3)
          {
            NukeAccount();
          }
        }

      }
    }
    public void GetTransactionHistory()
    {
      if (_accountFlag)
      {
        Console.WriteLine($"{Name}, {_date}, {_transactionType}, {_moneyFlow.ToString("C2")}, {_statusFlow}, {_checkingFunds.ToString("C2")}");
      }
    }
    public void NukeAccount()
    {
      {
        _accountFlag = false;
        Console.WriteLine("Your Account has been terminated.");

      }
    }
  }
}