using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PauseMenu : MonoBehaviour
{
    [SerializeField] static bool GameIsPause = false;
    [SerializeField] GameObject pauseMenuUI;
    [SerializeField] GameObject pauseButton;

    void Update(){
        if(Input.GetKeyDown(KeyCode.Escape)){
            if(GameIsPause){
                Resume();
            }else{
                Pause();
            }
        }
    }

    public void Resume(){
        pauseMenuUI.SetActive(false);
        pauseButton.SetActive(true);
        Time.timeScale=1f;
        GameIsPause=false;

    }

    public void Pause(){
        pauseMenuUI.SetActive(true);
        pauseButton.SetActive(false);
        Time.timeScale = 0f;
        GameIsPause = true;
    }

    public void Menu(){
        Time.timeScale = 1f;
        GameIsPause = false;
        SceneManager.LoadScene("MainMenu");  
    }
}
