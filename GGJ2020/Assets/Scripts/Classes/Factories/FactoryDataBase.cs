using UnityEngine;

[CreateAssetMenu(fileName = "New FactoryDatabase", menuName = "WizardInc/FactoryDatabase")]
public class FactoryDatabase : ScriptableObject
{
    [SerializeField]
    private RepairableFactory repairableFactory;

    [SerializeField]
    private CurseFactory curseFactory;

    [SerializeField]
    private InstructionFactory instructionFactory;

    public RepairableFactory GetRepairableFactory()
    {
        return repairableFactory;
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