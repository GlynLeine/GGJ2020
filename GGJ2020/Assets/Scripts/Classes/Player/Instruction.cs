using UnityEngine;

[CreateAssetMenu(fileName = "New Instruction", menuName = "WizardInc/Instruction")]
public class Instruction : ScriptableObject
{
    [SerializeField, TextArea]
    private string instructionText;

    public string GetText()
    {
        return instructionText;
    }
}
