using System;

namespace Dev.Kaldiroglu.Dp.Creational.Ch01.Bank
{
    public sealed class SecureLoan
    {
        private readonly double _principal;
        private readonly double _rate;
        private readonly int _months;
        private readonly double _totalRepayment; // Calculated internally

        private SecureLoan(double principal, double rate, int months)
        {
            // Enforce basic rules via exceptions
            if (principal <= 0) throw new ArgumentOutOfRangeException(nameof(principal), "Principal must be positive");
            if (rate < 0) throw new ArgumentOutOfRangeException(nameof(rate), "Rate cannot be negative");
            if (months < 1) throw new ArgumentOutOfRangeException(nameof(months), "Term must be at least 1 month");

            _principal = principal;
            _rate = rate;
            _months = months;

            // Enforce the Relationship Invariant automatically
            _totalRepayment = principal + (principal * rate * months);
        }

        // Static Factory Method: The only way to create the object
        public static SecureLoan Create(double principal, double rate, int months)
        {
            return new SecureLoan(principal, rate, months);
        }

        // Getters only - no setters allowed to protect the invariants!
        public double TotalRepayment => _totalRepayment;
    }
}