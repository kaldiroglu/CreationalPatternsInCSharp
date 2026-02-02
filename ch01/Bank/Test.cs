using System;
using Dev.Kaldiroglu.Dp.Creational.Ch01.Bank;

internal static class Test
{
    private static void Main(string[] args)
    {
        
        // Create a BankLoan via its constructor (caller must supply totalRepayment correctly)
        const double principal = 10_000;
        const double rate = 0.02;
        const int months = 12;
        var totalRepayment = principal + (principal * rate * months);
        var bankLoan = new BankLoan(principal, rate, months, totalRepayment);
        Console.WriteLine($"Total repayment: {totalRepayment}");
        

        // Call the static factory method
        var loan = SecureLoan.Create(principal: 10_000, rate: 0.02, months: 12);
        Console.WriteLine($"Total repayment: {loan.TotalRepayment}");
    }
}
