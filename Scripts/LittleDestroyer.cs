using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LittleDestroyer : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "DeleteThis"){
            Destroy(other.gameObject);
        }
    }
}
