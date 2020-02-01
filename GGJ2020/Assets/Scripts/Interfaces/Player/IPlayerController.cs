using UnityEngine;
using System;

interface IPlayerController
{
    void OnClick(Vector2 position);
    void OnRepair(IRepairable repairable);
    void Select(ISelectable selectable);

    void SubscribeToOnClick(Action<Vector2> callback);
}