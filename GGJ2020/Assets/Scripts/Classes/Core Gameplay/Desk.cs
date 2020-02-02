using UnityEngine;

class Desk : MonoBehaviour
{
    [SerializeField]
    private FactoryDatabase database;

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

        currentRepairable = repairableFactory.GetRepairable();
        currentRepairable.SubscribeToOnRepair(OnRepair);
    }
}
