using UnityEngine;
using System.Collections.Generic;
using System;

public class RepairableFactory : ScriptableObject, IRepairableFactory
{
    [SerializeField]
    private IFactoryDataBase factoryDataBase;
    private ICursablesFactory cursableFactory;
    [SerializeField]
	private Dictionary<string, IRepairable> repairables;


    public IRepairable GetRepairable()
    {
        List<ICursable> cursables = cursableFactory.GetCursablesFactory();
        IRepairable repairable = repairables[cursables[0].GetRepairableType()];

        return (IRepairable)Activator.CreateInstance(repairable.GetType(), new object[]{cursables});
    }
}