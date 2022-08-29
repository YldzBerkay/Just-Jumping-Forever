using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    [SerializeField] GameObject[] PlayerPrefabs;
    int characterIndex;
    GameObject Player;

    void Awake(){
        characterIndex = PlayerPrefs.GetInt("SelectedChac",0);
        Player = Instantiate(PlayerPrefabs[characterIndex],this.transform.position,Quaternion.identity);
    }

    void FixedUpdate(){
        this.transform.position= Player.transform.position;
    }
}
