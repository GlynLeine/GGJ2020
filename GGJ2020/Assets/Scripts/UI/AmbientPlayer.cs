using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmbientPlayer : MonoBehaviour
{
    [SerializeField] private AudioSource _PhoneRinging = null;
    [SerializeField] private int _SecondsTillPhoneStarts = 4;
    private float timer = 0;
    private bool phonePlayed;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        timer = timer + Time.deltaTime;

        if (timer > _SecondsTillPhoneStarts && !phonePlayed)
        {
            _PhoneRinging.Play();
            phonePlayed = true;
        }

        if (timer > 40)
        {
            timer = 0;
        }
    }
}
