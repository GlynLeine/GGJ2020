using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class daytimer : MonoBehaviour
{
    public float dayLength = 180.0f;
    public float countDown;
    public float fadeTime = 1f;
    public string sceneName;

    public Image blackScreen;

    // Start is called before the first frame update
    void Start()
    {
        blackScreen.color = new Color(0, 0, 0, 1);
        countDown = dayLength;
    }

    // Update is called once per frame
    void Update()
    {
        countDown -= Time.deltaTime;

        if(dayLength - countDown < fadeTime)
        {
            blackScreen.color = new Color(0, 0, 0, (fadeTime - (dayLength - countDown)) / fadeTime);
        }

        if (countDown < fadeTime)
        {
            blackScreen.color = new Color(0, 0, 0, (fadeTime - countDown) / fadeTime);
        }

        if (countDown < 0)
        {
            SceneManager.LoadScene(sceneName);
        }
    }
}
