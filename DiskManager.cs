using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class DiskManager : MonoBehaviour
{
    Rigidbody2D diskRigidbody;
    public int diskHiz;
    void Start()
    {
        diskRigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        diskRigidbody.AddForce(Vector2.right * diskHiz);  //sol (-1,0)



    }
}
