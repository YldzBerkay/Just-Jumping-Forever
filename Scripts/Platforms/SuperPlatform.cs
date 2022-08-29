using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuperPlatform : MonoBehaviour
{
    int PlatformcurrentLvl;
    [SerializeField] float JumpForce;





    void OnCollisionEnter2D(Collision2D col){

        PlatformcurrentLvl = PlayerPrefs.GetInt("PP_PlatformCurrentLevel",1);
        if(PlatformcurrentLvl==1){
            JumpForce=10;
        }else if(PlatformcurrentLvl==2){
            JumpForce=12;
        }
        else if(PlatformcurrentLvl==3){
            JumpForce=13;
        }
        else if(PlatformcurrentLvl==4){
            JumpForce=14;
        }
        else if(PlatformcurrentLvl==5){
            JumpForce=16;
        }
        else if(PlatformcurrentLvl==6){
            JumpForce=18;
        }
        if(col.relativeVelocity.y<=0f){
            Rigidbody2D rb = col.collider.GetComponent<Rigidbody2D>();
            if(rb!=null){
                Vector2 velocity = rb.velocity;
                velocity.y = JumpForce;
                rb.velocity = velocity;
                
            }  
            
        }  
    }
}
