using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New CursablesFactory", menuName = "WizardInc/CursablesFactory")]
public class CursablesFactory : ScriptableObject
{
    [SerializeField]
    private FactoryDatabase factoryDataBase;

    [SerializeField]
    private CurseFactory curseFactory;

    [SerializeField]
    private List<Cursable> cursables;

    public List<Cursable> GetCursables()
    {
        //return random set of cursables that belong together
        return null;
    }
}