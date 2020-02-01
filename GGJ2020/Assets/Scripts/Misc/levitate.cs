using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levitate : MonoBehaviour
{
    Vector2 position;

    public float bobDistance = 0.5f;
    public float bobSpeed = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        position = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = position + new Vector2(0, Mathf.Sin(Time.time * bobSpeed) * bobDistance);
    }
}
