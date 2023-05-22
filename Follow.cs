using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    Rigidbody2D rb;
    Transform player;
    Vector3 direction;
    public float movespeed = 5.0f;
    public float patrolspeed = 2f;
    public Transform[] points;
    int current_point;
    


    void Awake()
    {

        rb = GetComponent<Rigidbody2D>();
        player = GameObject.Find("Hero").transform;
        current_point = 0;


    }

    private void Update()
    {
        //if (transform.position != points[current_point].position)
        //{
        //    transform.position = Vector3.MoveTowards(transform.position, points[current_point].position, patrolspeed * Time.deltaTime);
        //}
        //else
        //{
        //    current_point = (current_point + 1) % 2;
        //}
        
    }


    void Hareket()
    {

        //Vector3 direction = new Vector3(player.position.x - transform.position.x, 0f);
        //rb.velocity = direction;
    }

    


}
