using UnityEngine;
using System.Collections.Generic;

class InstructionFactoy : ScriptableObject, IInstructionFactory
{
    [SerializeField]
    List<IInstruction> instructions;

    public IInstruction GetInstruction()
    {
        return instructions[Random.Range(0, instructions.Count-1)];
    }
}

