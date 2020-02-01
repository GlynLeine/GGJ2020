using UnityEngine;

public class Transaction : MonoBehaviour
{
    [SerializeField]
    private int value;

    public Transaction(int value)
    {
        this.value = value;
    }

    public int GetValue()
    {
        return value;
    }
}