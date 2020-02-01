public interface ICursable
{
    bool IsCursed();
    bool TryRepair(ISpell spell);
    string GetRepairableType();
}
