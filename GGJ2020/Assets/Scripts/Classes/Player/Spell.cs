using UnityEngine;

public class Spell : ScriptableObject
{
    [SerializeField]
    private string type;

    public string GetSpellType()
    {
        return type;
    }
}
