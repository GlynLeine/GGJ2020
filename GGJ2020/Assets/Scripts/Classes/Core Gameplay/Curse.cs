using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Curse", menuName = "WizardInc/Curse")]
public class Curse : ScriptableObject
{
    [SerializeField]
    private Spell requiredSpell;

    [SerializeField]
    private Material material;

    public bool TryRepair(Spell spell)
    {
        return requiredSpell.GetSpellType() == spell.GetSpellType();
    }

    public Material GetMaterial()
    {
        return material;
    }
}
