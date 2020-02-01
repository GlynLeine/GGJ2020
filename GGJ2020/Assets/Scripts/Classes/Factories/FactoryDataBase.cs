using UnityEngine;

[CreateAssetMenu(fileName = "New FactoryDatabase", menuName = "WizardInc/FactoryDatabase")]
public class FactoryDatabase : ScriptableObject
{
    [SerializeField]
    private RepairableFactory repairableFactory;

    [SerializeField]
    private CursablesFactory cursableFactory;

    [SerializeField]
    private CurseFactory curseFactory;

    [SerializeField]
    private InstructionFactory instructionFactory;

    public RepairableFactory GetRepairableFactory()
    {
        return repairableFactory;
    }

    public CursablesFactory GetCursablesFactory()
    {
        return cursableFactory;
    }

    public CurseFactory GetCurseFactory()
    {
        return curseFactory;
    }

    public InstructionFactory GetInstructionFactory()
    {
        return instructionFactory;
    }

}