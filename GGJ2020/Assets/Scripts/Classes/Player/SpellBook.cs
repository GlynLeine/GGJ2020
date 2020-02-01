using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Spellbook", menuName = "WizardInc/Spellbook")]
class SpellBook : ScriptableObject
{
    [SerializeField]
    private List<Spell> spells;

    public Spell RequestSpell(string type)
    {
        // Request a spell from this spell book, return it if it is found

        return null;
    }
}
