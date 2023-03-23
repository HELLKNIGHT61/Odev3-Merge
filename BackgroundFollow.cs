using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundFollow : MonoBehaviour
{

    public Transform otherTransform;



    void LateUpdate()
    {
        transform.position = new Vector3(otherTransform.position.x, 0, 10);
    }
}
