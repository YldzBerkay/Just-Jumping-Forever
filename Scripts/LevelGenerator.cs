using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    const float PLAYER_DISTANCE_SPAWN_LEVEL_PART = 25f;
    [SerializeField] Transform levelPartStart;
    [SerializeField] List<Transform> levelPartList;
    [SerializeField] List<Transform> MidlevelPartList;
    [SerializeField] List<Transform> MidPartList;
    [SerializeField] GameObject Player;
    private Vector3 lastEndPosition;
    float currentScore;

    void Awake(){
        lastEndPosition = levelPartStart.Find("EndPosition").position;
        int startingSpawnLevelParts=5;
        for(int i=0;i<startingSpawnLevelParts;i++){
            SpawnLevelPart();
        }
        
    }
    void FixedUpdate(){
        if(Vector3.Distance(Player.transform.position,lastEndPosition)< PLAYER_DISTANCE_SPAWN_LEVEL_PART){
            SpawnLevelPart();
        }
        currentScore = PlayerPrefs.GetFloat("curScore");
    }

    void SpawnLevelPart(){
        if(currentScore<7000){
            Transform chosenLevelPart = levelPartList[Random.Range(0,levelPartList.Count)];
            Transform lastLevelPartTransform = SpawnLevelPart(chosenLevelPart, lastEndPosition);
            lastEndPosition = lastLevelPartTransform.Find("EndPosition").position; 
        }else if (currentScore>7000 && currentScore<30000){
            Transform chosenLevelPart = MidlevelPartList[Random.Range(0,MidlevelPartList.Count)];
            Transform lastLevelPartTransform = SpawnLevelPart(chosenLevelPart, lastEndPosition);
            lastEndPosition = lastLevelPartTransform.Find("EndPosition").position; 
        }
        else if (currentScore>30000){
            Transform chosenLevelPart = MidPartList[Random.Range(0,MidPartList.Count)];
            Transform lastLevelPartTransform = SpawnLevelPart(chosenLevelPart, lastEndPosition);
            lastEndPosition = lastLevelPartTransform.Find("EndPosition").position; 
        }
        
    }

    Transform SpawnLevelPart(Transform LevelPart, Vector3 spawnPosition){
        Transform lastLevelPartTransform = Instantiate(LevelPart,spawnPosition,Quaternion.identity);
        return lastLevelPartTransform;
    }



}