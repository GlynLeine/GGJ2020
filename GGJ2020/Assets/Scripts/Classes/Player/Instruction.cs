using UnityEngine;

public class Instruction : ScriptableObject, IInstruction
{
    [SerializeField, TextArea]
    private string instructionText;

    public string GetText()
    {
        return instructionText;
    }
}
