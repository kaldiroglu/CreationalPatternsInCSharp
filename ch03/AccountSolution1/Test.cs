namespace Solution1
{
    using System;
    using Customer;

    public class Test
    {
        public static void Main(string[] args)
        {
            // A credit account in normal state
            Account accountInNormalState = new Account("1", 1000, 1000, new Customer("Ali"), true, true, true);
            Console.WriteLine("Account in normal state: " + accountInNormalState);

            // Another credit account in normal state. Credit amount is fixed at 1000.
            Account anotherAccountInNormalState = (Account)accountInNormalState.Clone();
            // Change some of its state
            anotherAccountInNormalState.Iban = "2";
            anotherAccountInNormalState.Balance = 2000;
            anotherAccountInNormalState.Owner = new Customer("Remzi");
            Console.WriteLine("Account in normal state: " + anotherAccountInNormalState);

            // Account in negative state
            Account accountInNegativeState = (Account)accountInNormalState.Clone();
            // Change some of its state
            accountInNegativeState.Iban = "4";
            accountInNegativeState.Balance = -600;
            accountInNegativeState.Owner = new Customer("Mustafa");
            // Arrange actions
            accountInNegativeState.IsOpenToWithdraw = true;
            accountInNegativeState.IsOpenToPayment = false;
            accountInNegativeState.IsOpenToTransfer = false;
            Console.WriteLine("Account in negative state: " + accountInNegativeState);

            // Account in frozen state
            Account accountInFrozenState = (Account)accountInNormalState.Clone();
            // Change some of its state
            accountInFrozenState.Iban = "5";
            accountInFrozenState.Balance = -1000;
            accountInFrozenState.Owner = new Customer("Sukran");
            // Arrange actions
            accountInFrozenState.IsOpenToWithdraw = false;
            accountInFrozenState.IsOpenToPayment = false;
            accountInFrozenState.IsOpenToTransfer = false;
            Console.WriteLine("Account in frozen state: " + accountInFrozenState);
        }
    }
}
