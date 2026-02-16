namespace CopyConstructor;

using System;
using Customer;

public class Account
{
    protected string iban;
    protected double balance;
    protected double credit;
    protected Customer? owner;

    // Important state variables
    private bool openToWithdraw;
    private bool openToPayment;
    private bool openToTransfer;

    public Account(
        string iban,
        double balance,
        double credit,
        Customer owner,
        bool openToWithdraw,
        bool openToPayment,
        bool openToTransfer)
    {
        this.iban = iban;
        this.balance = balance;
        this.credit = credit;
        this.owner = owner;
        this.openToWithdraw = openToWithdraw;
        this.openToPayment = openToPayment;
        this.openToTransfer = openToTransfer;
    }

    // Copy constructor (shallow copy for reference-type fields like owner)
    public Account(Account other)
    {
        if (other is null)
            throw new ArgumentNullException(nameof(other));

        iban = "-1"; // Make sure that a new id will be assigned
        balance = other.balance;
        credit = other.credit;
        owner = null; // Make sure that a new owner will be assigned
        openToWithdraw = other.openToWithdraw;
        openToPayment = other.openToPayment;
        openToTransfer = other.openToTransfer;
    }

    public string GetIban() => iban;
    public void SetIban(string iban) => this.iban = iban;

    public double GetBalance() => balance;
    public void SetBalance(double balance) => this.balance = balance;

    public Customer? GetOwner() => owner;
    public void SetOwner(Customer? owner) => this.owner = owner;

    public bool IsOpenToWithdraw() => openToWithdraw;
    public void SetOpenToWithdraw(bool openToWithdraw) => this.openToWithdraw = openToWithdraw;

    public bool IsOpenToPayment() => openToPayment;
    public void SetOpenToPayment(bool openToPayment) => this.openToPayment = openToPayment;

    public bool IsOpenToTransfer() => openToTransfer;
    public void SetOpenToTransfer(bool openToTransfer) => this.openToTransfer = openToTransfer;

    public override string ToString()
    {
        return "Account{" +
               $"iban='{iban}', " +
               $"balance={balance}, " +
               $"credit={credit}, " +
               $"owner={owner}, " +
               $"openToWithdraw={openToWithdraw}, " +
               $"openToPayment={openToPayment}, " +
               $"openToTransfer={openToTransfer}" +
               "}";
    }
}