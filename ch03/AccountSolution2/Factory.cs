namespace Solution2
{
    using Customer;

    public interface Factory
    {
        Account Create();

        // Receives parameters to set the state of the cloned object
        Account Create(Customer owner, double balance);
    }
}
