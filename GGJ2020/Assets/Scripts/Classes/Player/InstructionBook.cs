using System;
using System.Collections.Generic;
using UnityEngine;

public class InstructionBook : MonoBehaviour
{
    [SerializeField]
    private FactoryDatabase factoryDatabase;
    private InstructionFactory instructionFactory;

    [SerializeField]
    private List<Instruction> instructions;

    private void Start()
    {
        instructions = new List<Instruction>();
        instructionFactory = factoryDatabase.GetInstructionFactory();

        for (int i = 0; i < 10; i++)
            AddInstruction(1);  
    }

    public void AddInstruction(int curseCount)
    {
        instructions.Add(instructionFactory.GetInstruction(curseCount));
    }

    public int GetPageCount()
    {
        return instructions.Count;
    }

    public Instruction GetInstruction(int pageNumber)
    {
        if (pageNumber >= 0 && pageNumber < instructions.Count)
            return instructions[pageNumber];
        return null;
    }

    public bool Validate(Spell spell, Repairable repairable)
    {
        Debug.Log("Validation");

        List<Tuple<Cursable, Curse>> cursableCombos = new List<Tuple<Cursable, Curse>>();

        Cursable[] cursables = repairable.GetComponentsInChildren<Cursable>();
        for (int i = 0; i < cursables.Length; i++)
            cursableCombos.Add(new Tuple<Cursable, Curse>(cursables[i], cursables[i].GetCurse()));


        Debug.Log(cursables.Length);

        foreach (Instruction instruction in instructions)
            if (instruction.Validate(spell, repairable, cursableCombos))
                return true;

        return false;
    }
}