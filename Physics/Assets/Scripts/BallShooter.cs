using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallShooter : MonoBehaviour
{
    GameObject prefab;

    void Start()
    {
        prefab = Resources.Load("ball") as GameObject;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject ball = Instantiate(prefab) as GameObject;
            Vector3 aux = Camera.main.transform.forward;
            aux += new Vector3(0.0f, 2.0f, 0.0f);
            ball.transform.position = transform.position + Camera.main.transform.forward * 2;
            Rigidbody rb = ball.GetComponent<Rigidbody>();
            rb.velocity = aux * 5;
            rb.velocity += new Vector3(-30.0f, 0.0f, -10.0f);
            
        }
    }
}
