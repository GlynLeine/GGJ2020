using UnityEngine;
using System.Collections.Generic;

public class CurseFactory : ScriptableObject
{
    [SerializeField]
    private List<Curse> curses;

    public Curse GetCurse()
    {
        return curses[Random.Range(0, curses.Count-1)];
    }
}