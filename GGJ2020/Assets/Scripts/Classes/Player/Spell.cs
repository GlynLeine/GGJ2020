using UnityEngine;

class Spell : ScriptableObject, ISpell
{
    [SerializeField]
    private string type;

    string ISpell.GetType()
    {
        return type;
    }
}
