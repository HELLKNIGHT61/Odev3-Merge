using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero_Teleport : MonoBehaviour
{
    public GameObject current_teleporter;


    private void Update() 
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            if(current_teleporter != null)
            {
                transform.position = current_teleporter.GetComponent<Teleport>().Destination().position;
            }
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Teleporter"))
        {
            current_teleporter = collision.gameObject;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {

        if (collision.gameObject.CompareTag("Teleporter"))
        {
            if(current_teleporter ==  collision.gameObject)
            {
                current_teleporter = null;
            }
        }
    }


}
