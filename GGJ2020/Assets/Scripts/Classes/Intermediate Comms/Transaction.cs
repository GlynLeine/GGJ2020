using UnityEngine;

public class Transaction : MonoBehaviour
{
    [SerializeField]
    private int value;

    public int GetValue()
    {
        return value;
    }
}