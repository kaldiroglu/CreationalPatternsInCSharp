namespace AccountSolution4
{
    using System;
    using Customer;

    public class Test
    {
        private static Factory factory = new AccountFactory();

        private static void Main(string[] args)
        {

            // Normal account. Credit amount is fixed at 1000.
            Account normalAccount = factory.CreateNormalAccount();
            normalAccount.Iban = "2";
            normalAccount.Balance = 2000;
            normalAccount.Owner = new Customer("Remzi");
            Console.WriteLine("Account in normal state: " + normalAccount);

            // Negative account
            Account negativeAccount = factory.CreateNegativeAccount(new Customer("Mustafa"), -750);
            Console.WriteLine("Account in negative state: " + negativeAccount);

            // Frozen default account
            Account frozenAccount = factory.CreateFrozenAccount(new Customer("Sukran"), -1000);
            Console.WriteLine("Account in frozen state: " + frozenAccount);
        }
    }
}
