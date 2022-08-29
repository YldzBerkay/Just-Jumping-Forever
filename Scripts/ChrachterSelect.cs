using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChrachterSelect : MonoBehaviour
{
    [SerializeField] GameObject[] skins;
    [SerializeField] int SelectedChac;
    [SerializeField] Chrachter[] chrachters;

    [SerializeField] Button unlockButton;
    void Awake()
    {
        SelectedChac = PlayerPrefs.GetInt("SelectedChac",0);
        foreach(GameObject player in skins){
            player.SetActive(false);
        }
        skins[SelectedChac].SetActive(true);

        foreach(Chrachter c in chrachters){
            if(c.price==0){
                c.isUnlocked=true;
            }else{
                c.isUnlocked=PlayerPrefs.GetInt(c.name, 0)==0 ? false: true;
            }
        }
        UpdateUI();
    }

    public void changeNext(){
        skins[SelectedChac].SetActive(false);
        SelectedChac++;
        if(SelectedChac==skins.Length){
            SelectedChac=0;
        }
        skins[SelectedChac].SetActive(true);
        if(chrachters[SelectedChac].isUnlocked){
            PlayerPrefs.SetInt("SelectedChac",SelectedChac);
        }
        UpdateUI();
    }

    public void changePrevious(){
        skins[SelectedChac].SetActive(false);
        SelectedChac--;
        if(SelectedChac==-1){
            SelectedChac=skins.Length-1;
        }
        skins[SelectedChac].SetActive(true);
        if(chrachters[SelectedChac].isUnlocked){
            PlayerPrefs.SetInt("SelectedChac",SelectedChac);
        }
        UpdateUI();
    }

    public void UpdateUI(){
        if(chrachters[SelectedChac].isUnlocked == true){
            unlockButton.gameObject.SetActive(false);
        }else{
            unlockButton.GetComponentInChildren<Text>().text = "Price: "+chrachters[SelectedChac].price;
            if(PlayerPrefs.GetInt("NumberOfCoins",0)<chrachters[SelectedChac].price){
                unlockButton.gameObject.SetActive(true);
                unlockButton.interactable=false;
            }else{
                unlockButton.gameObject.SetActive(true);
                unlockButton.interactable=true;
            }
        }
        
    }

    public void Unlock(){
        int coins =PlayerPrefs.GetInt("NumberOfCoins",0);
        int price = chrachters[SelectedChac].price;
        PlayerPrefs.SetInt(("NumberOfCoins"),coins-price);
        PlayerPrefs.SetInt(chrachters[SelectedChac].name,1);
        PlayerPrefs.SetInt("SelectedChac",SelectedChac);
        chrachters[SelectedChac].isUnlocked = true;
        UpdateUI();
    }
}
