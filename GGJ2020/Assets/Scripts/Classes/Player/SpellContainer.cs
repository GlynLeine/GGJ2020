using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class SpellContainer : MonoBehaviour
{
    public SpriteRenderer renderer;

    private static System.Action deselect;

    public Spell spell;
    public Color spellColor;

    private void Start()
    {
        deselect += Deselect;
    }

    public void Select()
    {
        Debug.Log("sds");
        deselect?.Invoke();
        renderer.material.SetColor("_color", spellColor);
    }

    private void Deselect()
    {
        renderer.material.SetColor("_color", new Color(0,0,0));
    }

}
