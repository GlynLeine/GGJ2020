using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Curse", menuName = "WizardInc/Curse")]
public class Curse : ScriptableObject, ICurse, ISelectable
{
    [SerializeField]
    private string curse;

    public void Select()
    {
        
    }

    public bool TryRepair(ISpell spell)
    {
        return curse == spell.GetType();
    }
}
