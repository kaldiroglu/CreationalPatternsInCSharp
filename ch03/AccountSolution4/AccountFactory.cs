namespace AccountSolution4
{
    using Customer;
    using System; // Required for ICloneable and Exception

    public class AccountFactory : Factory
    {
        public Account CreateNormalAccount()
        {
            return (Account)AccountPrototypes.normalPrototype.Clone();
        }

        public Account CreateNormalAccount(Customer owner, double balance)
        {
            Account account = (Account)AccountPrototypes.normalPrototype.Clone();
            account.Owner = owner;
            account.Balance = balance;
            return account;
        }

        public Account CreateNegativeAccount(Customer owner, double balance)
        {
            Account account = (Account)AccountPrototypes.negativePrototype.Clone();
            account.Owner = owner;
            account.Balance = balance;
            return account;
        }

        public Account CreateFrozenAccount(Customer owner, double balance)
        {
            Account account = (Account)AccountPrototypes.frozenPrototype.Clone();
            account.Owner = owner;
            account.Balance = balance;
            return account;
        }

        static class AccountPrototypes
        {
            // Normal account
            public static Account normalPrototype = new Account("1", 0, 1000, null, true, true, true);

            // Negative account
            public static Account negativePrototype = new Account("1", 0, 1000, null, true, true, false);

            // Frozen account
            public static Account frozenPrototype = new Account("1", -1000, 1000, null, false, false, false);
        }
    }
}
