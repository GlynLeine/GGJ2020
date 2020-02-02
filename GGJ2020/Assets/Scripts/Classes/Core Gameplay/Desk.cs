using UnityEngine;

class Desk : MonoBehaviour
{
    [SerializeField]
    private FactoryDatabase database;
    [SerializeField]
    private InstructionBook instructionBook;

    private Repairable currentRepairable;
    private RepairableFactory repairableFactory;

    private void Start()
    {
        OnRepair(null);
    }

    public void OnRepair(Repairable repairable)
    {
        if (repairableFactory == null)
            repairableFactory = database.GetRepairableFactory();

        if (currentRepairable != null)
            Destroy(currentRepairable);

        currentRepairable = repairableFactory.GetRepairable(instructionBook);
        currentRepairable.SubscribeToOnRepair(OnRepair);
    }
}
