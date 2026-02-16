namespace Solution3
{
    using Customer;

    public interface Factory
    {
        Account CreateNormalAccount();

        Account CreateNormalAccount(Customer owner, double balance);

        Account CreateNegativeAccount(Customer owner, double balance);

        Account CreateFrozenAccount(Customer owner, double balance);
    }
}
