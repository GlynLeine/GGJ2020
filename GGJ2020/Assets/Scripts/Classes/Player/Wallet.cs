using UnityEngine;
public class Wallet : MonoBehaviour, IWallet
{
    [SerializeField]
    private int value;

    public void AddFunds(int amount) 
    {
        this.value += amount;
    }
    public bool RequestFunds(int amount) 
    {
        return value - amount >= 0;
    }
    public int GetFunds(int amount) 
    { 
        if(RequestFunds(amount))
        {
            this.value -= amount;
            return amount;
        }

        return 0;
    }
}
