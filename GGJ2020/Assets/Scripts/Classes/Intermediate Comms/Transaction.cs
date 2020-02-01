using UnityEngine;

class Transaction : MonoBehaviour, ITransaction
{
    [SerializeField]
    private int value;

    public int GetValue()
    {
        return value;
    }
}