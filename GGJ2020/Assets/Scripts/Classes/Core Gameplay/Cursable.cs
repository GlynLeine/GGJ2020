using UnityEngine;

public class Cursable : MonoBehaviour
{
    [SerializeField]
    private Curse curse;

    [SerializeField]
    private Repairable repairable;

    private Material defaultMat;


    public void SetCurse(Curse curse)
    {
        this.curse = curse;
        defaultMat = GetComponent<Renderer>().sharedMaterial;
        GetComponent<Renderer>().sharedMaterial = curse.GetMaterial();
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
            GetComponent<Renderer>().sharedMaterial = defaultMat;
            return true;
        }
        return false;
    }
}