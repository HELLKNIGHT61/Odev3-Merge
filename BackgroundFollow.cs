using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundFollow : MonoBehaviour
{

    public Transform playerTransform;



    void LateUpdate()
    {
        transform.position = new Vector3(playerTransform.position.x, 0, 10);
    }
}
