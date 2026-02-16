namespace Solution2
{
    using System;
    using Customer;

    public class Test
    {
        public static void Main(string[] args)
        {
            Factory factory = new AccountFactory();

            // Normal account. Credit amount is fixed at 1000.
            Account normalAccount = factory.Create(new Customer("Mustafa"), 2000);
            normalAccount.Iban = "2222";
            Console.WriteLine(normalAccount.IsOpenToWithdraw);
            Console.WriteLine(normalAccount.IsOpenToPayment);
            Console.WriteLine(normalAccount.IsOpenToTransfer);
            Console.WriteLine("Account in normal state: " + normalAccount);
            Console.WriteLine();

            // Negative account
            Account negativeAccount = factory.Create(new Customer("Namik"), 500);
            negativeAccount.Iban = "3333";
            negativeAccount.IsOpenToTransfer = false;
            Console.WriteLine(negativeAccount.IsOpenToWithdraw);
            Console.WriteLine(negativeAccount.IsOpenToPayment);
            Console.WriteLine(negativeAccount.IsOpenToTransfer);
            Console.WriteLine("Account in negative state: " + negativeAccount);

            Console.WriteLine();

            // Frozen account
            Account frozenAccount = factory.Create(new Customer("Zehra"), -5000);
            frozenAccount.Iban = "4444";
            frozenAccount.IsOpenToWithdraw = false;
            frozenAccount.IsOpenToPayment = false;
            frozenAccount.IsOpenToTransfer = false;
            Console.WriteLine(frozenAccount.IsOpenToWithdraw);
            Console.WriteLine(frozenAccount.IsOpenToPayment);
            Console.WriteLine(frozenAccount.IsOpenToTransfer);
            Console.WriteLine("Account in frozen state: " + frozenAccount);
        }
    }
}
