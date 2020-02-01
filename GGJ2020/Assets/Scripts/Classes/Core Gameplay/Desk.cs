using UnityEngine;

class Desk : MonoBehaviour
{
    private Repairable currentRepairable;
    private RepairableFactory repairableFactory;

    public void OnRepair(Repairable repairable)
    {
        if (currentRepairable != null)
            DestroyImmediate(currentRepairable);

        currentRepairable = repairableFactory.GetRepairable();
        currentRepairable.SubscribeToOnRepair(OnRepair);
    }
}
