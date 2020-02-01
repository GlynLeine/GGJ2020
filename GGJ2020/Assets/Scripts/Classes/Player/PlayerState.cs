using UnityEngine;

public class PlayerState : MonoBehaviour
{
    [SerializeField]
    private SpellBook spellBook;
    [SerializeField]
    private Wallet wallet;
    [SerializeField]
    private InstructionBook instructionBook;

    public void MakeTransaction(Transaction transaction)
    {
        int value = transaction.GetValue();

        if(value> 0)
            wallet.AddFunds(value);
        else
            wallet.RequestFunds(value);
    }
}