using UnityEngine;
public class Wallet : MonoBehaviour
{
    [SerializeField]
    private int value;

    private int income;

    private void Start()
    {
        income = 0;
    }

    public int GetIncome()
    {
        return income;
    }

    public void AddFunds(int amount)
    {
        income += amount;
        value += amount;
    }

    public bool RequestFunds(int amount)
    {
        if (value - amount >= 0)
        {
            income -= amount;
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
