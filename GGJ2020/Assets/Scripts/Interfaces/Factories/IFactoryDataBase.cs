public interface IFactoryDataBase
{
    IRepairableFactory GetRepairableFactory();
    ICursablesFactory GetCursableFactory();
    ICurseFactory GetCurseFactory();
    IInstructionFactory GetInstructionFactory();
}
