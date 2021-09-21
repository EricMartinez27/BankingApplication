using System;

namespace BankingApp
{
    public class Savings: User
    {
        private double SavingsBalance;
        private double InterestRate = 1.2;
        private int NumOfYears;
        public override void CreateAccount(){
          string s = $"Account belongs to {Name} and initial balance is ${InitialBalance}."; 
          Console.WriteLine(s);
        }
        public void Forecast(int NumOfYears){
          
          double SavingsBalance = InitialBalance *(Math.Pow((1 + (InterestRate /100)/12), NumOfYears * 12));
          Console.WriteLine($"Forcasted amount at a rate of {InterestRate}% compounded 12 times per year over {NumOfYears} for {Name} is: {SavingsBalance.ToString("C2")}");
        }
    }


}