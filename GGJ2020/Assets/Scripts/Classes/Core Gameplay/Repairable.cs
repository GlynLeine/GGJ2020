using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Repairable : MonoBehaviour, IRepairable, ISelectable
{
    private ITransaction transaction;
    private Action<IRepairable> callback;
    private List<ICursable> cursables;

    public Repairable(ITransaction transaction)
    {
        this.transaction = transaction;
        this.cursables = new List<ICursable>();
    }

    public void OnClick()
    {
        callback?.Invoke(this);
    }

    public void Select()
    {

    }

    public bool TryRepair(ISpell spell)
    {
        // TO DO
        return false;
    }

    public void SubscribeToOnRepair(Action<IRepairable> callback)
    {
        this.callback = callback;
    }

    public ITransaction GetCost(ITransaction transaction)
    {
        return this.transaction;
    }
}
