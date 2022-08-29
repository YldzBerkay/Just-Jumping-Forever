using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Player : MonoBehaviour
{
    Rigidbody2D rb;
    Animator playerAnimator;
    AudioSource jumpSound;
    [SerializeField] LayerMask Layer;

    [SerializeField] float movementSpeed;
    private float movement;
    private float movespeed;
    private GameObject shield;
    
    [SerializeField] bool isGrounded = false;
    bool facingRight=true;
    int ShieldcurrentLvl;
    int doubleCurrentLevel;
    public static int velocityY;
    int nextGenScore;
    int setDouble;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        playerAnimator = GetComponent<Animator>();
        jumpSound = GetComponent<AudioSource>();
        shield = transform.Find("Shield").gameObject;
        shield.SetActive(false);
        ShieldcurrentLvl = PlayerPrefs.GetInt("ShieldCurrentLevel",1);
        doubleCurrentLevel = PlayerPrefs.GetInt("PP_doubleCurrentLevel",1);
        PlayerPrefs.SetInt("PP_PowerUp",1);
        setDouble=1;
    }


    void FixedUpdate()
    {

        telefon();
        OnGroundCheck();
        if(this.rb.velocity.y>0&&CameraFollow.positionY<=this.transform.position.y){
            if(setDouble==1){
                nextGenScore+=7;
            }else if(setDouble==2){
                nextGenScore+=14;
            }
            
        }
        velocityY=nextGenScore;
    }



    void OnGroundCheck(){
        if(this.rb.velocity.y<=0f){
            
            isGrounded = true;
            playerAnimator.SetBool("isGrounded",isGrounded);
            
        }
        else{
            isGrounded=false;
            playerAnimator.SetBool("isGrounded",isGrounded);
        }
        
    }

    void telefon(){
        movespeed = Input.acceleration.x * movement;
        var mMax = Input.gyro.attitude.eulerAngles.x * Time.timeScale;

        TurnYourFaceMobil();
        mMax = 30;


        transform.Translate(Input.acceleration.x / 4f, 0, 0);
    }

    
    void TurnYourFaceMobil(){
        if (Input.acceleration.x < -0.01 && facingRight)
        {
            facingRight = !facingRight;
            Vector3 tempLocalScale = transform.localScale;
            tempLocalScale.x *= -1;
            transform.localScale = tempLocalScale;
        }
        else if (Input.acceleration.x > 0.01 && !facingRight)
        {
            facingRight = !facingRight;
            Vector3 tempLocalScale = transform.localScale;
            tempLocalScale.x *= -1;
            transform.localScale = tempLocalScale;
        }
    }

    void OnCollisionEnter2D(Collision2D col){
        if(col.gameObject.CompareTag("Platform")&&isGrounded==true){
            jumpSound.Play();
        }
    }

    void OnTriggerEnter2D(Collider2D other){
        if(other.CompareTag("Enemy")){
            if(shield.activeInHierarchy){
                Destroy(other.gameObject);
                shield.SetActive(false);
                
            }else{
                GameFinish.GameIsFinish=true;
            }
        }else if(other.CompareTag("ShieldPickup")){
            StartCoroutine(shieldPickupIE());
            Destroy(other.gameObject);
        }

        if(other.CompareTag("Double")){
            StartCoroutine(DoubleIE());
            Destroy(other.gameObject);
        }
    }


    IEnumerator shieldPickupIE () {
        shield.SetActive(true);
        if(ShieldcurrentLvl==1){
            yield return new WaitForSeconds (2f);
        }
        else if(ShieldcurrentLvl==2){
            yield return new WaitForSeconds (3f);
        }
        else if(ShieldcurrentLvl==3){
            yield return new WaitForSeconds (4.5f);
        }
        else if(ShieldcurrentLvl==4){
            yield return new WaitForSeconds (5.5f);
        }
        else if(ShieldcurrentLvl==5){
            yield return new WaitForSeconds (6.5f);
        }
        else if(ShieldcurrentLvl==6){
            yield return new WaitForSeconds (8f);
        }
        shield.SetActive(false);
        
    }

    IEnumerator DoubleIE () {
        PlayerPrefs.SetInt("PP_PowerUp",2);
        setDouble=2;
        if(doubleCurrentLevel==1){
            yield return new WaitForSeconds (10f);
        }
        else if(doubleCurrentLevel==2){
            yield return new WaitForSeconds (13f);
        }
        else if(doubleCurrentLevel==3){
            yield return new WaitForSeconds (16f);
        }
        else if(doubleCurrentLevel==4){
            yield return new WaitForSeconds (19f);
        }
        else if(doubleCurrentLevel==5){
            yield return new WaitForSeconds (22f);
        }
        else if(doubleCurrentLevel==6){
            yield return new WaitForSeconds (25f);
        }
        PlayerPrefs.SetInt("PP_PowerUp",1);
        setDouble=1;
    }


}
