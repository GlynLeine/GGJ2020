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


    public Repairable GetRepairable(InstructionBook instructionBook)
    {
        if (curseFactory == null)
            curseFactory = factoryDataBase.GetCurseFactory();

        Repairable source = repairables[Random.Range(0, repairables.Count)];
        Repairable ret = Instantiate(source).GetComponent<Repairable>();

        Instruction instruction = instructionBook.GetInstruction(Random.Range(0, instructionBook.GetPageCount()));

        List<System.Tuple<Cursable, Curse>> combos = instruction.GetCombos();

        Cursable[] cursables = ret.GetComponentsInChildren<Cursable>();
        for (int i = 0; i < cursables.Length; i++)
            foreach (System.Tuple<Cursable, Curse> combo in combos)
            {
                if(cursables[i].GetKeyWord() == combo.Item1.GetKeyWord())
                    cursables[i].SetCurse(combo.Item2);
            }

        return ret;
    }
}