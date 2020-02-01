using UnityEngine;
using System;

class PlayerController : MonoBehaviour, IPlayerController
{
    [SerializeField]
    private IPlayerState playerState;

    private Action<Vector2> onClick;

    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
            onClick?.Invoke(Input.mousePosition);
    }

    public void OnClick(Vector2 position)
    {
        //RayCast into scene and select selectable
    }

    public void OnRepair(IRepairable repairable)
    {
        //get transaction from repairable and pass it to playerstate
    }

    public void Select(ISelectable selectable)
    {
        // check if selectable has cursable or spell and change selected items
        // unselect selected items if none apply
        // if both a spell and selectable has been selected tryrepair
    }

    public void SubscribeToOnClick(Action<Vector2> callback)
    {
        onClick += callback;
    }
}