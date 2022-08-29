using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DissaperingPlatform : MonoBehaviour
{
    private float JumpForce = 7f;

    void OnCollisionEnter2D(Collision2D col){
        if(col.gameObject.CompareTag("Player")){
            if(col.relativeVelocity.y<=0f){
                Rigidbody2D rb = col.collider.GetComponent<Rigidbody2D>();
                if(rb!=null){
                    Vector2 velocity = rb.velocity;
                    velocity.y = JumpForce;
                    rb.velocity = velocity;
                    Destroy(this.gameObject);
                }  
            }
        
        }  
    }
}
