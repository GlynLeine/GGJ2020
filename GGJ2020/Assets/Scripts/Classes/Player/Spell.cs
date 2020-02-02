using UnityEngine;

[CreateAssetMenu(fileName = "New Spell", menuName = "WizardInc/Spell")]
public class Spell : ScriptableObject
{
    [SerializeField]
    private string keyWord;

    public string GetKeyWord()
    {
        return keyWord;
    }
}
