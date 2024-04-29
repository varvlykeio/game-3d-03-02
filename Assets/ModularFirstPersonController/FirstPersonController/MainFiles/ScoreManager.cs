
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class ScoreManager : MonoBehaviour
{

    #region Important

    /*[SerializeField] TextMeshProUGUI TotalScore;
    public TextMeshProUGUI TotalScoreText { get { return TotalScore; } }

    void UpdateUIScore(){
        uIElements.ResolutionScoreText.text = "+" + score;


    }*/
    #endregion Important

 /*   
    public Text scoreText;

    public static int score;


    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = " Score_Snene " + Mathf.Round(score);
        
    }

public static ScoreManager instance;
   
    private void Awake()
    {
        instance = this;
    } 
    private void OnTriggerEnter(Collider other)
    {
        //if(other.gameObject.CompareTag("Coin"))
        if(other.gameObject.name == "Player")
        //if(other.gameObject.CompareTag("player"))
        {
            Destroy(other.gameObject);
            other.gameObject.SetActive(false);
           ScoreManager.instance.Addpoints();
            //Addpoints();
           // Debug.Log(Coin);
            //return;
        }
        else
        {
            
            
            //ScoreManager.instance.Addpoints();
           
        }


        
    }
    

    // 
    public void Addpoints()
    {
        score += 10;
        scoreText.text = "Score_Snene" + score.ToString();
    }*/
}

