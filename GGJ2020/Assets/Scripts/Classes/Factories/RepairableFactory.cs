using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "New RepairableFactory", menuName = "WizardInc/RepairableFactory")]
public class RepairableFactory : ScriptableObject
{
    [SerializeField]
    private FactoryDatabase factoryDataBase;
    private CurseFactory curseFactory;
    [HideInInspector]
    public List<string> keys;
    [HideInInspector]
    public List<Repairable> repairables;


    public Repairable GetRepairable()
    {
        Repairable source = repairables[Random.Range(0, repairables.Count)];
        Repairable ret = Instantiate(source).GetComponent<Repairable>();

        Cursable[] cursables = ret.GetComponentsInChildren<Cursable>();
        for (int i = 0; i < cursables.Length; i++)
        {
            cursables[i].SetCurse(curseFactory.GetCurse());
        }

        return ret;
    }
}