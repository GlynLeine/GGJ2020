using System.Collections.Generic;
using System;

public class Instruction
{
    private string instructionText;

    public Instruction(string baseText, Spell spell, Repairable repairable, List<Tuple<Cursable, Curse>> curses)
    {
       // "SomeText <SpellWord> some more text <repairable> some more <curse0> blah <curse1> blah <curse2>"

        if(curses.Count == 1)
        {

        }
        else
        {

        }
    }

    public string GetText()
    {
        return instructionText;
    }
}
