using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MenuScore : MonoBehaviour
{
    [SerializeField] Text HighScoreText;
    [SerializeField] Text CoinText;
    void Start()
    {
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {   if(PlayerPrefs.GetFloat("maxScore")==0){
        HighScoreText.text = "0";
    }else{
        HighScoreText.text = PlayerPrefs.GetFloat("maxScore").ToString();
    }
        CoinText.text = PlayerPrefs.GetInt("NumberOfCoins").ToString();
    }
}
