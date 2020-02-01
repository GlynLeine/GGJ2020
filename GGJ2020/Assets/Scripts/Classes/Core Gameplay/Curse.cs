using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Curse", menuName = "WizardInc/Curse")]
public class Curse : ScriptableObject
{
    [SerializeField]
    private string curse;

    public bool TryRepair(Spell spell)
    {
        return curse == spell.GetSpellType();
    }
}
