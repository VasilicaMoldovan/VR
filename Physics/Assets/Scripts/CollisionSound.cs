using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class CollisionSound : MonoBehaviour
{
    private AudioSource source;

    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if ( collision.gameObject.name.Equals("collider1") || collision.gameObject.name.Equals("collider2"))
        {
            source.Play();
        }
    }

    void Update()
    {
        
    }
}
