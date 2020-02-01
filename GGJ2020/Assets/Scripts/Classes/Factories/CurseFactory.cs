using UnityEngine;
using System.Collections.Generic;

public class CurseFactory : ScriptableObject, ICurseFactory
{
    [SerializeField]
    private IFactoryDataBase factoryDataBase;
    [SerializeField]
    private List<ICurse> curses;

    public ICurse GetCurse()
    {
        return curses[Random.Range(0, curses.Count-1)];
    }
}