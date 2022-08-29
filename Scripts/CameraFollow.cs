using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private Transform cam;
    public float smoothSpeed = .3f;
    
    public static float positionY;

    void FixedUpdate(){
        positionY=cam.transform.position.y;
    }
    void LateUpdate()
    {
        if (target.position.y>transform.position.y)
        {
            Vector3 newPos = new Vector3(transform.position.x, target.position.y, transform.position.z);
                transform.position = newPos;
        }
    }
}
