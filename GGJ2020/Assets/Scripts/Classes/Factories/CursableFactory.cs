using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursableFactory : ScriptableObject
{
    private Dictionary<int, List<Cursable>> sets;

    [SerializeField]
    private FactoryDatabase factoryDatabase;

    [SerializeField]
    private CurseFactory curseFactory;

    private Dictionary<int, List<Cursable>> cursables = new Dictionary<int, List<Cursable>>();

    [SerializeField]
    private List<Cursable> sword = new List<Cursable>();
    [SerializeField]
    private List<Cursable> spear = new List<Cursable>();
    [SerializeField]
    private List<Cursable> staff = new List<Cursable>();
    [SerializeField]
    private List<Cursable> bow = new List<Cursable>();

    public CursableFactory()
    {
        cursables.Add(0, sword);
        cursables.Add(1, spear);
        cursables.Add(2, staff);
        cursables.Add(3, bow);
    }

    public List<Cursable> GetCursables()
    {
        return cursables[Random.Range(0, cursables.Count)];
    }
}
