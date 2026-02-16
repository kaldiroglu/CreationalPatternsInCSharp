namespace Problem
{
    using System;
    using Customer;

    public class Test
    {
        public static void Main(string[] args)
        {
            // Normal credit account
            Account normalAccount = new Account("1", 1000, 1000, new Customer("Ali"), true, true, true);
            Console.WriteLine("Account in normal state: " + normalAccount);

            // Negative credit account
            Account negativeAccount = new Account("2", -500, 1000, new Customer("Zeynep"), true, true, false);
            Console.WriteLine("Account in negative state: " + negativeAccount);

            // Frozen account
            Account frozenAccount = new Account("3", -1000, 1000, new Customer("Metin"), false, false, false);
            Console.WriteLine("Account in frozen state: " + frozenAccount);
        }
    }
}
