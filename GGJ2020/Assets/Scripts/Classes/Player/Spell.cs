using UnityEngine;

[CreateAssetMenu(fileName = "New Spell", menuName = "WizardInc/Spell")]
public class Spell : ScriptableObject
{
    [SerializeField]
    private string type;

    public string GetSpellType()
    {
        return type;
    }
}
