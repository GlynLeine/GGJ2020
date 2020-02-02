using System;
using System.Collections.Generic;
using UnityEngine;

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

    public bool Validate(Spell spell, Repairable repairable)
    {
        List<Tuple<Cursable, Curse>> cursableCombos = new List<Tuple<Cursable, Curse>>();

        Cursable[] cursables = repairable.GetComponentsInChildren<Cursable>();
        for (int i = 0; i < cursables.Length; i++)
        {
            cursableCombos.Add(new Tuple<Cursable, Curse>(cursables[i], cursables[i].GetCurse()));
        }

        foreach (Instruction instruction in instructions)
        {
            if (instruction.Validate(spell, repairable, cursableCombos))
            {
                foreach(Tuple<Cursable, Curse> combo in cursableCombos)
                {
                    combo.Item1.Repair();
                }
                return true;
            }
        }
        return false;
    }
}