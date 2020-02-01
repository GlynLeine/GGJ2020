using System;
using System.Collections.Generic;
using UnityEngine;

class InstructionBook : MonoBehaviour, IInstructionBook
{
    public FactoryDatabase db;

    [SerializeField]
    private List<IInstruction> instructions;

    public InstructionBook()
    {
        instructions = new List<IInstruction>();
    }

    public void AddInstruction()
    {
        instructions.Add(db.GetComponent<FactoryDatabase>().GetInstructionFactory().GetInstruction());
    }

    public IInstruction GetInstruction(int pageNumber)
    {
        if (pageNumber >= 0 && pageNumber < instructions.Count)
            return instructions[pageNumber];
        return null;
    }
}