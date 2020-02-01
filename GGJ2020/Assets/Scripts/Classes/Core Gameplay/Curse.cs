using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Curse", menuName = "WizardInc/Curse")]
public class Curse : ScriptableObject
{
    [SerializeField]
    private string requiredSpell;

    public bool TryRepair(Spell spell)
    {
        return requiredSpell == spell.GetSpellType();
    }
}
