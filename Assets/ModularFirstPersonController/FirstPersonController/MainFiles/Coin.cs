using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coin : MonoBehaviour{  
    public bool diadromos = true;
    public float[] CoinR =  { 0 , 0, 0 , 0 , 0 , 0 };
    public GameObject coin;

    
     public void Start(){

        CoinR[5] = 4;
    }


     
        public void Update(){


            //The ifs will choose the coordinates' range where the coins will spawn depending on what διάδρομος we are in 

            //if(level1 == true){
            CoinR[0] = -51;     CoinR[1] = -32;     CoinR[2] = 1;     CoinR[3] = -24;     CoinR[4] = -20; 
            /*}
            else if(level2 == true){
                CoinR[0] = -21;     CoinR[1] = -33;     CoinR[2] = 4;     CoinR[3] = -54;     CoinR[4] = -16;
            } ....
            */
            if (diadromos ==true){
                for(float i=0; i<= CoinR[5]; i++){
                    Invoke("SpawnCoin",0.3f);
                }
                diadromos= false;
            }

    
        
        }

        public void SpawnCoin(){
            Vector3 randCoinPos = new Vector3(Random.Range(CoinR[0], CoinR[1]), CoinR[2], Random.Range(CoinR[3], CoinR[4]));
            Quaternion CoinQ = new Quaternion(0,0,0,0);
            Instantiate(coin, randCoinPos, CoinQ);

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
