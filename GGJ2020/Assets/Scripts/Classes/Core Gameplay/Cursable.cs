using UnityEngine;

[CreateAssetMenu(fileName = "New Cursable", menuName = "WizardInc/Curseable")]
public class Cursable : ScriptableObject
{
    [SerializeField]
    private Curse curse;

    [SerializeField]
    private string repairableType;

    public bool IsCursed()
    {
        //This boolean will add a curse to the object
        return false;
    }

    public string GetRepairableType()
    {
        return repairableType;
    }

    public bool TryRepair(Spell spell)
    {
        //Try to repair the obejct that has been cursed
        return false;
    }
}