using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Repairable : MonoBehaviour
{
    private Transaction transaction;
    private Action<Repairable> onRepair;
    [SerializeField]
    private List<Cursable> cursables;

    [SerializeField]
    private string keyWord;

    private void Start()
    {
        transaction = new Transaction(cursables.Count);
    }

    public void Repair()
    {
        foreach(Cursable cursable in cursables)
            cursable.Repair();
        onRepair?.Invoke(this);
    }

    public int GetCursableCount()
    {
        return cursables.Count;
    }

    public Cursable GetCursable(int index)
    {
        return cursables[index];
    }

    public string GetKeyWord()
    {
        return keyWord;
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
