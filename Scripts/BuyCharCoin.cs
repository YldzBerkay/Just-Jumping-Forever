using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyCharCoin : MonoBehaviour
{
    [SerializeField] Text coin;
    void FixedUpdate()
    {
        coin.text=PlayerPrefs.GetInt("NumberOfCoins",0).ToString();
    }
    private void Awake()
    {
        coin.text = PlayerPrefs.GetInt("NumberOfCoins", 0).ToString();
    }

}
