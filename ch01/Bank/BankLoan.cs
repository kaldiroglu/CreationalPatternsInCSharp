using System;

namespace Dev.Kaldiroglu.Dp.Creational.Ch01.Bank
{
    public sealed class BankLoan
    {
        private readonly double principal;
        private readonly double rate;
        private readonly int months;
        private readonly double totalRepayment;

        // If we use a standard constructor, the user has to calculate 'totalRepayment' manually.
        // This is "Easy to create" (just a constructor) but "Hard to use" (the user must know math).
        public BankLoan(double principal, double rate, int months, double totalRepayment)
        {
            if (totalRepayment != principal + (principal * rate * months))
                throw new ArgumentException("Math doesn't add up!");

            this.principal = principal;
            this.rate = rate;
            this.months = months;
            this.totalRepayment = totalRepayment;
        }
    }
}