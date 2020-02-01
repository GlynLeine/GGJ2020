﻿using UnityEngine;
using System.Collections.Generic;

public class CurseFactory : ScriptableObject
{
    [SerializeField]
    private List<Curse> curses;

    public Curse GetCurse()
    {
        // It's exlcusive, so curses.Count - 1 actually restricts too much. (might be mistaken)
        return curses[Random.Range(0, curses.Count)];
    }
}