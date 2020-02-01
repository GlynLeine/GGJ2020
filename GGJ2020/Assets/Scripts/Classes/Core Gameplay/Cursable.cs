using UnityEngine;

public class Cursable : MonoBehaviour
{
    [SerializeField]
    private Curse curse;

    [SerializeField]
    private Repairable repairable;


    public void SetCurse(Curse curse)
    {
        this.curse = curse;
    }

    public bool IsCursed()
    {
        //This boolean will add a curse to the object
        return curse != null;
    }

    public bool TryRepair(Spell spell)
    {
        //Try to repair the obejct that has been cursed
        if(curse.TryRepair(spell))
        {
            curse = null;
            return true;
        }
        return false;
    }
}