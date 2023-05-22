using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump_Collider : MonoBehaviour
{
    
    GameObject enemy;

    private void Awake()
    {
        
        enemy = GameObject.FindWithTag("Enemy Pr");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Zip Col"))
        {
            Destroy(enemy);

        }

        
    } 



}
