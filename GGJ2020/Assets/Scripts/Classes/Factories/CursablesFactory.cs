using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New CursablesFactory", menuName = "WizardInc/CursablesFactory")]
public class CursablesFactory : ScriptableObject
{
    [SerializeField]
    private Dictionary<int, List<Cursable>> sets;

    [SerializeField]
    private FactoryDatabase factoryDataBase;

    [SerializeField]
    private CurseFactory curseFactory;

    public List<Cursable> GetCursables()
    {
        // TO DO: Write cursing logics like, somewhere. I don't really care. As long as it happens

        return sets[Random.Range(0, sets.Count)];
    }
}