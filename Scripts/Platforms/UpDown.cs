using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpDown : MonoBehaviour
{
    private float platformSpeed = 2f;
    private bool endPoint;

    private float startPoint;
    private float endPointY;

    [SerializeField] private int unitsToMove = 2;
    void Start()
    {
        startPoint = transform.position.y;
        endPointY = startPoint + unitsToMove;

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (endPoint)
        {
            transform.position += Vector3.up * platformSpeed * Time.deltaTime;
        }
        else
        {
            transform.position -= Vector3.up * platformSpeed * Time.deltaTime;
        }

        if (transform.position.y >= endPointY)
        {
            endPoint = false;
        }

        if (transform.position.y <= startPoint)
        {
            endPoint = true;
        }
    }
}
