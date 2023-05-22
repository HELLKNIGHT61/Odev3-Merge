using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Full_Collider : MonoBehaviour
{


    GameObject hero;


    private void Awake()
    {
        hero = GameObject.Find("Hero");

    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Olum Col"))
        {
            Destroy(hero);
        }
    }




}


