using UnityEngine;
public class Wallet : MonoBehaviour
{
    [SerializeField]
    private int value;

    public void AddFunds(int amount)
    {
        value += amount;
    }
    public bool RequestFunds(int amount)
    {
        if (value - amount >= 0)
        {
            value -= amount;
            return true;
        }
        return false;
    }
    public int GetFunds()
    {
        return value;
    }
}
