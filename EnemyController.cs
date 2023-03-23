using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EnemyController : MonoBehaviour
{
    public GameObject disk;
    public float timer_two;
    public int control;

    // Update is called once per frame
    void FixedUpdate()
    {
        timer_two += Time.deltaTime;

        if (Convert.ToInt32(timer_two) % 2 == 0)
        {
            if (control < Convert.ToInt32(timer_two))
            {
                Instantiate(disk, gameObject.transform.position, Quaternion.identity);

            }
            control = Convert.ToInt32(timer_two) + 1;
        }


    }
}
