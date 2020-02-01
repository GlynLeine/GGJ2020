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
        repairableFactory = database.GetRepairableFactory();
    }

    public void OnRepair(Repairable repairable)
    {
        if (currentRepairable != null)
            DestroyImmediate(currentRepairable);

        currentRepairable = repairableFactory.GetRepairable();
        currentRepairable.SubscribeToOnRepair(OnRepair);
    }
}
