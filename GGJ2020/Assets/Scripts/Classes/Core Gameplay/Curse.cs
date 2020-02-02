using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Curse", menuName = "WizardInc/Curse")]
public class Curse : ScriptableObject
{
    [SerializeField]
    private Material material;

    [SerializeField]
    private AudioClip curseClip;
    [SerializeField]
    private AudioClip repairClip;

    [SerializeField]
    string keyWord;

    public Material GetMaterial()
    {
        return material;
    }

    public AudioClip GetCurseClip()
    {
        return curseClip;
    }
    
    public AudioClip GetRepairClip()
    {
        return repairClip;
    }

    public string GetKeyWord()
    {
        return keyWord;
    }
}
