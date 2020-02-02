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

    [SerializeField]
    private AudioClip curseClip;
    [SerializeField]
    private AudioClip repairClip;

    public bool TryRepair(Spell spell)
    {
        return requiredSpell.GetKeyWord() == spell.GetKeyWord();
    }

    public Material GetMaterial()
    {
        return material;
    }

    public AudioClip GetCurseClip()
    {
        return curseClip;
    }
    
    public AudioClip GetRepairClip()
    {
        return repairClip;
    }
}
