using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField] Transform Playerr;
    [SerializeField] Text scoreText;
    [SerializeField] Text deathText;
    [SerializeField] Text HighScoreText;
    [SerializeField] Text gameSpeedText;
    private int score=0;
    int doubleCurrentLevel;
    int powerUp;
    int doubleOpenClose;
    
    
    void Start()
    {
        scoreText.text = "0";
        gameSpeedText.text = "x1.00";
        doubleCurrentLevel = PlayerPrefs.GetInt("PP_doubleCurrentLevel",1);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        curScore();
        gameSpeed();
        HighScore();
        HighScoreText.text = PlayerPrefs.GetFloat("maxScore").ToString();
        doubleOpenClose=PlayerPrefs.GetInt("PP_PowerUp",1);
    }
    
    void curScore(){
        score = Player.velocityY;
        scoreText.text = score.ToString();
        PlayerPrefs.SetFloat("curScore",score);
        deathText.text = score.ToString(); 
    }

    void HighScore(){
        if(PlayerPrefs.GetFloat("maxScore") < score){
            PlayerPrefs.SetFloat("maxScore", score);
            HighScoreText.text = PlayerPrefs.GetFloat("maxScore").ToString();
        }  
    }
    

    void gameSpeed(){
        if(score>7500&&score<12500){
            Time.timeScale = 1.10f;
            gameSpeedText.text="x1.10";
        }
        else if(score>12500&&score<40000){
            Time.timeScale = 1.25f;
            gameSpeedText.text="x1.25";
        }
        else if(score>40000&&score<75000){
            Time.timeScale = 1.35f;
            gameSpeedText.text="x1.35";
        }
        else if(score>75000&&score<100000){
            Time.timeScale = 1.5f;
            gameSpeedText.text="x1.5";
        }
        else if(score>150000){
            Time.timeScale = 1.75f;
            gameSpeedText.text="Max";
        }
        
    }
}
