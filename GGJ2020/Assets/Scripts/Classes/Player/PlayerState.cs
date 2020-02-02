using UnityEngine;

public class PlayerState : MonoBehaviour
{
    [SerializeField]
    private Wallet wallet;
    [SerializeField]
    private InstructionBook instructionBook;

    public void MakeTransaction(Transaction transaction)
    {
        int value = transaction.GetValue();

        if(value > 0)
            wallet.AddFunds(value);
        else
            wallet.RequestFunds(value);
    }

    public InstructionBook GetInstructionBook()
    {
        return instructionBook;
    }

    public bool TryRepair(Spell spell, Repairable repairable)
    {
        if( instructionBook.Validate(spell, repairable))
        {
            repairable.Repair();
            return true;
        }
        return false;
    }
}