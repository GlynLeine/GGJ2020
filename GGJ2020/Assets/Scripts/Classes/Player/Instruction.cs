using UnityEngine;

public class Instruction : ScriptableObject
{
    [SerializeField, TextArea]
    private string instructionText;

    public string GetText()
    {
        return instructionText;
    }
}
