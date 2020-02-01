using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Repairable : MonoBehaviour
{
    private Transaction transaction;
    private Action<Repairable> onRepair;
    private List<Cursable> cursables;

    public Repairable(Transaction transaction)
    {
        this.transaction = transaction;
        this.cursables = new List<Cursable>();
    }

    public void OnClick()
    {
        onRepair?.Invoke(this);
    }

    public void Select()
    {

    }

    public bool TryRepair(Spell spell)
    {
        // TO DO
        return false;
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
