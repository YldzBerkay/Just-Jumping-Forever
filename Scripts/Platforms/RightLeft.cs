using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightLeft : MonoBehaviour
{
    private float platformSpeed = 2f;
    private bool endPoint;

    void FixedUpdate()
    {
        if (endPoint)
        {
            transform.position -= Vector3.right * platformSpeed * Time.deltaTime;
        }
        else
        {
            transform.position += Vector3.right * platformSpeed * Time.deltaTime;
            
        }

        if (transform.position.x <= -2f )
        {
            endPoint = false;
        }
        if (transform.position.x >= 2f)
        {
            endPoint = true;
        }
    }
}
