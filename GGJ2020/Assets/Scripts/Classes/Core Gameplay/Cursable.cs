using UnityEngine;

[CreateAssetMenu(fileName = "New Cursable", menuName = "WizardInc/Curseable")]
public class Cursable : ScriptableObject, ICursable, ISelectable
{
    [SerializeField]
    private ICurse curse;

    [SerializeField]
    private string repairableType;

    public bool IsCursed()
    {
        //This boolean will add a curse to the object
        return false;
    }

    public void Select()
    {
        //Empty IMplementation
    }

    public bool TryRepair(ISpell spell)
    {
        //Try to repair the obejct that has been cursed
        return false;
    }
}