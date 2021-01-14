﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Leg : MonoBehaviour
{
    private float v = 30.0f;
    private const float min = -15.0f;
    private const float max = 85.0f;
    private float angle = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float dt = Time.deltaTime;
        float dangle = v * dt;

        angle += dangle;

        if (angle < min || angle > max)
        {
            v *= -1.0f;
            dangle *= -1.0f;
            angle += 2 * dangle;
        }

        transform.Rotate(Vector3.right, dangle);

    }
}
