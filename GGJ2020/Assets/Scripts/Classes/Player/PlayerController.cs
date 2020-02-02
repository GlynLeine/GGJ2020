using UnityEngine;
using System;

class PlayerController : MonoBehaviour
{
    [SerializeField]
    private PlayerState playerState;

    private static Action<Vector2> onClick;

    private static Spell selectedSpell;

    public static Spell GetSelectedSpell()
    {
        return selectedSpell;
    }

    private void Start()
    {
        if(FindObjectsOfType<PlayerController>().Length > 1)
            DestroyImmediate(gameObject);

        DontDestroyOnLoad(gameObject);
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

    public void Select(Selectable selectable)
    {
        Spell spell = selectable.GetComponent<SpellContainer>()?.spell;

        if (spell != null)
            selectedSpell = spell;
        else
        {
            Cursable cursable = selectable.GetComponent<Cursable>();
            if (cursable != null)
            {
                if (selectedSpell != null)
                {
                    if (playerState.TryRepair(selectedSpell, cursable.GetRepairable()))
                    {
                        Debug.Log("yay?");
                    }
                    else
                    {
                        Debug.Log("nay!");
                    }
                    Debug.Log(selectedSpell);
                }
            }
            else
            {
                selectedSpell = null;
            }
        }
    }

    public static void SubscribeToOnClick(Action<Vector2> callback)
    {
        onClick += callback;
    }
}