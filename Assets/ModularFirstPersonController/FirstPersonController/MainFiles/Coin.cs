using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MyVars;
using UnityEngine.UI;
using GameEv;


namespace CoinsNS{
    public class Coin : MonoBehaviour{  

        MyVarsClass coins = null;
        [SerializeField]    GameEvents          events                  = null;



        /*public void Update(){
            

            

        }*/

        

        public void OnTriggerEnter(){
            GameObject tempObj = GameObject.Find("Control Center");
            coins = tempObj.GetComponent<MyVarsClass>();
            events.TotalScore += 1;
            Destroy(gameObject);
        
            

        }

        

        /*private void OnTriggerEnter(Collider other)
        {
            //if(other.gameObject.CompareTag("Player"))
            //if(other.gameObject.tag == "Player")
            //if(other.gameObject.CompareTag("player"))
            if (other.CompareTag("Player"))
            {
                Destroy(other.gameObject);
                //other.gameObject.SetActive(false);
            
                ScoreManager.score += 10;
            //ScoreManager.instance.Addpoints();
                //Addpoints();
            // Debug.Log(Coin);
                //return;
            }
            else
            {
                
                
                //ScoreManager.instance.Addpoints();
            
            }


            
        }*/


    }
}   
