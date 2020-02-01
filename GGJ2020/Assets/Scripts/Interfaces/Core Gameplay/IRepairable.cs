using System;

public interface IRepairable
{
    ITransaction GetCost(ITransaction transaction);
    void SubscribeToOnRepair(Action<IRepairable> callback);
    void OnClick();
}