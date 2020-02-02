using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class daytimer : MonoBehaviour
{
    public float DayLength = 180.0f;
    public string SceneName;

    // Start is called before the first frame update
    void Start()
    {
        //
    }

    // Update is called once per frame
    void Update()
    {
        DayLength -= Time.deltaTime;
        if (DayLength < 0)
        {
            SceneManager.LoadScene(SceneName);
            
        }
    }
}
