using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    
    public Transform playerTransform;


    
    void LateUpdate()
    {
        transform.position = new Vector3(playerTransform.position.x, 0, -10);
    }
}
