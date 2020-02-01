using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ICursable
{
    public bool IsCursed();
    public bool TryRepair(ISpell spell);
}
