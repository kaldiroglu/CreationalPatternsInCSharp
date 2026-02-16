namespace Solution2
{
    using System;
    using Customer;

    public class AccountFactory : Factory
    {
        // Normal account
        private static Account prototype = new Account("1", 1000, 1000, new Customer("Ali"), true, true, true);

        /// <summary>
        /// Just creates a new account by cloning the prototype
        /// </summary>
        public Account Create()
        {
            // Just clone the prototype and return it
            return (Account)prototype.Clone();
        }

        /// <summary>
        /// Receives parameters to set the state of the cloned object
        /// </summary>
        public Account Create(Customer owner, double balance)
        {
            // First clone the prototype
            Account account = (Account)prototype.Clone();
            account.Owner = owner;
            account.Balance = balance;
            return account;
        }
    }
}
