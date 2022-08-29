using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinManager : MonoBehaviour
{
    [SerializeField] Text CoinText;
    [SerializeField] Text DeadCoinText;
    
    public static int numberOfCoins;

    void Awake(){
        numberOfCoins = PlayerPrefs.GetInt("NumberOfCoins",0);
    }
    void FixedUpdate()
    {
        CoinText.text = numberOfCoins.ToString();
        DeadCoinText.text = numberOfCoins.ToString();
    }
}
