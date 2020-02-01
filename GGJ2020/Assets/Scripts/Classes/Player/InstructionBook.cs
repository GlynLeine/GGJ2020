using System;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New InstructionBook", menuName = "WizardInc/InstructionBook")]
class InstructionBook : MonoBehaviour
{
    [SerializeField]
    private FactoryDatabase factoryDatabase;
    private InstructionFactory instructionFactory;

    [SerializeField]
    private List<Instruction> instructions;

    public InstructionBook()
    {
        instructions = new List<Instruction>();
    }

    public void AddInstruction()
    {
        instructions.Add(instructionFactory.GetInstruction());
    }

    public Instruction GetInstruction(int pageNumber)
    {
        if (pageNumber >= 0 && pageNumber < instructions.Count)
            return instructions[pageNumber];
        return null;
    }
}