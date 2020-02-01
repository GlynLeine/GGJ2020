using UnityEngine;

class Desk : MonoBehaviour, IDesk
{
    private IRepairable currentRepairable;
    private IRepairableFactory repairableFactory;

    public void OnRepair()
    {
        // Repair the current repairable item
    }
}
