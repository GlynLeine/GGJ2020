using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Repairable : MonoBehaviour
{
    private Transaction transaction;
    private Action<Repairable> onRepair;
    private List<Cursable> cursables;

    public Repairable(List<Cursable> cursables)
    {
        transaction = new Transaction(cursables.Count);
        this.cursables = cursables;
        PlayerController.SubscribeToOnClick(OnClick);
    }

    public void OnClick(Vector2 mousePos)
    {
        bool isCursed = false;
        foreach (Cursable cursable in cursables)
            isCursed = isCursed || cursable.IsCursed();
        if (!isCursed)
            onRepair?.Invoke(this);
    }

    public bool TryRepair(Spell spell)
    {
        return PlayerController.GetSelectedCursable().TryRepair(spell);
    }

    public void SubscribeToOnRepair(Action<Repairable> callback)
    {
        onRepair += callback;
    }

    public Transaction GetCost()
    {
        return transaction;
    }
}
