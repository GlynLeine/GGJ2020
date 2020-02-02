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

    [TextArea, SerializeField]
    private List<string> baseTexts;


    public Instruction GetInstruction(int curseCount)
    {
        curseCount = Mathf.Max(1, curseCount);

        Spell spell = spells[Random.Range(0, spells.Count)];
        Repairable repairable = repairables[Random.Range(0, repairables.Count)];
        List<System.Tuple<Cursable, Curse>> curseCombos = new List<System.Tuple<Cursable, Curse>>();

        for (int i = 0; i < repairable.GetCursableCount(); i++)
            curseCombos.Add(new System.Tuple<Cursable, Curse>(repairable.GetCursable(i), null));

        int comboIndex = Random.Range(0, curseCombos.Count);
        curseCombos[comboIndex] = new System.Tuple<Cursable, Curse>(curseCombos[comboIndex].Item1, curses[Random.Range(0, curses.Count)]);

        for (int i = 1; i < curseCount; i++)
        {
            comboIndex = Random.Range(0, curseCombos.Count);
            curseCombos[comboIndex] = new System.Tuple<Cursable, Curse>(curseCombos[comboIndex].Item1, curses[Random.Range(0, curses.Count)]);
        }

        string baseText = baseTexts[Random.Range(0, baseTexts.Count)];

        Instruction instruction = new Instruction(baseText, spell, repairable, curseCombos);

        return instruction;
    }
}

