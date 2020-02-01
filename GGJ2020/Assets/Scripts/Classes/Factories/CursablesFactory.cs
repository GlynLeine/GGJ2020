using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New CursablesFactory", menuName = "WizardInc/CursablesFactory")]
public class CursableFactory : ScriptableObject, ICursablesFactory
{
    [SerializeField]
    private IFactoryDataBase factoryDataBase;

    [SerializeField]
    private ICurseFactory curseFactory;

    [SerializeField]
    private List<ICursable> cursables;

    public List<ICursable> GetCursablesFactory()
    {
        //return random set of cursables that belong together
        return null;
    }
}