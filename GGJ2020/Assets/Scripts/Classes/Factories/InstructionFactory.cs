using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "New InstructionFactory", menuName = "WizardInc/InstructionFactory")]
public class InstructionFactory : ScriptableObject
{
    [SerializeField]
    private List<Spell> spells;
    [SerializeField]
    private List<Repairable> repairables;
    [SerializeField]
    private List<Curse> curses;


    public Instruction GetInstruction()
    {
        return null;// new Instruction();
    }
}

