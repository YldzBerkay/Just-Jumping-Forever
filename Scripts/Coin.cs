using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col){
        if(col.transform.tag=="TakeMoney"){
            
            Destroy(gameObject);
            
            CoinManager.numberOfCoins+=5;
            PlayerPrefs.SetInt("NumberOfCoins",CoinManager.numberOfCoins);
        }
    }
}
