using System;

namespace BankingApp
{
    public class Checkings : Account
    {
        private double CheckingFunds = 0;
        private bool WithdrawalStatus = false;
        private int FailureCounter = 0;
        private const int PenaltyFee = 50;
        private string Date = "09/20/2021";
        private string TransactionType = "";
        private double MoneyFlow = 0;
        private string StatusFlow = "";
        private bool AccountFlag = true;

        public override void CreateAccount()
        {
            string checkingAccount = $"Account belongs to {Name} and initial balance is ${InitialBalance}.";
            Console.WriteLine(checkingAccount);
        }
        public void Deposit(double DepositAmount)
        {
            if (AccountFlag)
            {
                if (CheckingFunds == 0)
                {
                    TransactionType = "Inital Deposit";
                    StatusFlow = "Success";
                    CheckingFunds = InitialBalance + CheckingFunds;
                    MoneyFlow=CheckingFunds;
                }
                else
                {
                    MoneyFlow = DepositAmount;
                    CheckingFunds += DepositAmount;
                    StatusFlow = "Success";
                    TransactionType = "Deposit";
                }
            }
        }
        public void Withdraw(double WithdrawAmount)
        {
            if (AccountFlag)
            {
                if (CheckingFunds - WithdrawAmount > 0)
                {
                    MoneyFlow = WithdrawAmount;
                    CheckingFunds = CheckingFunds - WithdrawAmount;
                    WithdrawalStatus = true;
                }
                else if (WithdrawAmount > CheckingFunds)
                {
                    MoneyFlow = PenaltyFee;
                    StatusFlow = "Failed";
                    CheckingFunds = CheckingFunds - PenaltyFee;
                    TransactionType = "Fee";
                    Console.WriteLine($"Insuffient funds! Checking Balance: {CheckingFunds}");
                    FailureCounter += 1;
                    if (FailureCounter == 3)
                    {
                        NukeAccount();
                    }
                }

            }
        }
        public void GetTransactionHistory()
        {
            if (AccountFlag)
            {
                Console.WriteLine($"{Name}, {Date}, {TransactionType}, {MoneyFlow.ToString("C2")}, {StatusFlow}, {CheckingFunds.ToString("C2")}");
            }
        }
        public void NukeAccount()
        {
            {
                AccountFlag = false;
                Console.WriteLine("Your Account has been terminated.");

            }
        }
    }
}