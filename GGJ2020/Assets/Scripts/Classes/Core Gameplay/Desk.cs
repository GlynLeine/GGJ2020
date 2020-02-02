using UnityEngine;
using UnityEngine.SceneManagement;

class Desk : MonoBehaviour
{
    [SerializeField]
    private FactoryDatabase database;
    [SerializeField]
    private PlayerState playerState;

    private InstructionBook instructionBook;

    private Repairable currentRepairable;
    private RepairableFactory repairableFactory;

    void OnEnable()
    {
        instructionBook = playerState.GetInstructionBook();
        instructionBook.Init();
        OnRepair(null);
    }

    public void OnRepair(Repairable repairable)
    {
        Debug.Log("New Item");

        if (repairableFactory == null)
            repairableFactory = database.GetRepairableFactory();

        if (currentRepairable != null)
        {
            Destroy(currentRepairable.gameObject);

            playerState.MakeTransaction(currentRepairable.GetCost());
        }

        currentRepairable = repairableFactory.GetRepairable(instructionBook);
        currentRepairable.SubscribeToOnRepair(OnRepair);
    }
}
