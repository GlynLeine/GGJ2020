using UnityEngine;
using System.Collections.Generic;

public class InstructionFactory : ScriptableObject
{
    [SerializeField]
    List<Instruction> instructions;

    public Instruction GetInstruction()
    {
        return instructions[Random.Range(0, instructions.Count-1)];
    }
}

