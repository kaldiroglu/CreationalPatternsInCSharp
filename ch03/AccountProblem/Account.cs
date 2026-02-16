namespace Problem
{
    using Customer;

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

        /// <summary>
        /// Creates an Account object with no credit
        /// </summary>
        public Account(string iban, double balance, Customer owner, bool openToWithdraw,
                       bool openToPayment, bool openToTransfer)
        {
            this.iban = iban;
            this.balance = balance;
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
    }
}
