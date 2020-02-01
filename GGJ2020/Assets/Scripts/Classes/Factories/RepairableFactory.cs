using UnityEngine;
using System.Collections.Generic;
using System;

[CreateAssetMenu(fileName = "New RepairableFactory", menuName = "WizardInc/RepairableFactory")]
public class RepairableFactory : ScriptableObject
{
    [SerializeField]
    private FactoryDatabase factoryDataBase;
    private CursablesFactory cursableFactory;
    [SerializeField]
	private Dictionary<string, Repairable> repairables;


    public Repairable GetRepairable()
    {
        List<Cursable> cursables = cursableFactory.GetCursables();
        Repairable repairable = repairables[cursables[0].GetRepairableType()];

        return (Repairable)Activator.CreateInstance(repairable.GetType(), new object[]{cursables});
    }
}