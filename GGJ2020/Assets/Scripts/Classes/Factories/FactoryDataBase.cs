using UnityEngine;

[CreateAssetMenu(fileName = "New FactoryDatabase", menuName = "WizardInc/FactoryDatabase")]
public class FactoryDatabase : ScriptableObject, IFactoryDataBase
{
    [SerializeField]
    private IRepairableFactory repairableFactory;

    [SerializeField]
    private ICursablesFactory cursableFactory;

    [SerializeField]
    private ICurseFactory curseFactory;

    [SerializeField]
    private IInstructionFactory instructionFactory;

    public IRepairableFactory GetRepairableFactory()
    {
        return repairableFactory;
    }

    public ICursablesFactory GetCursableFactory()
    {
        return cursableFactory;
    }

    public ICurseFactory GetCurseFactory()
    {
        return curseFactory;
    }

    public IInstructionFactory GetInstructionFactory()
    {
        return instructionFactory;
    }

}