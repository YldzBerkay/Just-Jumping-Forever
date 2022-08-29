using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameFinish : MonoBehaviour
{
    public static bool GameIsFinish = false;
    [SerializeField] GameObject deathMenuUI;
    [SerializeField] GameObject pauseButton;
    [SerializeField] Text GameScoreText;
    [SerializeField] Text GameSpeedText;
    [SerializeField] Text GameScoreText1;
    [SerializeField] Text GameSpeedText1;
    [SerializeField] Image MoneyImage;
    [SerializeField] Text MoneyText;
    void Start()
    {
        Time.timeScale = 1f;
        deathMenuUI.SetActive(false);
        GameIsFinish = false;
    }
    void Update()
    {
        death();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            GameIsFinish = true;
        }
    }

    void death()
    {
        if (GameIsFinish == true)
        {
            deathMenuUI.SetActive(true);
            pauseButton.SetActive(false);
            Destroy(GameScoreText);
            Destroy(GameSpeedText);
            Destroy(GameScoreText1);
            Destroy(GameSpeedText1);
            Destroy(MoneyImage);
            Destroy(MoneyText);
            Time.timeScale = 0f;
            GameIsFinish = true;
        }
    }
}
