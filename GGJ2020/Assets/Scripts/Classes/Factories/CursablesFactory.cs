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
        List<Cursable> list = new List<Cursable>();
        list.Add(cursables)
        //return random set of cursables that belong together: Blade, Gaurd, Hilt
        return cursables[Random.Range(0, cursables.Count)];
        //return null;
    }
}