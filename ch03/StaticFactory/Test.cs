namespace Account.StaticFactory
{
    using System;
    using Customer;

    public class Test
    {
        public static void Main(string[] args)
        {
            // Normal credit account
            Account accountInNormalState = Account.CreateNormalAccount("1", 1000, 1000, new Customer("Ali"));
            Console.WriteLine("Account in frozen state: " + accountInNormalState);

            // Negative credit account
            Account accountInNegativeState = Account.CreateNegativeAccount("2", -500, 1000, new Customer("Zeynep"));
            Console.WriteLine("Account in frozen state: " + accountInNegativeState);

            // Frozen account
            Account accountInFrozenState = Account.CreateFrozenAccount("3", -1000, 1000, new Customer("Metin"));
            Console.WriteLine("Account in frozen state: " + accountInFrozenState);
        }
    }
}
