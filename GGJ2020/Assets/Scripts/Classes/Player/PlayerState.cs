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
        // get value from transaction
        // check if value is negative
        // add or request funds
    }
}