using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IRepairable
{
    ITransaction GetCost(ITransaction transaction);
    void SubscribeToOnRepair(Action callback);
    void OnClick();
}