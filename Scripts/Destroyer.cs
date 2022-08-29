using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Destroyer : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Platform"){
            Destroy(other.gameObject);
        }
        if(other.gameObject.tag == "ShieldPickup"){
            Destroy(other.gameObject);
        }
        if(other.gameObject.tag == "Enemy"){
            Destroy(other.gameObject);
        }
        if(other.gameObject.tag == "Coin"){
            Destroy(other.gameObject);
        }
        if(other.gameObject.tag == "Double"){
            Destroy(other.gameObject);
        }
    }
}
