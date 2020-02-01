using UnityEngine;

public class PlayerState : MonoBehaviour, IPlayerState
{
    [SerializeField]
    private ISpellBook spellBook;
    [SerializeField]
    private IWallet wallet;
    [SerializeField]
    private IInstructionBook instructionBook;

    public void MakeTransaction(ITransaction transaction)
    {
        // get value from transaction
        // check if value is negative
        // add or request funds
    }
}