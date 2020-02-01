using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Spellbook", menuName = "WizardInc/Spellbook")]
class SpellBook : ScriptableObject
{
    [SerializeField]
    private Dictionary<string, Spell> spells;

    public Spell RequestSpell(string type)
    {
        // Request a spell from this spell book, return it if it is found
        if(spells.ContainsKey(type))
            return spells[type];
        return null;
    }
}
