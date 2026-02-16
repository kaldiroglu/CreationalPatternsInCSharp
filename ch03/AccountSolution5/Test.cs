namespace Solution5
{
    using System;
    using Customer;

    public class Test
    {
        public static void Main(string[] args)
        {

            // Normal account. Credit amount is fixed at 1000.
            Account normalAccount = Account.CreateNormalAccount(new Customer("Remzi"), 4500);
            normalAccount.Iban ="2";
            Console.WriteLine(normalAccount.IsOpenToWithdraw);
            Console.WriteLine(normalAccount.IsOpenToPayment);
            Console.WriteLine(normalAccount.IsOpenToTransfer);
            Console.WriteLine("Account in normal state: " + normalAccount);

            Console.WriteLine();

            // Negative account
            Account negativeAccount = Account.CreateNegativeAccount(new Customer("Mustafa"), -750);
            Console.WriteLine(negativeAccount.IsOpenToWithdraw);
            Console.WriteLine(negativeAccount.IsOpenToPayment);
            Console.WriteLine(negativeAccount.IsOpenToTransfer);
            Console.WriteLine("Account in negative state: " + negativeAccount);

            Console.WriteLine();
            // Frozen default account
            Account frozenAccount = Account.CreateFrozenAccount(new Customer("Sukran"), -1000);
            Console.WriteLine(frozenAccount.IsOpenToWithdraw);
            Console.WriteLine(frozenAccount.IsOpenToPayment);
            Console.WriteLine(frozenAccount.IsOpenToTransfer);
            Console.WriteLine("Account in frozen state: " + frozenAccount);
        }
    }
}
