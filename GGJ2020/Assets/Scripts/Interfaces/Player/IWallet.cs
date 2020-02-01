public interface IWallet
{
    void AddFunds();
    bool RequestFunds(int amount);
    int GetFunds();
}
