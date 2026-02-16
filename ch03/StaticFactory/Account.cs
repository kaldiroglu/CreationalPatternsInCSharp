namespace Account.StaticFactory
{
    using Customer;
    using System; // For potential use of Console.WriteLine in ToString, though not directly used here

    public class Account
    {
        protected string iban;
        protected double balance;
        protected double credit;
        protected Customer owner;

        private bool openToWithdraw;
        private bool openToPayment;
        private bool openToTransfer;

        /// <summary>
        /// Creates an Account object with credit amount passed
        /// </summary>
        private Account(string iban, double balance, double credit, Customer owner, bool openToWithdraw,
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

        /// <summary>
        /// Creates an Account object with no credit
        /// </summary>
        private Account(string iban, double balance, Customer owner, bool openToWithdraw,
                        bool openToPayment, bool openToTransfer)
        {
            this.iban = iban;
            this.balance = balance;
            this.owner = owner;
            this.openToWithdraw = openToWithdraw;
            this.openToPayment = openToPayment;
            this.openToTransfer = openToTransfer;
        }

        /// <summary>
        /// Creates an account in a normal state
        /// </summary>
        public static Account CreateNormalAccount(string iban, double balance, double credit, Customer owner)
        {
            return new Account(iban, balance, credit, owner, true, true, true);
        }

        /// <summary>
        /// Creates an account in a negative state
        /// </summary>
        public static Account CreateNegativeAccount(string iban, double balance, double credit, Customer owner)
        {
            return new Account(iban, balance, credit, owner, true, false, false);
        }

        /// <summary>
        /// Creates an account in a frozen state
        /// </summary>
        public static Account CreateFrozenAccount(string iban, double balance, double credit, Customer owner)
        {
            return new Account(iban, balance, credit, owner, false, false, false);
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
    }
}
