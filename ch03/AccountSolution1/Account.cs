namespace Solution1
{
    using System;
    using Customer;

    public class Account : ICloneable
    {
        protected string iban;
        protected double balance;
        protected double credit;
        protected Customer owner;

        // Important state variables
        private bool openToWithdraw;
        private bool openToPayment;
        private bool openToTransfer;

        public Account(string iban, double balance, double credit, Customer owner, bool openToWithdraw,
                       bool openToPayment, bool openToTransfer)
        {
            this.iban = iban;
            this.balance = balance;
            this.credit = credit;
            this.owner = owner;
            this.openToWithdraw = openToWithdraw;
            this.openToPayment = openToPayment;
            this.openToTransfer = openToTransfer;
        }

        public string Iban
        {
            get { return iban; }
            set { iban = value; }
        }

        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public Customer Owner
        {
            get { return owner; }
            set { owner = value; }
        }

        public bool IsOpenToWithdraw
        {
            get { return openToWithdraw; }
            set { openToWithdraw = value; }
        }

        public bool IsOpenToPayment
        {
            get { return openToPayment; }
            set { openToPayment = value; }
        }

        public bool IsOpenToTransfer
        {
            get { return openToTransfer; }
            set { openToTransfer = value; }
        }

        public override string ToString()
        {
            return "Account{" +
                    "iban='" + iban + '\n' +
                    ", balance=" + balance +
                    ", credit=" + credit +
                    ", owner=" + owner +
                    ", openToWithdraw=" + openToWithdraw +
                    ", openToPayment=" + openToPayment +
                    ", openToTransfer=" + openToTransfer +
                    '}';
        }

        public object Clone()
        {
            Account cloneAccount = null;
            try
            {
                // This creates a shallow copy of the existing Account object
                cloneAccount = (Account)this.MemberwiseClone();
                // Make sure that iban should be changed and a new owner is assigned!
                cloneAccount.Iban = "-1";
                cloneAccount.owner = null;
            }
            catch (Exception e)
            {
                Console.WriteLine("Problem when cloning the object: " + e.Message);
                Console.WriteLine(e.ToString());
            }
            return cloneAccount;
        }
    }
}
