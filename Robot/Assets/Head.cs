using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Head : MonoBehaviour
{
    private Vector3 mouse;
    // Start is called before the first frame update
    void Start()
    {
        mouse = Input.mousePosition;
    }

    // Update is called once per frame
    void Update()
    {
        mouse = Input.mousePosition;
        mouse.z = -20.0f;
        
        Vector3 world = -Camera.main.ScreenToWorldPoint(mouse);
        world.y *= -1;
        world.x *= -1;

        transform.LookAt(world);

        //Vector3 dir = transform.InverseTransformPoint(mouse);
        //Vector3 me = Vector3.forward;
        //Vector3 axis = Vector3.Cross(me, dir);
        //float angle = Vector3.Angle(me, dir);
        ////float angle = (float)(180 * Mathf.Acos(Vector3.Dot(me.normalized, dir.normalized)) / Mathf.PI);
        //transform.Rotate(axis, angle);

    }
}
