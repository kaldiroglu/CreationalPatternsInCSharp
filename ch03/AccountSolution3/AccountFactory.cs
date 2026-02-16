namespace Solution3
{
    using System;
    using Customer;

    public class AccountFactory : Factory
    {
        // Prototype Normal account
        private static Account prototype = new Account("1", 0, 1000, null, true, true, true);

        // Prototype Account in negative state
        private static Account negativePrototype = new Account("1", 0, 1000, null, true, true, false);

        // Prototype Account in frozen state
        private static Account frozenPrototype = new Account("1", -1000, 1000, null, false, false, false);

        public Account CreateNormalAccount()
        {
            return (Account)prototype.Clone();
        }

        public Account CreateNormalAccount(Customer owner, double balance)
        {
            Account account = (Account)prototype.Clone();
            account.Owner = owner;
            account.Balance = balance;
            return account;
        }

        public Account CreateNegativeAccount(Customer owner, double balance)
        {
            Account account = (Account)negativePrototype.Clone();
            account.Owner = owner;
            account.Balance = balance;
            return account;
        }

        public Account CreateFrozenAccount(Customer owner, double balance)
        {
            Account account = (Account)frozenPrototype.Clone();
            account.Owner = owner;
            account.Balance = balance;
            return account;
        }
    }
}
