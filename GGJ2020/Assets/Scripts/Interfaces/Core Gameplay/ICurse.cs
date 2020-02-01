using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ICurse
{
    bool TryRepair(ISpell spell);
}
