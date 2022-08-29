using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Shop : MonoBehaviour
{
    AudioSource m_MyAudioSource;
    [SerializeField] GameObject ShopMenuUI;
    [SerializeField] GameObject shopButton;
    [SerializeField] GameObject playButton;
    [SerializeField] GameObject shopExitButton;

    [SerializeField] GameObject upgradeButton;
    [SerializeField] Text ShieldLevelText;
    [SerializeField] Text ShieldMoneyText;
    [SerializeField] Text ShieldCD;
    [SerializeField] GameObject MoneyImage;
    [SerializeField] GameObject MaxShield;
    [SerializeField] GameObject ShieldMoneyText2;
    [SerializeField] GameObject ShieldCDGameObject;
    [SerializeField] GameObject ChrachterShop;

    int[] Shieldlevels=new int[7];
    int ShieldcurrentLvl=1;

    int coin;



    [SerializeField] GameObject PlatformupgradeButton;
    [SerializeField] Text PlatformLevelText;
    [SerializeField] Text PlatformMoneyText;
    [SerializeField] Text PlatformJumpText;
    [SerializeField] GameObject PlatformMoneyImage;
    [SerializeField] GameObject MaxPlatform;
    [SerializeField] GameObject PlatformMoneyText2;
    [SerializeField] GameObject PlatformJumpGameObject;
    int[] PlatformLevels=new int[7];
    int PlatformcurrentLvl=1;

    [SerializeField] GameObject DoubleupgradeButton;
    [SerializeField] Text DoubleLevelText;
    [SerializeField] Text DoubleMoneyText;
    [SerializeField] Text DoubleSecText;
    [SerializeField] GameObject DoubleMoneyImage;
    [SerializeField] GameObject MaxDouble;
    [SerializeField] GameObject DoubleMoneyText2;
    [SerializeField] GameObject DoubleSecTextObject;
    int[] DoubleLevels=new int[7];
    int DoublecurrentLvl=1;

    void Awake(){
        ShieldcurrentLvl = PlayerPrefs.GetInt("ShieldCurrentLevel",1);
        coin = PlayerPrefs.GetInt("NumberOfCoins",0);
        ShieldLevelText.text= PlayerPrefs.GetInt("ShieldCurrentLevel",1).ToString();
        ShieldMoneyText.text= PlayerPrefs.GetInt("ShieldMoney",200).ToString();
        ShieldCD.text = PlayerPrefs.GetFloat("ShieldCDP",2f).ToString()+" sec";

        PlatformcurrentLvl = PlayerPrefs.GetInt("PP_PlatformCurrentLevel",1);
        PlatformLevelText.text = PlayerPrefs.GetInt("PP_PlatformCurrentLevel",1).ToString();
        PlatformMoneyText.text = PlayerPrefs.GetInt("PP_PlatformMoney",300).ToString();
        PlatformJumpText.text = PlayerPrefs.GetInt("PP_PlatformJump",10).ToString();

        DoublecurrentLvl = PlayerPrefs.GetInt("PP_doubleCurrentLevel",1);
        DoubleLevelText.text = PlayerPrefs.GetInt("PP_doubleCurrentLevel",1).ToString();
        DoubleMoneyText.text = PlayerPrefs.GetInt("PP_DoubleMoneyText",500).ToString();
        DoubleSecText.text = PlayerPrefs.GetInt("PP_DoubleSecText",10).ToString()+" sec";
        
    }
    void Start(){
        if(ShieldcurrentLvl==6){
            upgradeButton.SetActive(false);
            MoneyImage.SetActive(false);
            MaxShield.SetActive(true);
            ShieldMoneyText2.SetActive(false);
        }

        if(PlatformcurrentLvl==6){
            PlatformupgradeButton.SetActive(false);
            PlatformMoneyImage.SetActive(false);
            MaxPlatform.SetActive(true);
            PlatformMoneyText2.SetActive(false);
        }

        if(DoublecurrentLvl==6){
            DoubleupgradeButton.SetActive(false);
            DoubleMoneyImage.SetActive(false);
            MaxDouble.SetActive(true);
            DoubleMoneyText2.SetActive(false);
        }
        m_MyAudioSource = GetComponent<AudioSource>();
    }


    public void Upgrade(){
        if(ShieldcurrentLvl<Shieldlevels.Length-1){
            if(ShieldcurrentLvl==1&&coin>=200){
                int price =500;
                float sec=3f;
                ShieldCD.text= sec.ToString()+" sec";
                ShieldcurrentLvl++;
                ShieldLevelText.text= ShieldcurrentLvl.ToString();
                coin-=200;
                PlayerPrefs.SetInt("NumberOfCoins",coin);
                PlayerPrefs.SetInt("ShieldCurrentLevel",ShieldcurrentLvl);
                PlayerPrefs.SetInt("ShieldMoney",price);   
                PlayerPrefs.SetFloat("ShieldCDP",sec);
                ShieldMoneyText.text= PlayerPrefs.GetInt("ShieldMoney",200).ToString(); 
                m_MyAudioSource.Play();            
            }else if(ShieldcurrentLvl==2&&coin>=500){ 
                float sec=4.5f;
                ShieldCD.text= sec.ToString()+" sec"; 
                PlayerPrefs.SetFloat("ShieldCDP",sec);              
                ShieldcurrentLvl++;
                ShieldLevelText.text= ShieldcurrentLvl.ToString();
                coin-=500;
                PlayerPrefs.SetInt("NumberOfCoins",coin);
                PlayerPrefs.SetInt("ShieldCurrentLevel",ShieldcurrentLvl);
                int price =1000;
                PlayerPrefs.SetInt("ShieldMoney",price);    
                ShieldMoneyText.text= PlayerPrefs.GetInt("ShieldMoney").ToString();   
                m_MyAudioSource.Play();                                 
            }
            else if(ShieldcurrentLvl==3&&coin>=1000){
                float sec=5.5f;
                ShieldCD.text= sec.ToString()+" sec"; 
                PlayerPrefs.SetFloat("ShieldCDP",sec);   
                ShieldcurrentLvl++;
                ShieldLevelText.text= ShieldcurrentLvl.ToString();
                coin-=1000;
                PlayerPrefs.SetInt("NumberOfCoins",coin);
                PlayerPrefs.SetInt("ShieldCurrentLevel",ShieldcurrentLvl);   
                int price =2500; 
                PlayerPrefs.SetInt("ShieldMoney",price);   
                ShieldMoneyText.text= PlayerPrefs.GetInt("ShieldMoney").ToString();
                m_MyAudioSource.Play();                                                 
            }
            else if(ShieldcurrentLvl==4&&coin>=2500){
                float sec=6.5f;
                ShieldCD.text= sec.ToString()+" sec"; 
                PlayerPrefs.SetFloat("ShieldCDP",sec);  
                ShieldcurrentLvl++;
                ShieldLevelText.text= ShieldcurrentLvl.ToString();
                coin-=2500;
                PlayerPrefs.SetInt("NumberOfCoins",coin);
                PlayerPrefs.SetInt("ShieldCurrentLevel",ShieldcurrentLvl);  
                int price =5000;
                PlayerPrefs.SetInt("ShieldMoney",price);   
                ShieldMoneyText.text= PlayerPrefs.GetInt("ShieldMoney").ToString(); 
                m_MyAudioSource.Play();                                                 
            }else if(ShieldcurrentLvl==5&&coin>=5000){
                float sec=8f;
                ShieldCD.text= sec.ToString()+" sec"; 
                PlayerPrefs.SetFloat("ShieldCDP",sec);  
                ShieldcurrentLvl++;
                ShieldLevelText.text= ShieldcurrentLvl.ToString();
                PlayerPrefs.SetInt("ShieldCurrentLevel",ShieldcurrentLvl);
                coin-=5000;
                PlayerPrefs.SetInt("NumberOfCoins",coin);
                upgradeButton.SetActive(false);
                MoneyImage.SetActive(false);
                MaxShield.SetActive(true);
                PlayerPrefs.SetString("ShieldMoney","");   
                ShieldMoneyText.text= PlayerPrefs.GetString("ShieldMoney");
                ShieldMoneyText2.SetActive(false);
                m_MyAudioSource.Play();       
            }
            
        }
    }
    public void UpgradePlatform(){
        if(PlatformcurrentLvl<PlatformLevels.Length-1){
            if(PlatformcurrentLvl==1&&coin>=300){
                PlatformcurrentLvl++;
                PlatformLevelText.text= PlatformcurrentLvl.ToString();
                PlayerPrefs.SetInt("PP_PlatformCurrentLevel",PlatformcurrentLvl);
                coin-=300;
                PlayerPrefs.SetInt("NumberOfCoins",coin);
                int Price = 750;
                PlayerPrefs.SetInt("PP_PlatformMoney",Price);
                PlatformMoneyText.text = PlayerPrefs.GetInt("PP_PlatformMoney").ToString();
                int JumpPower = 12;
                PlatformJumpText.text = JumpPower.ToString();
                PlayerPrefs.SetInt("PP_PlatformJump",12);
                m_MyAudioSource.Play();       
            }
            else if(PlatformcurrentLvl==2&&coin>=750){
                PlatformcurrentLvl++;
                PlatformLevelText.text= PlatformcurrentLvl.ToString();
                PlayerPrefs.SetInt("PP_PlatformCurrentLevel",PlatformcurrentLvl);
                coin-=750;
                PlayerPrefs.SetInt("NumberOfCoins",coin);
                int Price = 1250;
                PlayerPrefs.SetInt("PP_PlatformMoney",Price);
                PlatformMoneyText.text = PlayerPrefs.GetInt("PP_PlatformMoney").ToString();
                int JumpPower = 13;
                PlatformJumpText.text = JumpPower.ToString();
                PlayerPrefs.SetInt("PP_PlatformJump",13);
                m_MyAudioSource.Play();       
            }
            else if(PlatformcurrentLvl==3&&coin>=1250){
                PlatformcurrentLvl++;
                PlatformLevelText.text= PlatformcurrentLvl.ToString();
                PlayerPrefs.SetInt("PP_PlatformCurrentLevel",PlatformcurrentLvl);
                coin-=1250;
                PlayerPrefs.SetInt("NumberOfCoins",coin);
                int Price = 2500;
                PlayerPrefs.SetInt("PP_PlatformMoney",Price);
                PlatformMoneyText.text = PlayerPrefs.GetInt("PP_PlatformMoney").ToString();
                int JumpPower = 14;
                PlatformJumpText.text = JumpPower.ToString();
                PlayerPrefs.SetInt("PP_PlatformJump",14);
                m_MyAudioSource.Play();       
            }
            else if(PlatformcurrentLvl==4&&coin>=2500){
                PlatformcurrentLvl++;
                PlatformLevelText.text= PlatformcurrentLvl.ToString();
                PlayerPrefs.SetInt("PP_PlatformCurrentLevel",PlatformcurrentLvl);
                coin-=2500;
                PlayerPrefs.SetInt("NumberOfCoins",coin);
                int Price = 5000;
                PlayerPrefs.SetInt("PP_PlatformMoney",Price);
                PlatformMoneyText.text = PlayerPrefs.GetInt("PP_PlatformMoney").ToString();
                int JumpPower = 16;
                PlatformJumpText.text = JumpPower.ToString();
                PlayerPrefs.SetInt("PP_PlatformJump",16);
                m_MyAudioSource.Play();       
            }
            else if(PlatformcurrentLvl==5&&coin>=5000){
                PlatformcurrentLvl++;
                PlatformLevelText.text= PlatformcurrentLvl.ToString();
                PlayerPrefs.SetInt("PP_PlatformCurrentLevel",PlatformcurrentLvl);
                coin-=5000;
                PlayerPrefs.SetInt("NumberOfCoins",coin);
                PlayerPrefs.SetString("PP_PlatformMoney","");
                PlatformMoneyText.text = PlayerPrefs.GetInt("PP_PlatformMoney").ToString();
                int JumpPower = 18;
                PlatformJumpText.text = JumpPower.ToString();
                PlayerPrefs.SetInt("PP_PlatformJump",18);
                PlatformupgradeButton.SetActive(false);
                PlatformMoneyImage.SetActive(false);
                MaxPlatform.SetActive(true);
                PlatformMoneyText2.SetActive(false);
                m_MyAudioSource.Play();       
            }
        }
    }

    public void UpgradeDouble(){
        if(DoublecurrentLvl<DoubleLevels.Length-1){
            if(DoublecurrentLvl==1&&coin>=500){
                DoublecurrentLvl++;
                DoubleLevelText.text= DoublecurrentLvl.ToString();
                PlayerPrefs.SetInt("PP_doubleCurrentLevel",DoublecurrentLvl);
                coin-=500;
                PlayerPrefs.SetInt("NumberOfCoins",coin);
                int Price = 1500;
                PlayerPrefs.SetInt("PP_DoubleMoneyText",Price);
                DoubleMoneyText.text = PlayerPrefs.GetInt("PP_DoubleMoneyText").ToString();
                int DoubleSec = 13;
                DoubleSecText.text = DoubleSec.ToString()+" sec";
                PlayerPrefs.SetInt("PP_DoubleSecText",13);
                m_MyAudioSource.Play();       
            }
            else if(DoublecurrentLvl==2&&coin>=1500){
                DoublecurrentLvl++;
                DoubleLevelText.text= DoublecurrentLvl.ToString();
                PlayerPrefs.SetInt("PP_doubleCurrentLevel",DoublecurrentLvl);
                coin-=1500;
                PlayerPrefs.SetInt("NumberOfCoins",coin);
                int Price = 3000;
                PlayerPrefs.SetInt("PP_DoubleMoneyText",Price);
                DoubleMoneyText.text = PlayerPrefs.GetInt("PP_DoubleMoneyText").ToString();
                int DoubleSec = 16;
                DoubleSecText.text = DoubleSec.ToString()+" sec";
                PlayerPrefs.SetInt("PP_DoubleSecText",16);
                m_MyAudioSource.Play();       
            }
            else if(DoublecurrentLvl==3&&coin>=3000){
                DoublecurrentLvl++;
                DoubleLevelText.text= DoublecurrentLvl.ToString();
                PlayerPrefs.SetInt("PP_doubleCurrentLevel",DoublecurrentLvl);
                coin-=3000;
                PlayerPrefs.SetInt("NumberOfCoins",coin);
                int Price = 5000;
                PlayerPrefs.SetInt("PP_DoubleMoneyText",Price);
                DoubleMoneyText.text = PlayerPrefs.GetInt("PP_DoubleMoneyText").ToString();
                int DoubleSec = 19;
                DoubleSecText.text = DoubleSec.ToString()+" sec";
                PlayerPrefs.SetInt("PP_DoubleSecText",19);
                m_MyAudioSource.Play();       
            }
            else if(DoublecurrentLvl==4&&coin>=5000){
                DoublecurrentLvl++;
                DoubleLevelText.text= DoublecurrentLvl.ToString();
                PlayerPrefs.SetInt("PP_doubleCurrentLevel",DoublecurrentLvl);
                coin-=5000;
                PlayerPrefs.SetInt("NumberOfCoins",coin);
                int Price = 10000;
                PlayerPrefs.SetInt("PP_DoubleMoneyText",Price);
                DoubleMoneyText.text = PlayerPrefs.GetInt("PP_DoubleMoneyText").ToString();
                int DoubleSec = 22;
                DoubleSecText.text = DoubleSec.ToString()+" sec";
                PlayerPrefs.SetInt("PP_DoubleSecText",22);
                m_MyAudioSource.Play();       
            }
            else if(DoublecurrentLvl==5&&coin>=10000){
                DoublecurrentLvl++;
                DoubleLevelText.text= DoublecurrentLvl.ToString();
                PlayerPrefs.SetInt("PP_doubleCurrentLevel",DoublecurrentLvl);
                coin-=10000;
                PlayerPrefs.SetInt("NumberOfCoins",coin);
                PlayerPrefs.SetString("PP_DoubleMoneyText","");
                DoubleMoneyText.text = PlayerPrefs.GetInt("PP_DoubleMoneyText").ToString();
                int DoubleSec = 25;
                DoubleSecText.text = DoubleSec.ToString()+" sec";
                PlayerPrefs.SetInt("PP_DoubleSecText",25);
                m_MyAudioSource.Play();     
                DoubleupgradeButton.SetActive(false);
                DoubleMoneyImage.SetActive(false);
                MaxDouble.SetActive(true);
                DoubleMoneyText2.SetActive(false);  
            }
        }

    }


    public void OpenShop(){
        ShopMenuUI.SetActive(true);
        shopButton.SetActive(false);
        shopExitButton.SetActive(true);
        playButton.SetActive(false);
        ChrachterShop.SetActive(false);
        
    }

    public void CloseShop(){
        shopExitButton.SetActive(false);
        shopButton.SetActive(true);
        ShopMenuUI.SetActive(false);
        playButton.SetActive(true);
        ChrachterShop.SetActive(true);
        
    }
}
        

    



