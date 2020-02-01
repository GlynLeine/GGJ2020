using UnityEngine;
using System;

interface IPlayerController
{
    void OnClick(Vector2 position);
    void OnRepair(Action<IRepairable> repairable);
    void Select(ISelectable selectable);
}