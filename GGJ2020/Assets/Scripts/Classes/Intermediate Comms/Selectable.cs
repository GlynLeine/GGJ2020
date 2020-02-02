using UnityEngine;
using UnityEngine.Events;

public class Selectable : MonoBehaviour
{
    public UnityEvent OnSelect;

    public void Select(){ OnSelect?.Invoke(); }
}