using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.LWRP;

public class flame : MonoBehaviour
{
    public Light2D light;
    private float radius;

    private void Start()
    {
        radius = light.pointLightOuterRadius;
    }

    // Update is called once per frame
    void Update()
    {
        light.pointLightOuterRadius = radius + Mathf.PerlinNoise(Time.time*2, Time.time) * 2 - 1;
    }
}
