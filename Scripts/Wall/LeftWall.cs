using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftWall : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D col)
    {
        
        float x =this.transform.position.x;
        if (col.gameObject.tag.Equals("Player"))
        {
            col.gameObject.transform.position = new Vector3(-x - 0.35f, col.gameObject.transform.position.y, col.gameObject.transform.position.z);
        }
    }
}
