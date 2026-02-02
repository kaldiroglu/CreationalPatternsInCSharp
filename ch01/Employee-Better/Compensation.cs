using System;
using System.Numerics;

namespace Dev.Kaldiroglu.Dp.Creational.Ch01.Employee.Better
{
    public sealed class Compensation : IEquatable<Compensation>
    {
        public BigInteger Salary { get; }

        public Compensation(BigInteger? salary)
        {
            Salary = salary ?? BigInteger.Zero;
        }

        public bool Equals(Compensation? other)
            => other is not null && Salary.Equals(other.Salary);

        public override bool Equals(object? obj)
            => ReferenceEquals(this, obj) || (obj is Compensation other && Equals(other));

        public override int GetHashCode()
            => Salary.GetHashCode();
    }
}