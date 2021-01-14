using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCameraScene1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public float thrust = 2.0f;

    void FixedUpdate()
    {
        if (transform.position.z > 1.9)
        {
            transform.position += this.transform.forward * thrust * Time.deltaTime;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
