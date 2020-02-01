using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "New InstructionFactory", menuName = "WizardInc/InstructionFactory")]
public class InstructionFactory : ScriptableObject
{
    [SerializeField]
    private List<Instruction> instructions;

    public Instruction GetInstruction()
    {
        return instructions[Random.Range(0, instructions.Count)];
    }
}

