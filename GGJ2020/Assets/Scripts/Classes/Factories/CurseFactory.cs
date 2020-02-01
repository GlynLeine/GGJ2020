using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "New CurseFactory", menuName = "WizardInc/CurseFactory")]
public class CurseFactory : ScriptableObject
{
    [SerializeField]
    private List<Curse> curses;

    public Curse GetCurse()
    {
        return curses[Random.Range(0, curses.Count)];
    }
}