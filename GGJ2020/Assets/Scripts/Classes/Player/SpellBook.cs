using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Spellbook", menuName = "WizardInc/Spellbook")]
class SpellBook : ScriptableObject, ISpellBook
{
    [SerializeField]
    private List<ISpell> spells;

    public ISpell RequestSpell(string type)
    {
        // Request a spell from this spell book, return it if it is found

        return null;
    }
}
