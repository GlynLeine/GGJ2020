using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System;
using System.Linq;
using UnityEngine;

public class Instruction
{
    private string instructionText;

    private Spell valSpell;
    private Repairable valRepairable;
    private List<Tuple<Cursable, Curse>> valCurses;

    public Instruction(string baseText, Spell spell, Repairable repairable, List<Tuple<Cursable, Curse>> curses)
    {
        // "SomeText <SpellWord> some more text <repairable> some more <curse0> blah <curse1> blah <curse2>"

        int spellPos = baseText.IndexOf("<SpellWord>");
        int repairPos = baseText.IndexOf("<Repairable>");
        int part1Pos = baseText.IndexOf("<Part0>");
        int part2Pos = baseText.IndexOf("<Part1>");
        int part3Pos = baseText.IndexOf("<Part2>");
        int curse1Pos = baseText.IndexOf("<Curse0>");
        int curse2Pos = baseText.IndexOf("<Curse1>");
        int curse3Pos = baseText.IndexOf("<Curse2>");

        // Insert spell
        baseText = baseText.Remove(spellPos, 11);
        baseText = baseText.Insert(spellPos, spell.GetKeyWord());

        // Insert repairable
        baseText = baseText.Remove(repairPos, 12);
        baseText = baseText.Insert(repairPos, spell.GetKeyWord());

        switch (curses.Count)
        {
            case 1:
                baseText = baseText.Remove(part1Pos, 7);
                baseText = baseText.Insert(part1Pos, curses[0].Item1.GetKeyWord());

                baseText = baseText.Remove(curse1Pos, 8);
                baseText = baseText.Insert(curse1Pos, curses[0].Item2?.GetKeyWord());
                break;

            case 2:
                baseText = baseText.Remove(part1Pos, 7);
                baseText = baseText.Insert(part1Pos, curses[0].Item1.GetKeyWord());
                baseText = baseText.Remove(part2Pos, 7);
                baseText = baseText.Insert(part2Pos, curses[1].Item1.GetKeyWord());

                baseText = baseText.Remove(curse1Pos, 8);
                baseText = baseText.Insert(curse1Pos, curses[0].Item2?.GetKeyWord());
                baseText = baseText.Remove(curse2Pos, 8);
                baseText = baseText.Insert(curse2Pos, curses[1].Item2?.GetKeyWord());
                break;

            case 3:
                baseText = baseText.Remove(part1Pos, 7);
                baseText = baseText.Insert(part1Pos, curses[0].Item1.GetKeyWord());
                baseText = baseText.Remove(part2Pos, 7);
                baseText = baseText.Insert(part2Pos, curses[1].Item1.GetKeyWord());
                baseText = baseText.Remove(part3Pos, 7);
                baseText = baseText.Insert(part3Pos, curses[2].Item1.GetKeyWord());

                baseText = baseText.Remove(curse1Pos, 8);
                baseText = baseText.Insert(curse1Pos, curses[0].Item2?.GetKeyWord());
                baseText = baseText.Remove(curse2Pos, 8);
                baseText = baseText.Insert(curse2Pos, curses[1].Item2?.GetKeyWord());
                baseText = baseText.Remove(curse3Pos, 8);
                baseText = baseText.Insert(curse3Pos, curses[2].Item2?.GetKeyWord());
                break;
        }

        this.instructionText = baseText;
    }

    public bool Validate(Spell spell, Repairable repairable, List<Tuple<Cursable, Curse>> curses)
    {
        if (curses.Count != valCurses.Count)
            return false;

        bool valid = true;

        valid = valid && spell.GetKeyWord() == valSpell.GetKeyWord();
        valid = valid && repairable.GetKeyWord() == valRepairable.GetKeyWord();

        if (!valid)
            return false;

        for(int i = 0; i < valCurses.Count; i++)
        {
            valid = valid && curses[i].Item1.GetKeyWord() == valCurses[i].Item1.GetKeyWord();
            valid = valid && curses[i].Item2.GetKeyWord() == valCurses[i].Item2.GetKeyWord();
        }

        return valid;
    }

    public string GetText()
    {
        return instructionText;
    }
}
