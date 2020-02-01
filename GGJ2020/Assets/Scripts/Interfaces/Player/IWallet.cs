public interface IWallet
{
    void AddFunds(int amount);
    bool RequestFunds(int amount);
    int GetFunds(int amount);
}
