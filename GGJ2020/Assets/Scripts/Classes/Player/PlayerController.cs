using UnityEngine;
using System;

class PlayerController : MonoBehaviour
{
    [SerializeField]
    private PlayerState playerState;

    private static Action<Vector2> onClick;

    private static Cursable selectedCursable;
    private static Spell selectedSpell;

    public static Cursable GetSelectedCursable()
    {
        return selectedCursable;
    }

    public static Spell GetSelectedSpell()
    {
        return selectedSpell;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            OnClick(Input.mousePosition);
            onClick?.Invoke(Input.mousePosition);
        }
    }

    public void OnClick(Vector2 mousePos)
    {
        Vector2 rayCastOrigin = Camera.main.ScreenToWorldPoint(mousePos);
        Collider2D hit = Physics2D.OverlapPoint(rayCastOrigin);

        if (hit != null)
        {
            Selectable selectable = hit.transform.GetComponent<Selectable>();
            Debug.Log(selectable);
            if (selectable != null)
                Select(selectable);
        }
    }

    public void OnRepair(Repairable repairable)
    {
        playerState.MakeTransaction(repairable.GetCost());
    }

    public void Select(Selectable selectable)
    {
        Spell spell = selectable.GetComponent<SpellContainer>()?.spell;

        if (spell != null)
            selectedSpell = spell;
        else
        {
            Cursable cursable = selectable.GetComponent<Cursable>();
            if (cursable != null)
                selectedCursable = cursable;
            else
            {
                selectedCursable = null;
                selectedSpell = null;
            }
        }

        if (selectedCursable != null && selectedSpell != null)
            if(playerState.TryRepair(selectedSpell, selectedCursable.GetRepairable()))
                Debug.Log("yay?");
    }

    public static void SubscribeToOnClick(Action<Vector2> callback)
    {
        onClick += callback;
    }
}