using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ISpellBook
{
    public ISpell RequestSpell(string type);
}
