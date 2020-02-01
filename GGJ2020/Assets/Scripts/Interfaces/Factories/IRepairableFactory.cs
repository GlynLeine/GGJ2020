using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IRepairableFactory
{
    public IRepairable GetRepairable();
}
