using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 


public class SceneChange : MonoBehaviour
{
    public void Play() {  
        SceneManager.LoadScene("Game");  
        Time.timeScale = 1f;
    } 
    public void Menu() {  
        SceneManager.LoadScene("MainMenu");  
        Time.timeScale = 1f;
    } 
    public void CharachterShop() {  
        SceneManager.LoadScene("CharachterShop");  
        Time.timeScale = 1f;
    } 
    public void Quit(){
        Application.Quit();
    }
}
