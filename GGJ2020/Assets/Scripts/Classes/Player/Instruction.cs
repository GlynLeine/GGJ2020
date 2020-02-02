using System.Collections.Generic;
using System;
using UnityEngine;

public class Instruction
{
    private string instructionText;

    private Spell valSpell;
    private Repairable valRepairable;
    private List<Tuple<Cursable, Curse>> valCurses;

    public Instruction(string baseText, Spell spell, Repairable repairable, List<Tuple<Cursable, Curse>> curses)
    {

        valSpell = spell;
        valRepairable = repairable;
        valCurses = curses;
        // "SomeText <SpellWord> some more text <repairable> some more <curse0> blah <curse1> blah <curse2>"


        // Insert spell
        int spellPos = baseText.IndexOf("<SpellWord>");
        baseText = baseText.Remove(spellPos, 11);
        baseText = baseText.Insert(spellPos, spell.GetKeyWord());

        // Insert repairable
        int repairPos = baseText.IndexOf("<Repairable>");
        baseText = baseText.Remove(repairPos, 12);
        baseText = baseText.Insert(repairPos, repairable.GetKeyWord());

        for (int i = 0; i < curses.Count; i++)
        {
            int partPos = baseText.IndexOf("<Part" + i + ">");
            baseText = baseText.Remove(partPos, 7);
            baseText = baseText.Insert(partPos, curses[i].Item1.GetKeyWord());

            int cursePos = baseText.IndexOf("<Curse" + i + ">");
            baseText = baseText.Remove(cursePos, 8);
            baseText = baseText.Insert(cursePos, curses[i].Item2 != null ? curses[i].Item2.GetKeyWord() : "empty");
        }

        instructionText = baseText;
    }

    public bool Validate(Spell spell, Repairable repairable, List<Tuple<Cursable, Curse>> curses)
    {
        if (curses.Count != valCurses.Count)
            return false;

        bool valid = true;

        valid = valid && spell.GetKeyWord() == valSpell.GetKeyWord();
        valid = valid && repairable.GetKeyWord() == valRepairable.GetKeyWord();

        for (int i = 0; i < valCurses.Count; i++)
        {
            valid = valid && curses[i].Item1.GetKeyWord() == valCurses[i].Item1.GetKeyWord();

            if (valCurses[i].Item2 != null)
            {
                if (curses[i].Item2 != null)
                    valid = valid && curses[i].Item2.GetKeyWord() == valCurses[i].Item2.GetKeyWord();
                else
                    return false;
            }
        }

        return valid;
    }

    public List<Tuple<Cursable, Curse>> GetCombos()
    {
        return valCurses;
    }

    public string GetText()
    {
        return instructionText;
    }
}
