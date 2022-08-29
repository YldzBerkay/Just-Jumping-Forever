using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoScript : MonoBehaviour
{
    [SerializeField] GameObject InfoUI;
    [SerializeField] GameObject InfoUI2;



    public void OpenUI()
    {
        InfoUI.SetActive(true);
    }

    public void InfoNext()
    {
        InfoUI.SetActive(false);
        InfoUI2.SetActive(true);
    }
    public void exitUI()
    {
        InfoUI2.SetActive(false);
        Time.timeScale = 1f;
        PlayerPrefs.SetFloat("Info", 1);
        
    }
}
