using UnityEngine;
using UnityEngine.Events;

public class Cursable : MonoBehaviour
{
    [SerializeField]
    private Curse curse;

    [SerializeField]
    private Repairable repairable;

    [SerializeField]
    private string keyWord;

    private Material defaultMat;

    public void SetCurse(Curse curse)
    {
        this.curse = curse;
        if(curse == null)
            return;

        defaultMat = GetComponent<Renderer>().sharedMaterial;
        GetComponent<Renderer>().sharedMaterial = curse.GetMaterial();
    }

    public Curse GetCurse()
    {
        return curse;
    }

    public string GetKeyWord()
    {
        return keyWord;
    }

    public bool IsCursed()
    {
        //This boolean will add a curse to the object
        return curse != null;
    }

    public Repairable GetRepairable()
    {
        return transform.parent.GetComponent<Repairable>();
    }

    public void Repair()
    {
        curse = null;
        GetComponent<Renderer>().sharedMaterial = defaultMat;
    }
}