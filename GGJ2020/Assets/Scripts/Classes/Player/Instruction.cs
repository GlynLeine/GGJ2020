using UnityEngine;

[CreateAssetMenu(fileName = "New Instructions", menuName = "WizardInc/Instructions")]
public class Instruction : ScriptableObject
{
    [SerializeField, TextArea]
    private string instructionText;

    public string GetText()
    {
        return instructionText;
    }
}
